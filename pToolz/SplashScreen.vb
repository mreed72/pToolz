'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Imports xFuels

Public NotInheritable Class SplashScreen
    Private x As New xFuels.ClassFuels

    Public Property X1 As ClassFuels
        Get
            Return x
        End Get
        Set(value As ClassFuels)
            x = value
        End Set
    End Property

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rk, rTY As String
        rk = X1.grs(5) & "-" & X1.grs(5)
        Dim gDt As Date

        If X1.GetMyKey("REGKEY") = "" Then
            X1.SetMyKey("REGKEY", rk)
            X1.SetMyKey("REGDATE", Date.Now)
        End If
        gDt = X1.GetMyKey("REGDATE")
        rTY = X1.GetMyKey("REGKEY")


        Label2.Text = rTY & " - " & gDt

        If X1.ChkLocations = True Then
            pb3.Image = My.Resources.weIMAGE124
        Else
            pb3.Image = My.Resources.weIMAGE118
        End If

        If X1.GetMyKey("ELOG") = "" Then
            X1.SetMyKey("ELOG", "C:\SMTOOLZ\elog.txt")
            X1.SetMyKey("SLOG", "C:\SMTOOLZ\slog.txt")
            X1.SetMyKey("SESS", "C:\SMTOOLZ\Sessions\")
        End If



        'Time Check for Archived Session Log Removal
        If X1.GetMyKey("LOGTIME") = "" Then
            X1.SetMyKey("LOGTIME", Date.Now.Month)
        End If

        If X1.GetMyKey("LOGTIME") = Date.Now.Month Then
            Exit Sub
        Else
            My.Computer.FileSystem.DeleteDirectory("C:\SMTOOLZ\Sessions\", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CreateDirectory("C:\SMTOOLZ\Sessions\")
            X1.SetMyKey("LOGTIME", Date.Now.Month)
        End If







    End Sub

End Class
