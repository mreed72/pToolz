Public Class Flogs
    Dim x As New xFuels.ClassFuels
    Private eg As String = x.GetMyKey("ELOG")
    Private sg As String = x.GetMyKey("SLOG")



    Private Sub Flogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkSets()





    End Sub

    Public Function ChkSets()
        If My.Settings.cbLogSession = True Then
            lgbtn.Image = My.Resources.weIMAGE124
            lgbtn.Text = "Enabled!"
        Else
            lgbtn.Image = My.Resources.weIMAGE118
            lgbtn.Text = "Disabled!"
        End If

        If My.Settings.ExLogAppend = True Then
            exlg.Text = "T"
            exlg.BackColor = Color.FromArgb(104, 244, 136)
        Else
            exlg.Text = "F"
            exlg.BackColor = Color.FromArgb(249, 170, 166)
        End If
    End Function
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            'Session Log
            Dim f As Boolean
            f = My.Computer.FileSystem.FileExists(sg)
            If f = True Then
                Dim srg As String = My.Computer.FileSystem.ReadAllText(sg)
                rtb.Text = srg
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            'Error Log
            Dim f As Boolean
            f = My.Computer.FileSystem.FileExists(eg)
            If f = True Then
                Dim srg As String = My.Computer.FileSystem.ReadAllText(eg)
                rtb.Text = srg
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'Export RTB to RTF
        If rtb.Text = "" Then
            Exit Sub
        End If
        Dim dd As Boolean = My.Settings.ExLogAppend

        Dim sd As New SaveFileDialog
        sd.DefaultExt = "doc"
        sd.Filter = "Microsoft Word Document (.doc)|*.doc"
        If sd.ShowDialog() = DialogResult.OK Then
            Try
                Dim svLocation As String = sd.FileName
                Dim sw As New System.IO.StreamWriter(svLocation, dd)
                sw.Write(rtb.Rtf)
                sw.Flush()
                sw.Close()
                txSTA.Text = svLocation
            Catch ex As Exception
                txSTA.Text = "error..."
            End Try
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        'Clear Logs
        Try
            Dim f1 As Boolean
            f1 = My.Computer.FileSystem.FileExists(sg)
            If f1 = True Then
                My.Computer.FileSystem.DeleteFile(sg)
                My.Computer.FileSystem.WriteAllText(sg, "", False)
            End If
            MessageBox.Show("Session Log Cleared!", "Session Log", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txSTA_DoubleClick(sender As Object, e As EventArgs) Handles txSTA.DoubleClick
        Try
            If txSTA.Text = "" Then
                Exit Sub
            End If
            Dim xv As String = txSTA.Text
            Diagnostics.Process.Start(xv)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub exlg_Click(sender As Object, e As EventArgs) Handles exlg.Click
        If MessageBox.Show("Would you like to APPEND (yes) the text to the log or OVERWRITE (no)?", "Append Text", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            My.Settings.ExLogAppend = True
        Else
            My.Settings.ExLogAppend = False
        End If
        My.Settings.Save()
        ChkSets()

    End Sub
End Class