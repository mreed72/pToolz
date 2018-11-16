Public Class Form1
    Dim x As New xFuels.ClassFuels

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Smoke Tools - " & x.GetMyKey("REGKEY")
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
End Class
