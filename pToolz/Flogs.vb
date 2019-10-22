'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================

'TODO: probably need to delete this as it's no longer needed as well

Imports xFuels

Public Class Flogs
    Private x As New ClassFuels
    Private eg As String = X1.GetMyKey("ELOG")
    Private sg As String = X1.GetMyKey("SLOG")

    Public Property X1 As ClassFuels
        Get
            Return x
        End Get
        Set(value As ClassFuels)
            x = value
        End Set
    End Property

    Private Sub Flogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkSets()
    End Sub

    Public Function ChkSets()
        Try
            If My.Settings.cbLogSession = True Then
                lgbtn.Image = My.Resources.weIMAGE124
                lgbtn.Text = "Enabled!"
            Else
                lgbtn.Image = My.Resources.weIMAGE118
                lgbtn.Text = "Disabled!"
            End If
        Catch ex As Exception
            X1.ERRlog("1XF4JXYO", ex.Message) ' ERROR LOG CODE
        End Try

        Try
            If My.Settings.ExLogAppend = True Then
                exlg.Text = "T"
                exlg.BackColor = Color.FromArgb(104, 244, 136)
            Else
                exlg.Text = "F"
                exlg.BackColor = Color.FromArgb(249, 170, 166)
            End If
        Catch ex As Exception
            X1.ERRlog("1X46E3JL", ex.Message)
        End Try


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
            X1.ERRlog("1XDBU3ZR", ex.Message) ' ERROR LOG CODE
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
            X1.ERRlog("1X1XHJZP", ex.Message) ' ERROR LOG CODE
        End Try

        If rtb.Text > String.Empty Then
            txSTA.Text = "Copy and Send error message to:  mreed1972@gmail.com"
        End If




    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'Export RTB to RTF
        If rtb.Text = "" Then
            txSTA.Text = "NO TEXT TO EXPORT!!!"
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
                X1.ERRlog("1XHFK6HM", ex.Message) ' ERROR LOG CODE
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
            X1.ERRlog("1XFI44GF", ex.Message) ' ERROR LOG CODE
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
            X1.ERRlog("1XIS2S5U", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub exlg_Click(sender As Object, e As EventArgs) Handles exlg.Click
        Try
            If MessageBox.Show("Would you like to APPEND (yes) the text to the log or OVERWRITE (no)?", "Append Text", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                My.Settings.ExLogAppend = True
            Else
                My.Settings.ExLogAppend = False
            End If
            My.Settings.Save()
            ChkSets()
        Catch ex As Exception
            X1.ERRlog("1XSPITDB", ex.Message) ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub COPYALLTEXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYALLTEXTToolStripMenuItem.Click
        Clipboard.Clear()
        rtb.SelectAll()
        Clipboard.SetText(rtb.Text)


    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Close()

    End Sub
End Class