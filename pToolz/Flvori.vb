'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================



Imports xFuels

Public Class Flvori
    Private x1 As New xFuels.ClassFuels


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            txResult.Text = X1.LVORI_day(txRH.Value, txADI.Value)
            rtb1.Text = cdvalue()
        Catch ex As Exception
            X1.ERRlog("1X23ZD64", ex.Message) ' ERROR LOG CODE
        End Try

        Try
            'Session Log
            Dim xR, xA As Integer
            Dim res As String

            xR = txRH.Value
            xA = txADI.Value
            res = txResult.Text


            x.SESLog("LVORI", "Relative Humidity: " & xR & vbCrLf & "Atmospheric Dispersion Index: " & xA & vbCrLf & "Result: " & res)

            If My.Settings.CurrentSessionID = String.Empty Then
                Form1.myicon.ShowBalloonTip(2000, "LVORI", "NO SESSION LOG CREATED!", ToolTipIcon.Info)
            Else
                Form1.myicon.ShowBalloonTip(2000, "LVORI", "Session log has been saved!", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            X1.ERRlog("1X36RVM5", ex.Message) ' ERROR LOG CODE
        End Try


    End Sub

    Function cdvalue()
        'ADI Value
        Try
            Dim ADI As Integer = txADI.Value
            Select Case ADI
                Case 0 To 20
                    Return "Poor dispersion, stagnant if persistent."
                Case 21 To 40
                    Return "Poor to fair, stagnation may be indicated if accompanied by low wind speeds."
                Case 41 To 60
                    Return "Generally Good."
                Case 61 To 80
                    Return "Very good dispersion. 75 and above, Control problems likely."
                Case > 80
                    Return "Excellent dispersion, Control problems expected."
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            X1.ERRlog("1XZ9J7X0", ex.Message) ' ERROR LOG CODE
        End Try



    End Function

    Private Sub Flvori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtb1.Clear()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            MessageBox.Show("Lavdas Atmospheric Dispersion Index (ADI) was designed to estimate the atmosphere's ability to disperse smoke from a prescribed fire. The ADI forecast is computed from the 20-foot wind speed, mixing height, transport wind, and cloud cover." _
                        & "Values of ADI range from <= 6 indicating very poor dispersion to >=100 indicating very good dispersion", "ADI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            X1.ERRlog("1XYJCP3H", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            MessageBox.Show("Low Visibility Occurrence Risk Index (LVORI) Is derived from the Lavdas ADI and the relative humidity, which gages the probability of visibility restrictions in fog or smoke. There are 10 LVORI categories; ranging from 1" _
            & "(indicating the lowest probability of visibility restrictions) to 10 (indicating the highest probability of visibility restrictions).", "LVORI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            X1.ERRlog("1XI05Q1B", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Dim i1 As Image = My.Resources.CAD1
            If FimgViewer.Visible = False Then
                Dim a As New FimgViewer With {
                    .MdiParent = Form1
                }
                a.Show()
                a.pbox.Image = i1
            End If
        Catch ex As Exception
            X1.ERRlog("1X34I83F", ex.Message) ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try
            Dim i1 As Image = My.Resources.CAD2
            If FimgViewer.Visible = False Then
                Dim a As New FimgViewer With {
                    .MdiParent = Form1
                }
                a.Show()
                a.pbox.Image = i1

            End If
        Catch ex As Exception
            X1.ERRlog("1XGJ6FC3", ex.Message) ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class