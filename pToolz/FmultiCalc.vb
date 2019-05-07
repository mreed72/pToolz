'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================





Public Class FmultiCalc
    Private x As New xFuels.ClassFuels
    Private sADJ, zTotalSize, zTotalTons As Integer
    Private XGX As String

    Private Sub FmultiCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbLabel001.Visible = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

#Region "Quick Error Checking"
        'Quick Error Checking before Calculating
        If txBlockSize.Text = "" Then
            txBlockSize.BackColor = Drawing.Color.Yellow
            txBlockSize.Focus()
            Exit Sub
        Else
            txBlockSize.BackColor = Drawing.Color.White
        End If

        If txFtype.SelectedIndex = -1 Then
            txFtype.BackColor = Color.Yellow
            Exit Sub
        Else
            txFtype.BackColor = Color.White
        End If

        If txFload.SelectedIndex = -1 Then
            txFload.BackColor = Color.Yellow
            Exit Sub
        Else
            txFload.BackColor = Color.White
        End If
#End Region


        Try

            Dim avf As Double
            avf = x.GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
            Dim tfv As Integer
            tfv = Val(txBlockSize.Text) * Val(avf)

            dgv1.Rows.Add(txBlockSize.Text, txFtype.SelectedItem, txFload.SelectedItem, avf, tfv)



            txBlockSize.Clear()
            txFtype.SelectedIndex = -1
            txFload.SelectedIndex = -1
            txBlockSize.Focus()
        Catch ex As Exception
            x.ERRlog("1X3R483Y", ex.Message) ' ERROR LOG CODE
        End Try



    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

#Region "Quick Error Checking"
        'Quick Error Checking before Calculating
        If txCatDay.Text = "" Then
            txCatDay.BackColor = Drawing.Color.Yellow
            txCatDay.Focus()
            Exit Sub
        Else
            txCatDay.BackColor = Drawing.Color.White
        End If
        If txDistance.Text = "" Then
            txDistance.BackColor = Drawing.Color.Yellow
            txDistance.Focus()
            Exit Sub
        Else
            txDistance.BackColor = Drawing.Color.White
        End If
#End Region

        XGX = x.grs(5)


        Try
            sADJ = x.smpCalc(txCatDay.Text, txDistance.Text)
            If txTotalTons.Text > sADJ Then
                txResults.Text = "Your burn WILL exceed the guidelines."
                txResults.BackColor = Color.LightPink
            Else
                txResults.Text = "Your burn WILL NOT exceed the guidelines."
                txResults.BackColor = Color.White
            End If

            txAllowed.Text = sADJ

            zTotalSize = 0
            zTotalTons = 0
        Catch ex As Exception
            x.ERRlog("1X0IQTO7", ex.Message) ' ERROR LOG CODE
        End Try


        Try
            'Session Log
            DGtoCSV()

            Dim cd, aw, ts, tt As Integer
            Dim td As Double
            Dim res As String
            Dim SesID As Integer
            SesID = My.Settings.CurrentSessionID
            Dim XL As String = "C:\SMTOOLZ\Sessions\" & SesID & "\Multilog_" & XGX & ".csv"
            cd = txCatDay.Text
            aw = txAllowed.Text
            ts = txTotalSize.Text
            tt = txTotalTons.Text
            td = txDistance.Text
            res = txResults.Text

            x.SESLog("MULTI FUELS CALCULATOR", "Log ID: " & XL & vbCrLf & "Category Day: " & cd & vbCrLf & "Target Distance: " & td & vbCrLf & "Total Size: " & ts _
                     & vbCrLf & "Total Allowed: " & aw & vbCrLf & "Total Tons: " & tt & vbCrLf & "Results: " & res)


            lbLabel001.Visible = True
            lbLabel001.Text = XL

            If My.Settings.CurrentSessionID = String.Empty Then
                Form1.myicon.ShowBalloonTip(2000, "Smoke Calculator", "NO SESSION LOG CREATED!", ToolTipIcon.Info)
            Else
                Form1.myicon.ShowBalloonTip(2000, "Smoke Calculator", "Session log has been saved!", ToolTipIcon.Info)
            End If

        Catch ex As Exception
            x.ERRlog("1XERY3DD", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub

    Function DGtoCSV()
        Try
            Dim SesID As Integer
            SesID = My.Settings.CurrentSessionID
            Dim LL As String = "C:\SMTOOLZ\Sessions\" & SesID & "\Multilog_" & XGX & ".csv"
            Dim StrExport As String = ""
            For Each C As DataGridViewColumn In dgv1.Columns
                StrExport &= """" & C.HeaderText & ""","
            Next
            StrExport = StrExport.Substring(0, StrExport.Length - 1)
            StrExport &= Environment.NewLine

            For Each R As DataGridViewRow In dgv1.Rows
                For Each C As DataGridViewCell In R.Cells
                    If Not C.Value Is Nothing Then
                        StrExport &= """" & C.Value.ToString & ""","
                    Else
                        StrExport &= """" & "" & ""","
                    End If
                Next
                StrExport = StrExport.Substring(0, StrExport.Length - 1)
                StrExport &= Environment.NewLine
            Next

            Dim tw As IO.TextWriter = New IO.StreamWriter(LL)
            tw.Write(StrExport)
            tw.Close()
        Catch ex As Exception
            x.ERRlog("1XXTGJCB", ex.Message) ' ERROR LOG CODE
        End Try

    End Function


    Private Sub dgv1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv1.RowsAdded

        Try
            Dim xA, xB As Double
            For Each row As DataGridViewRow In dgv1.Rows
                xA += row.Cells(0).Value
                xB += row.Cells(4).Value
            Next

            'displays the results
            txTotalSize.Text = xA
            txTotalTons.Text = xB
        Catch ex As Exception
            x.ERRlog(ex.Message, "8x9WQCX") ' ERROR LOG CODE
        End Try


    End Sub

    Private Sub lbLabel001_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbLabel001.LinkClicked
        Try
            Diagnostics.Process.Start(lbLabel001.Text)
        Catch ex As Exception
            x.ERRlog(ex.Message, "8xFKB2K") ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEAR
        Try
            txBlockSize.Clear()
            txFtype.SelectedIndex = -1
            txFload.SelectedIndex = -1
            txCatDay.Clear()
            txDistance.Clear()
            txTotalSize.Text = 0
            txTotalTons.Text = 0
            txResults.Clear()
            txResults.BackColor = Color.White
            zTotalSize = 0
            zTotalTons = 0
            lbLabel001.Visible = False
            dgv1.Rows.Clear()

        Catch ex As Exception
            x.ERRlog("1XGDPQBL", ex.Message) ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            Dim t As Integer = TrackBar1.Value
            Dim x As Integer = txFtype.SelectedIndex
            Select Case t
                Case 0
                    x = 0
                Case 1
                    x = 1
                Case 2
                    x = 2
                Case 3
                    x = 3
                Case 4
                    x = 4
                Case 5
                    x = 5
                Case 6
                    x = 6
                Case 7
                    x = 7
                Case 8
                    x = 8
                Case 9
                    x = 9
                Case 10
                    x = 10
                Case 11
                    x = 11
                Case 12
                    x = 12
                Case 13
                    x = 13
                Case Else
                    x = -1
            End Select

            txFtype.SelectedIndex = x
        Catch ex As Exception
            x.ERRlog("1XZV9YEZ", ex.Message) ' ERROR LOG CODE
        End Try
    End Sub
End Class