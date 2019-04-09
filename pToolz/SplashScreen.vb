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

        Dim rk As String
        rk = grs(4) & "-" & grs(4) & "-" & grs(4)


        If GetMyKey(KeyValue) = String.Empty Then
            SetMyKey("REGKEY", rk)
            SetMyKey("REGDATE", Date.Now)
        End If

        Label2.Text = rk



        SetMyKey("ELOG", "C:\SMTOOLZ\elog.txt")






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
                My.Computer.FileSystem.CreateDirectory(DirName & "\Sessions\")
            End If
            Return True
            Exit Function
        Catch ex As Exception
            Return False
        End Try


        Try
            Dim e, a As Boolean
            e = My.Computer.FileSystem.FileExists(DirName & "\elog.txt")

            a = My.Computer.FileSystem.DirectoryExists(DirName & "\Sessions\")

            If e = False Then
                My.Computer.FileSystem.WriteAllText(DirName & "\elog.txt", "", False)
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


End Class
