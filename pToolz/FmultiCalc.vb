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


    Private Sub FmultiCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load





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

            Dim b As New Label() With {
                .Text = txBlockSize.Text & ", " & txFtype.SelectedItem & ", " & txFload.SelectedItem & ", " & avf & ", " & tfv,
                .Height = 23,
                .Width = 400
                }
            fPan.Controls.Add(b)

            zTotalSize = zTotalSize + Val(txBlockSize.Text)
            zTotalTons = zTotalTons + tfv


            txBlockSize.Clear()
            txFtype.SelectedIndex = -1
            txFload.SelectedIndex = -1
            txBlockSize.Focus()
        Catch ex As Exception

        End Try

        txTotalSize.Text = zTotalSize
        txTotalTons.Text = zTotalTons



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
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEAR
        Try
            txBlockSize.Clear()
            txFtype.SelectedIndex = -1
            txFload.SelectedIndex = -1
            txCatDay.Clear()
            txDistance.Clear()
            fPan.Controls.Clear()
            txTotalSize.Text = 0
            txTotalTons.Text = 0
            txResults.Clear()
            txResults.BackColor = Color.White
            zTotalSize = 0
            zTotalTons = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
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


    End Sub
End Class