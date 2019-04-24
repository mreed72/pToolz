'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================




Public Class FarchiveChoose
    Dim x1 As New xFuels.ClassFuels

    Private Sub FarchiveChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each f As String In My.Computer.FileSystem.GetDirectories("C:\SMTOOLZ\Sessions\")
                bx1.Items.Add(f)
            Next
        Catch ex As Exception
            x1.ERRlog("2X9C2MFE", ex.Message)
        End Try
    End Sub


    Private Sub bx1_DoubleClick(sender As Object, e As EventArgs) Handles bx1.DoubleClick
        Try
            Dim x As String = bx1.SelectedItem.ToString
            Diagnostics.Process.Start(x)
        Catch ex As Exception
            x1.ERRlog("2XP263UL", ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Try
            If MessageBox.Show("This will delete all the files associated with this section, are you sure you wish to continue?", "Delete Session", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                My.Computer.FileSystem.DeleteDirectory(Label2.Text, FileIO.DeleteDirectoryOption.DeleteAllContents)

                MsgBox("Session Deleted Successfully!")
                Me.Close()

            End If
        Catch ex As Exception
            x1.ERRlog("2XHY56ZS", ex.Message)
        End Try

    End Sub

    Private Sub bx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bx1.SelectedIndexChanged
        Try
            Dim x As String = bx1.SelectedItem.ToString
            Label2.Text = x & "\"
        Catch ex As Exception
            x1.ERRlog("2X258UHN", ex.Message)
        End Try
    End Sub
End Class