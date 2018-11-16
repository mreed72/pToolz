'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or (at your option) any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Public Class Form1
    Dim x As New xFuels.ClassFuels

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Smoke Tools - " & x.GetMyKey("REGKEY")
        txLogLocation.Text = x.GetMyKey("SLOG")

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub SmokeCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalculatorToolStripMenuItem.Click
        Dim a As New Fsmokecalc
        a.MdiParent = Me
        a.Show()

    End Sub

    Private Sub LogViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogViewerToolStripMenuItem.Click
        Dim a As New Flogs
        a.MdiParent = Me
        a.Show()

    End Sub

    Private Sub t1_Tick(sender As Object, e As EventArgs) Handles t1.Tick
        tsStat.Text = Date.Now

    End Sub

    Private Sub txLogLocation_DoubleClick(sender As Object, e As EventArgs) Handles txLogLocation.DoubleClick
        Try
            Dim xc As String = txLogLocation.Text
            Diagnostics.Process.Start(xc)
        Catch ex As Exception
        End Try
        txLogLocation.SelectionLength = 0

    End Sub

    Private Sub ProbabilityOfIgnitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilityOfIgnitionToolStripMenuItem.Click
        Dim a As New Fpoi
        a.MdiParent = Me
        a.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim a As New Fabout
        a.MdiParent = Me
        a.Show()

    End Sub

    Private Sub LVORIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LVORIToolStripMenuItem.Click
        Dim a As New Flvori
        a.MdiParent = Me
        a.Show()

    End Sub
End Class
