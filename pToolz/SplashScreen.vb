'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


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
