'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public Class Fpoi

    Dim x As New xFuels.ClassFuels

    Private Sub Fpoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As Boolean = My.Settings.cbLogSession
        If t = True Then
            pb.Image = My.Resources.weIMAGE124
            bLog.Text = "Logging Enabled!"
        Else
            pb.Image = My.Resources.weIMAGE118
            bLog.Text = "Logging Disabled!"
        End If

        txShading.Maximum = 100
        txDryBulb.Maximum = 125
        txFDFM.Maximum = 17






    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim a1, a2, a3, a4 As Integer
        a1 = txShading.Value
        a2 = txDryBulb.Value
        a3 = txFDFM.Value
        a4 = x.ProIgnCalc(a1, a2, a3)

        txResult.Text = a4 & "%"
        If My.Settings.cbLogSession = True Then
            'LOG
            x.SESLog("Probability of Ignition", "Shading: " & a1 & vbCrLf & "Dry Bulb Temp: " & a2 & vbCrLf & "Fuel Moisture: " & a3 & vbCrLf & "Result: " & a4 & "%")
        Else
            Exit Sub
        End If
    End Sub
End Class