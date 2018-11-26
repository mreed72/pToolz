'==============================================================================
'Smoke Tools - Assisting burn managers with Smoke Management. ©2018 Scott Reed
'This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or any later version. This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.
'You should have received a copy of the GNU General Public License along with this program.  If not, see <https://www.gnu.org/licenses/>
'==============================================================================


Imports xFuels

Public Class Form1

    Public Property X1 As New xFuels.ClassFuels
    Dim SesLogSize As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Smoke Tools - " & X1.GetMyKey("REGKEY")

        Try
            'Archived Folder Size
            Dim bkf As String = "C:\SMTOOLZ\Sessions\"
            xAFDSZ.Text = "Archived Session Directory Size: " & X1.finSize(X1.GetFolderSize(bkf, True))
        Catch ex As Exception
            X1.ERRlog(ex.Message, "8xXC3DL") ' ERROR LOG CODE
        End Try


        Try
            SesLogSize = My.Computer.FileSystem.GetFileInfo("C:\SMTOOLZ\slog.txt").Length
            My.Settings.SessionLogFileSize = SesLogSize
            My.Settings.Save()

            tsSesLogSize.Text = "SLFS: " & SesLogSize
        Catch ex As Exception
            X1.ERRlog(ex.Message, "8xN711H") ' ERROR LOG CODE
        End Try


    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub SmokeCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalculatorToolStripMenuItem.Click
        Dim a As New Fsmokecalc With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub LogViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogViewerToolStripMenuItem.Click
        Dim a As New Flogs With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub ProbabilityOfIgnitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilityOfIgnitionToolStripMenuItem.Click
        Dim a As New Fpoi With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim a As New Fabout With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub LVORIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LVORIToolStripMenuItem.Click
        Dim a As New Flvori With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub SmokeCalcMultiFuelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalcMultiFuelsToolStripMenuItem.Click
        Dim a As New FmultiCalc With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim ss As Integer
        ss = My.Computer.FileSystem.GetFileInfo("C:\SMTOOLZ\slog.txt").Length

        If ss > My.Settings.SessionLogFileSize Then
            If My.Settings.cbLogSession = True Then
                Try
                    Dim FileName As String
                    FileName = "SessionLog_" & Date.Now.Month & "_" & Date.Now.Day & "_" & Date.Now.Year & "_" & CInt(X1.CTFD) & ".txt"
                    My.Computer.FileSystem.CopyFile("C:\SMTOOLZ\slog.txt", "C:\SMTOOLZ\Sessions\" & FileName)
                Catch ex As Exception
                    X1.ERRlog(ex.Message, "6xRSQ8E") ' ERROR LOG CODE
                End Try
            Else
                Exit Sub
            End If

            Try
                My.Computer.FileSystem.DeleteFile("C:\SMTOOLZ\slog.txt")
                My.Computer.FileSystem.WriteAllText("C:\SMTOOLZ\slog.txt", "", False)
            Catch ex As Exception
                X1.ERRlog(ex.Message, "8xU8VLJ") ' ERROR LOG CODE
            End Try
        Else
            Exit Sub
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start("C:\SMTOOLZ\Sessions\")
        Catch ex As Exception
            X1.ERRlog(ex.Message, "6xB1JF2") ' ERROR LOG CODE
        End Try

    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        tsStat.Text = Date.Now

    End Sub






End Class
