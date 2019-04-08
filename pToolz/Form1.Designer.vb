<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistanceBetween2PointsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SmokeCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmokeCalcMultiFuelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbabilityOfIgnitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVORIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogViewerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOSEALLTOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVORIHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsSesLogSize = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.xAFDSZ = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbDelLogs30Days = New System.Windows.Forms.CheckBox()
        Me.cbSesLog = New System.Windows.Forms.CheckBox()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.TOOLSToolStripMenuItem, Me.ToolStripMenuItem3, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1062, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.ToolStripMenuItem1.Text = "FILE"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x320040
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DistanceBetween2PointsToolStripMenuItem, Me.ToolStripSeparator3, Me.SmokeCalculatorToolStripMenuItem, Me.SmokeCalcMultiFuelsToolStripMenuItem, Me.ProbabilityOfIgnitionToolStripMenuItem, Me.LVORIToolStripMenuItem, Me.ToolStripSeparator4, Me.LogViewerToolStripMenuItem1, Me.CLOSEALLTOOLSToolStripMenuItem})
        Me.TOOLSToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.weIMAGE061
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.TOOLSToolStripMenuItem.Text = "TOOLS"
        '
        'DistanceBetween2PointsToolStripMenuItem
        '
        Me.DistanceBetween2PointsToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.target163
        Me.DistanceBetween2PointsToolStripMenuItem.Name = "DistanceBetween2PointsToolStripMenuItem"
        Me.DistanceBetween2PointsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DistanceBetween2PointsToolStripMenuItem.Text = "Distance between 2 points"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'SmokeCalculatorToolStripMenuItem
        '
        Me.SmokeCalculatorToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.weIMAGE079
        Me.SmokeCalculatorToolStripMenuItem.Name = "SmokeCalculatorToolStripMenuItem"
        Me.SmokeCalculatorToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SmokeCalculatorToolStripMenuItem.Text = "Smoke Calculator"
        '
        'SmokeCalcMultiFuelsToolStripMenuItem
        '
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x321021
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Name = "SmokeCalcMultiFuelsToolStripMenuItem"
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Text = "Smoke Calc Multi-Fuels"
        '
        'ProbabilityOfIgnitionToolStripMenuItem
        '
        Me.ProbabilityOfIgnitionToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x321355
        Me.ProbabilityOfIgnitionToolStripMenuItem.Name = "ProbabilityOfIgnitionToolStripMenuItem"
        Me.ProbabilityOfIgnitionToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ProbabilityOfIgnitionToolStripMenuItem.Text = "Probability of Ignition"
        '
        'LVORIToolStripMenuItem
        '
        Me.LVORIToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x320005
        Me.LVORIToolStripMenuItem.Name = "LVORIToolStripMenuItem"
        Me.LVORIToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.LVORIToolStripMenuItem.Text = "LVORI "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(209, 6)
        '
        'LogViewerToolStripMenuItem1
        '
        Me.LogViewerToolStripMenuItem1.Image = Global.pToolz.My.Resources.Resources.x320062
        Me.LogViewerToolStripMenuItem1.Name = "LogViewerToolStripMenuItem1"
        Me.LogViewerToolStripMenuItem1.Size = New System.Drawing.Size(212, 22)
        Me.LogViewerToolStripMenuItem1.Text = "Log Viewer"
        '
        'CLOSEALLTOOLSToolStripMenuItem
        '
        Me.CLOSEALLTOOLSToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.weIMAGE091
        Me.CLOSEALLTOOLSToolStripMenuItem.Name = "CLOSEALLTOOLSToolStripMenuItem"
        Me.CLOSEALLTOOLSToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.CLOSEALLTOOLSToolStripMenuItem.Text = "CLOSE ALL TOOLS"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem3.Text = "|"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LVORIHelpToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'LVORIHelpToolStripMenuItem
        '
        Me.LVORIHelpToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.weIMAGE080
        Me.LVORIHelpToolStripMenuItem.Name = "LVORIHelpToolStripMenuItem"
        Me.LVORIHelpToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LVORIHelpToolStripMenuItem.Text = "Help (Online Wiki)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.weIMAGE087
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStat, Me.ToolStripStatusLabel1, Me.tsSesLogSize})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 686)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1062, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStat
        '
        Me.tsStat.ForeColor = System.Drawing.Color.Blue
        Me.tsStat.Name = "tsStat"
        Me.tsStat.Size = New System.Drawing.Size(31, 17)
        Me.tsStat.Text = "time"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'tsSesLogSize
        '
        Me.tsSesLogSize.Name = "tsSesLogSize"
        Me.tsSesLogSize.Size = New System.Drawing.Size(120, 17)
        Me.tsSesLogSize.Text = "ToolStripStatusLabel2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 47)
        Me.Panel1.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Image = Global.pToolz.My.Resources.Resources.x320040
        Me.btnExit.Location = New System.Drawing.Point(1011, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(44, 36)
        Me.btnExit.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnExit, "Distance between 2 points")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Image = Global.pToolz.My.Resources.Resources.target163
        Me.Button6.Location = New System.Drawing.Point(874, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(44, 36)
        Me.Button6.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button6, "Distance between 2 points")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.pToolz.My.Resources.Resources.x320005
        Me.Button5.Location = New System.Drawing.Point(824, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 36)
        Me.Button5.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button5, "LVORI Calculator")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.pToolz.My.Resources.Resources.x321355
        Me.Button4.Location = New System.Drawing.Point(774, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 36)
        Me.Button4.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button4, "Probability of Ignition")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.pToolz.My.Resources.Resources.x321021
        Me.Button3.Location = New System.Drawing.Point(724, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 36)
        Me.Button3.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button3, "Multi-Fuels Calculator")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.pToolz.My.Resources.Resources.weIMAGE079
        Me.Button2.Location = New System.Drawing.Point(674, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 36)
        Me.Button2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button2, "Single Fuels Calculator")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.xAFDSZ)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(258, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 36)
        Me.Panel3.TabIndex = 1
        '
        'xAFDSZ
        '
        Me.xAFDSZ.AutoSize = True
        Me.xAFDSZ.Location = New System.Drawing.Point(150, 9)
        Me.xAFDSZ.Name = "xAFDSZ"
        Me.xAFDSZ.Size = New System.Drawing.Size(39, 13)
        Me.xAFDSZ.TabIndex = 7
        Me.xAFDSZ.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "View Archived Sessions"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.cbSesLog)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 36)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.cbDelLogs30Days)
        Me.Panel4.Location = New System.Drawing.Point(98, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(144, 26)
        Me.Panel4.TabIndex = 1
        '
        'cbDelLogs30Days
        '
        Me.cbDelLogs30Days.AutoSize = True
        Me.cbDelLogs30Days.Checked = Global.pToolz.My.MySettings.Default.cbDelLogs30Days
        Me.cbDelLogs30Days.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDelLogs30Days.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.pToolz.My.MySettings.Default, "cbDelLogs30Days", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbDelLogs30Days.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDelLogs30Days.Location = New System.Drawing.Point(3, 2)
        Me.cbDelLogs30Days.Name = "cbDelLogs30Days"
        Me.cbDelLogs30Days.Size = New System.Drawing.Size(125, 16)
        Me.cbDelLogs30Days.TabIndex = 0
        Me.cbDelLogs30Days.Text = "Delete logs after 30 days"
        Me.cbDelLogs30Days.UseVisualStyleBackColor = True
        '
        'cbSesLog
        '
        Me.cbSesLog.AutoSize = True
        Me.cbSesLog.Checked = Global.pToolz.My.MySettings.Default.cbLogSession
        Me.cbSesLog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.pToolz.My.MySettings.Default, "cbLogSession", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSesLog.Location = New System.Drawing.Point(3, 8)
        Me.cbSesLog.Name = "cbSesLog"
        Me.cbSesLog.Size = New System.Drawing.Size(89, 17)
        Me.cbSesLog.TabIndex = 0
        Me.cbSesLog.Text = "Log Sessions"
        Me.cbSesLog.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pToolz.My.Resources.Resources.psdImages111
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1062, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Fire Tools v1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TOOLSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmokeCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmokeCalcMultiFuelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProbabilityOfIgnitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LVORIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbSesLog As CheckBox
    Friend WithEvents tsStat As ToolStripStatusLabel
    Friend WithEvents T1 As Timer
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LVORIHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsSesLogSize As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents xAFDSZ As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbDelLogs30Days As CheckBox
    Friend WithEvents DistanceBetween2PointsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents LogViewerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CLOSEALLTOOLSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnExit As Button
End Class
