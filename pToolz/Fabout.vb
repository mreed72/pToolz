'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Imports xFuels

Public Class Fabout
    Private x As New xFuels.ClassFuels

    Public Property X1 As ClassFuels
        Get
            Return x
        End Get
        Set(value As ClassFuels)
            x = value
        End Set
    End Property

    Private Sub Fabout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Label2.Text = CType("RKEY: " & X1.GetMyKey("REGKEY"), String)
            Label3.Text = "RDATE: " & CDate(X1.GetMyKey("REGDATE"))

            Dim DDY As Double
            DDY = DateDiff(DateInterval.Day, X1.GetMyKey("REGDATE"), Date.Now)
            txDayUsing.Text = "You have been using this program for: " & DDY & " days."

        Catch ex As Exception
            X1.ERRlog(ex.Message, "6x92HI9") ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("mailto:mreed1972@gmail.com?subject=SmokeToolsApp")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6xPDEG1") ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("https://www.gnu.org/licenses/gpl.html")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6xXPDOD") ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start("https://github.com/mreed72/pToolz")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6xC1FB4") ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        'ADI Definition Source
        Try
            Process.Start("https://graphical.weather.gov/definitions/defineADI.html")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6x9M9YV") ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'LVORI Definition Source
        Try
            Process.Start("https://graphical.weather.gov/definitions/defineLVORI.html")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6xQ8ADK") ' ERROR LOG CODE
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Try
            Diagnostics.Process.Start("https://www.geodatasource.com/")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6XCV9LQZ")
        End Try
    End Sub
End Class