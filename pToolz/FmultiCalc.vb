'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================





Public Class FmultiCalc
    Private x As New xFuels.ClassFuels
    Private sADJ As Integer


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


        Dim avf As Double
        avf = x.GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
        Dim tfv As Integer
        tfv = Val(txBlockSize.Text) * Val(avf)

        dgv.Rows.Add(txBlockSize.Text, txFtype.SelectedItem, txFload.SelectedItem, avf, tfv)

        txBlockSize.Clear()
        txFtype.SelectedIndex = -1
        txFload.SelectedIndex = -1
        txBlockSize.Focus()

    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded

        Try
            Dim xA, xB As Integer
            For Each row As DataGridViewRow In dgv.Rows
                xA += row.Cells(0).Value
                xB += row.Cells(4).Value
            Next

            txTotalSize.Text = xA
            txTotalTons.Text = xB
        Catch ex As Exception
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

        sADJ = x.smpCalc(txCatDay.Text, txDistance.Text)
        If txTotalTons.Text > sADJ Then
            txResults.Text = "Your burn WILL exceed the guidelines."
            txResults.BackColor = Color.LightPink
        Else
            txResults.Text = "Your burn WILL NOT exceed the guidelines."
            txResults.BackColor = Color.White
        End If

        txAllowed.Text = sADJ



    End Sub
End Class