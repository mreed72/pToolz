Public NotInheritable Class SplashScreen

    Dim x As New xFuels.ClassFuels

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rk, rTY As String
        rk = x.grs(5) & "-" & x.grs(5)
        Dim gDt As Date

        If x.GetMyKey("REGKEY") = "" Then
            x.SetMyKey("REGKEY", rk)
            x.SetMyKey("REGDATE", Date.Now)
        End If
        gDt = x.GetMyKey("REGDATE")
        rTY = x.GetMyKey("REGKEY")


        Label2.Text = rTY & " - " & gDt

        If x.ChkLocations = True Then
            pb3.Image = My.Resources.weIMAGE124
        Else
            pb3.Image = My.Resources.weIMAGE118
        End If

        If x.GetMyKey("ELOG") = "" Then
            x.SetMyKey("ELOG", "C:\SMTOOLZ\elog.txt")
            x.SetMyKey("SLOG", "C:\SMTOOLZ\slog.txt")
        End If


    End Sub

End Class
