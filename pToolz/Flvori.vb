'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public Class Flvori
    Dim x As New xFuels.ClassFuels

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txResult.Text = x.LVORI_day(txRH.Value, txADI.Value)
        rtb1.Text = cdvalue()

    End Sub

    Function cdvalue()
        'ADI Value
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
        End Select
    End Function

    Private Sub Flvori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtb1.Clear()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Lavdas Atmospheric Dispersion Index (ADI) was designed to estimate the atmosphere.s ability to disperse smoke from a prescribed fire. The ADI forecast is computed from the 20-foot wind speed, mixing height, transport wind, and cloud cover. Values of ADI range from <= 6 indicating very poor dispersion to >=100 indicating very good dispersion", "ADI", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("Low Visibility Occurrence Risk Index (LVORI) is derived from the Lavdas ADI and the relative humidity, which gages the probability of visibility restrictions in fog or smoke. There are 10 LVORI categories; ranging from 1 (indicating the lowest probability of visibility restrictions) to 10 (indicating the highest probability of visibility restrictions).", "LVORI", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim i1 As Image = My.Resources.CAD1
        If FimgViewer.Visible = False Then
            Dim a As New FimgViewer
            a.MdiParent = Form1
            a.Show()
            a.pbox.Image = i1
        End If
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim i1 As Image = My.Resources.CAD2
        If FimgViewer.Visible = False Then
            Dim a As New FimgViewer
            a.MdiParent = Form1
            a.Show()
            a.pbox.Image = i1

        End If
    End Sub
End Class