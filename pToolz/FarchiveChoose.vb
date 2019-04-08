'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================




Public Class FarchiveChoose
    Private Sub FarchiveChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each f As String In My.Computer.FileSystem.GetFiles("C:\SMTOOLZ\Sessions\")
            bx1.Items.Add(f)
        Next
    End Sub


    Private Sub bx1_DoubleClick(sender As Object, e As EventArgs) Handles bx1.DoubleClick
        Try
            Dim x As String = bx1.SelectedItem.ToString
            Diagnostics.Process.Start(x)
        Catch ex As Exception
        End Try
    End Sub
End Class