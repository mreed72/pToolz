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
    Public WithEvents myicon As New NotifyIcon

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim k As String = X1.GetMyKey("REGKEY")
        Dim t As String = X1.GetMyKey("DECVALUE")
        Dim total As String
        total = Dcypt(k)
        If t = total Then
            Me.Icon = My.Resources.x5120076_raM_icon
        Else
            Me.Icon = My.Resources.x5120076b_lLl_icon

        End If

        Text = "Smoke Tools - " & k
        Try
            'Archived Folder Size
            Dim bkf As String = "C:\SMTOOLZ\Sessions\"
            xAFDSZ.Text = "Archived Session Directory Size: " & X1.finSize(X1.GetFolderSize(bkf, True))
        Catch ex As Exception
            X1.ERRlog("1XWDTCYJ", ex.Message) ' ERROR LOG CODE
        End Try


        Try
            SesLogSize = My.Computer.FileSystem.GetFileInfo("C:\SMTOOLZ\slog.txt").Length
            My.Settings.SessionLogFileSize = SesLogSize
            My.Settings.Save()

            tsSesLogSize.Text = "SLFS: " & SesLogSize
        Catch ex As Exception
            X1.ERRlog("1XTFXBKW", ex.Message) ' ERROR LOG CODE
        End Try

        myicon.Icon = Icon.ExtractAssociatedIcon("cXY0098.ico")
        myicon.Text = "pToolz" & vbNewLine & "Prescribed Burn Tools!"
        myicon.Visible = True

    End Sub


    Public Function Dcypt(r As String)
        Dim tot() As String = r.Split("-"c)
        Dim total As Integer
        For Each t As Integer In tot
            total += CType(t, Integer)
        Next
        Return total
    End Function


    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub SmokeCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalculatorToolStripMenuItem.Click, Button2.Click
        Dim a As New Form
        a = Fsmokecalc
        If a.Visible = True Then
            a.TopMost = True
            a.Focus()
            Exit Sub
        Else
            a.MdiParent = Me
            a.Show()
        End If


    End Sub

    Private Sub ProbabilityOfIgnitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilityOfIgnitionToolStripMenuItem.Click, Button4.Click
        Dim a As New Form
        a = Fpoi
        If a.Visible = True Then
            a.TopMost = True
            a.Focus()
            Exit Sub
        Else
            a.MdiParent = Me
            a.Show()
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim a As New Fabout With {
            .MdiParent = Me
        }
        a.Show()

    End Sub

    Private Sub LVORIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LVORIToolStripMenuItem.Click, Button5.Click
        Dim a As New Form
        a = Flvori
        If a.Visible = True Then
            a.TopMost = True
            a.Focus()
            Exit Sub
        Else
            a.MdiParent = Me
            a.Show()
        End If

    End Sub

    Private Sub SmokeCalcMultiFuelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalcMultiFuelsToolStripMenuItem.Click, Button3.Click
        Dim a As New Form
        a = FmultiCalc
        If a.Visible = True Then
            a.TopMost = True
            a.Focus()
            Exit Sub
        Else
            a.MdiParent = Me
            a.Show()
        End If

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
                    X1.ERRlog("1XHEBZJ3", ex.Message) ' ERROR LOG CODE
                End Try
            Else
                Exit Sub
            End If

            Try
                My.Computer.FileSystem.DeleteFile("C:\SMTOOLZ\slog.txt")
                My.Computer.FileSystem.WriteAllText("C:\SMTOOLZ\slog.txt", "", False)
            Catch ex As Exception
                X1.ERRlog("1X9EOP7H", ex.Message) ' ERROR LOG CODE
            End Try
        Else
            Exit Sub
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New FarchiveChoose With {
            .MdiParent = Me
            }
        a.Show()

    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        tsStat.Text = Date.Now

    End Sub

    Private Sub DistanceBetween2PointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistanceBetween2PointsToolStripMenuItem.Click, Button6.Click
        Dim a As New Form
        a = FcalDistant
        If a.Visible = True Then
            a.TopMost = True
            a.Focus()
            Exit Sub
        Else
            a.MdiParent = Me
            a.Show()
        End If
    End Sub

    Private Sub LogViewerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogViewerToolStripMenuItem1.Click
        Dim a As New Flogs With {
          .MdiParent = Me
      }
        a.Show()
    End Sub

    Private Sub LVORIHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LVORIHelpToolStripMenuItem.Click
        Try
            Dim xv As String = "https://github.com/mreed72/pToolz/wiki"
            Diagnostics.Process.Start(xv)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CLOSEALLTOOLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEALLTOOLSToolStripMenuItem.Click
        For Each Childform In Me.MdiChildren
            Childform.Close()

        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub


End Class
