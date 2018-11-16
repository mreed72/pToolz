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