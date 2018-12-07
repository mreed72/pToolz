'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public NotInheritable Class SplashScreen
    Private Const KeyValue As String = "REGKEY"

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim rk, rTY As String
        rk = grs(5) & "-" & grs(5)
        Dim gDt As Date

        If GetMyKey(KeyValue) = String.Empty Then
            SetMyKey("REGKEY", rk)
            SetMyKey("REGDATE", Date.Now)
            Dim d As String = Dcypt(rk)
            SetMyKey("DECVALUE", d)
        End If
        gDt = GetMyKey("REGDATE")
        rTY = GetMyKey(KeyValue)


        Label2.Text = rTY
        Dim y As String = GetMyKey("DECVALUE")
        Dim r As String = Dcypt(Label2.Text)
        If r = y Then
            Label2.BackColor = Color.LightGreen
        Else
            Label2.BackColor = Color.LightPink
        End If







        If ChkLocations = True Then
            pb3.Image = My.Resources.weIMAGE124
        Else
            pb3.Image = My.Resources.weIMAGE118
            End If


        SetMyKey("ELOG", "C:\SMTOOLZ\elog.txt")
        SetMyKey("SLOG", "C:\SMTOOLZ\slog.txt")
        SetMyKey("SESS", "C:\SMTOOLZ\Sessions\")





        Try
            'Time Check for Archived Session Log Removal
            If GetMyKey("LOGTIME") = "" Then
                SetMyKey("LOGTIME", Date.Now.Month)
            End If

            If My.Settings.cbDelLogs30Days = True Then
                If GetMyKey("LOGTIME") = Date.Now.Month Then
                    Exit Sub
                Else
                    My.Computer.FileSystem.DeleteDirectory("C:\SMTOOLZ\Sessions\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    Threading.Thread.Sleep(1000)
                    My.Computer.FileSystem.CreateDirectory("C:\SMTOOLZ\Sessions\")
                    SetMyKey("LOGTIME", Date.Now.Month)
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try

    End Sub


    Public Function grs(ByRef length As Integer) As String
        Randomize()
        Dim ac As String
        ac = "123456789"
        Dim i As Integer
        For i = 1 To length
            grs = grs & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
        Next

    End Function


    Public Function SetMyKey(keySub As String, keyValue As String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SMTOOLZ\", keySub, keyValue)
    End Function

    Public Function GetMyKey(keyValue As String)
        Dim readValue As String
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SMTOOLZ\", keyValue, Nothing)
        Return readValue

    End Function

    Public Function ChkLocations() As Boolean
        Dim DirName As String
        DirName = "C:\SMTOOLZ\"

        Try
            Dim f As Boolean
            f = My.Computer.FileSystem.DirectoryExists(DirName)
            If f = False Then
                My.Computer.FileSystem.CreateDirectory(DirName)
                My.Computer.FileSystem.WriteAllText(DirName & "\elog.txt", "", False)
                My.Computer.FileSystem.WriteAllText(DirName & "\slog.txt", "", False)
                My.Computer.FileSystem.CreateDirectory(DirName & "\Sessions\")
            End If
            Return True
            Exit Function
        Catch ex As Exception
            Return False
        End Try


        Try
            Dim e, s, a As Boolean
            e = My.Computer.FileSystem.FileExists(DirName & "\elog.txt")
            s = My.Computer.FileSystem.FileExists(DirName & "\slog.txt")
            a = My.Computer.FileSystem.DirectoryExists(DirName & "\Sessions\")

            If e = False Then
                My.Computer.FileSystem.WriteAllText(DirName & "\elog.txt", "", False)
            End If
            If s = False Then
                My.Computer.FileSystem.WriteAllText(DirName & "\slog.txt", "", False)
            End If
            If a = False Then
                My.Computer.FileSystem.CreateDirectory(DirName & "\Sessions\")
            End If
            Return True
            Exit Function
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function Dcypt(r As String)
        Dim tot() As String = r.Split("-"c)
        Dim total As Integer
        For Each t As Integer In tot
            total += CType(t, Integer)
        Next
        Return total
    End Function

End Class
