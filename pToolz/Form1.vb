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
        Dim k As String = My.Application.Info.Version.ToString
        Text = "pToolz - " & k
        lbPrevSesId.Text = My.Settings.PreviousSessionID
        If My.Settings.CurrentSessionID = 0 Then
            Label4.Text = "NO CURRENT SESSION, click the button to create a session"
        Else
            Label4.Text = "CURRENT SESSION: " & My.Settings.CurrentSessionID
        End If

        'Try
        '    'Archived Folder Size
        '    Dim bkf As String = "C:\SMTOOLZ\Sessions\"
        '    xAFDSZ.Text = "Archived Session Directory Size: " & X1.finSize(X1.GetFolderSize(bkf, True))
        'Catch ex As Exception
        '    X1.ERRlog("1XWDTCYJ", ex.Message) ' ERROR LOG CODE
        'End Try


        'Try
        '    SesLogSize = My.Computer.FileSystem.GetFileInfo("C:\SMTOOLZ\slog.txt").Length
        '    My.Settings.SessionLogFileSize = SesLogSize
        '    My.Settings.Save()

        '    tsSesLogSize.Text = "SLFS: " & SesLogSize
        'Catch ex As Exception
        '    X1.ERRlog("1XTFXBKW", ex.Message) ' ERROR LOG CODE
        'End Try

        myicon.Icon = Icon.ExtractAssociatedIcon("cXY0098.ico")
        myicon.Text = "pToolz" & vbNewLine & "Prescribed Burn Tools!"
        myicon.Visible = True

    End Sub



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
        If My.Settings.CurrentSessionID = 0 Then
            Exit Sub
        Else
            My.Settings.PreviousSessionID = My.Settings.CurrentSessionID
            My.Settings.CurrentSessionID = 0
            My.Settings.Save()
        End If


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
        If MessageBox.Show("You will close your current session and you will have to create a new session, is this okay?", "CLOSE SESSION", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If





    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Threading.Thread.Sleep(1000)
        ProgressBar1.PerformStep()

        Threading.Thread.Sleep(1000)
        ProgressBar1.PerformStep()


        Threading.Thread.Sleep(1000)
        ProgressBar1.PerformStep()


        Threading.Thread.Sleep(1000)
        ProgressBar1.PerformStep()


        ProgressBar1.PerformStep()
        Label1.Text = "Session Created"

        CreateNewSession()


    End Sub

    Function CreateNewSession()
        Dim SesID As Integer
        SesID = X1.grs(6)
        My.Settings.CurrentSessionID = SesID
        My.Settings.Save()
        csSesID.Text = SesID
        Label4.Text = SesID

        My.Computer.FileSystem.CreateDirectory("C:\SMTOOLZ\Sessions\" & SesID & "\")
        My.Computer.FileSystem.WriteAllText("C:\SMTOOLZ\Sessions\" & SesID & "\sessionlog.txt", "", False)

        X1.SetMyKey("CurSes", "C:\SMTOOLZ\Sessions\" & SesID & "\sessionlog.txt")




    End Function

    Private Sub ViewSessionsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSessionsFolderToolStripMenuItem.Click
        Dim a As New FarchiveChoose With {
             .MdiParent = Me
             }
        a.Show()
    End Sub
End Class
