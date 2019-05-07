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

        Try
            'Archived Folder Size
            Dim bkf As String = "C:\SMTOOLZ\Sessions\"
            tsSesLogSize.Text = "Archived Session Directory Size: " & X1.finSize(X1.GetFolderSize(bkf, True))

            For Each f As String In My.Computer.FileSystem.GetDirectories("C:\SMTOOLZ\Sessions\")
                lbx.Items.Add(f)
            Next


        Catch ex As Exception
            X1.ERRlog("1XWDTCYJ", ex.Message) ' ERROR LOG CODE
        End Try

        myicon.Icon = Icon.ExtractAssociatedIcon("cXY0098.ico")
        myicon.Text = "pToolz" & vbNewLine & "Prescribed Burn Tools!"
        myicon.Visible = True

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()

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

    Private Sub LVORIHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LVORIHelpToolStripMenuItem.Click
        Try
            Dim xv As String = "https://github.com/mreed72/pToolz/wiki"
            Diagnostics.Process.Start(xv)
        Catch ex As Exception
            X1.ERRlog("2XA4V9OH", ex.Message)
        End Try

    End Sub

    Private Sub CLOSEALLTOOLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLOSEALLTOOLSToolStripMenuItem.Click
        For Each Childform In MdiChildren
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

    Public Sub Open_MDI(Of T As {New, Form})(bMultipleInstances As Boolean)
        'USE: Open_MDI(Of FORM)(False)

        If bMultipleInstances = False Then
            For Each f As Form In MdiChildren
                If TypeOf f Is T Then
                    If (f.WindowState = FormWindowState.Minimized) Then
                        f.WindowState = FormWindowState.Maximized
                    End If

                    f.Activate()
                    Exit Sub
                End If
            Next
        End If

        Dim myChild As New T()
        myChild.MdiParent = Me
        myChild.Show()
    End Sub

#Region "MDI CHILD FORM OPEN WITHOUT DUPLICATES"

    Private Sub SmokeCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalculatorToolStripMenuItem.Click, Button2.Click
        Open_MDI(Of Fsmokecalc)(False)
    End Sub

    Private Sub ProbabilityOfIgnitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilityOfIgnitionToolStripMenuItem.Click, Button4.Click
        Open_MDI(Of Fpoi)(False)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Open_MDI(Of Fabout)(False)
    End Sub

    Private Sub LVORIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LVORIToolStripMenuItem.Click, Button5.Click
        Open_MDI(Of Flvori)(False)
    End Sub

    Private Sub SmokeCalcMultiFuelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmokeCalcMultiFuelsToolStripMenuItem.Click, Button3.Click
        Open_MDI(Of FmultiCalc)(False)
    End Sub

    Private Sub DistanceBetween2PointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistanceBetween2PointsToolStripMenuItem.Click, Button6.Click
        Open_MDI(Of FcalDistant)(False)
    End Sub

    Private Sub LogViewerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogViewerToolStripMenuItem1.Click
        Open_MDI(Of Flogs)(False)
    End Sub

    Private Sub ViewSessionsFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSessionsFolderToolStripMenuItem.Click
        Open_MDI(Of FarchiveChoose)(False)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Open_MDI(Of FrmSafeChecklist)(False)
    End Sub

    Private Sub IndustryGuidelinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndustryGuidelinesToolStripMenuItem.Click
        Dim x As String = My.Application.Info.DirectoryPath & "\SMG.pdf"
        Dim a As Boolean
        a = My.Computer.FileSystem.FileExists(x)
        If a = True Then
            Diagnostics.Process.Start(x)
        End If
    End Sub

    Private Sub RowCropGuidelinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowCropGuidelinesToolStripMenuItem.Click
        Dim x As String = My.Application.Info.DirectoryPath & "\RSMG.pdf"
        Dim a As Boolean
        a = My.Computer.FileSystem.FileExists(x)
        If a = True Then
            Diagnostics.Process.Start(x)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Open_MDI(Of Form2)(False)
    End Sub


#End Region


End Class
