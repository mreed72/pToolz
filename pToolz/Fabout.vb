'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public Class Fabout
    Dim x As New xFuels.ClassFuels

    Private Sub Fabout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rky As String = x.GetMyKey("REGKEY")
            Dim dt As Date = x.GetMyKey("REGDATE")

            Label2.Text = "RKEY: " & rky
            Label3.Text = "RDATE: " & dt
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim uri As String = "mailto:mreed1972@gmail.com?subject=SmokeToolsApp"
            Diagnostics.Process.Start(uri)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim x As String = "https://www.gnu.org/licenses/gpl.html"
            Diagnostics.Process.Start(x)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim x As String = "https://github.com/mreed72/pToolz"
        Diagnostics.Process.Start(x)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        'ADI Definition Source
        Dim x As String = "https://graphical.weather.gov/definitions/defineADI.html"
        Diagnostics.Process.Start(x)

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'LVORI Definition Source
        Dim x As String = "https://graphical.weather.gov/definitions/defineLVORI.html"
        Diagnostics.Process.Start(x)
    End Sub
End Class