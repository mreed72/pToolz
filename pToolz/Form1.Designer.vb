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
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txLogLocation = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbSesLog = New System.Windows.Forms.CheckBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmokeCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmokeCalcMultiFuelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbabilityOfIgnitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVORIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.TOOLSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 29)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmokeCalculatorToolStripMenuItem, Me.SmokeCalcMultiFuelsToolStripMenuItem, Me.ProbabilityOfIgnitionToolStripMenuItem, Me.LVORIToolStripMenuItem})
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.TOOLSToolStripMenuItem.Text = "TOOLS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 686)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(935, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStat
        '
        Me.tsStat.Name = "tsStat"
        Me.tsStat.Size = New System.Drawing.Size(120, 17)
        Me.tsStat.Text = "ToolStripStatusLabel1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 47)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txLogLocation)
        Me.Panel2.Controls.Add(Me.cbSesLog)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 36)
        Me.Panel2.TabIndex = 0
        '
        'txLogLocation
        '
        Me.txLogLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txLogLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txLogLocation.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txLogLocation.Location = New System.Drawing.Point(93, 5)
        Me.txLogLocation.Name = "txLogLocation"
        Me.txLogLocation.Size = New System.Drawing.Size(164, 15)
        Me.txLogLocation.TabIndex = 1
        '
        't1
        '
        Me.t1.Enabled = True
        '
        'cbSesLog
        '
        Me.cbSesLog.AutoSize = True
        Me.cbSesLog.Checked = Global.pToolz.My.MySettings.Default.cbLogSession
        Me.cbSesLog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.pToolz.My.MySettings.Default, "cbLogSession", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSesLog.Location = New System.Drawing.Point(3, 8)
        Me.cbSesLog.Name = "cbSesLog"
        Me.cbSesLog.Size = New System.Drawing.Size(84, 17)
        Me.cbSesLog.TabIndex = 0
        Me.cbSesLog.Text = "Log Session"
        Me.cbSesLog.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogViewerToolStripMenuItem, Me.ToolStripSeparator1, Me.EXITToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.pToolz.My.Resources.Resources.x320042
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(65, 29)
        Me.ToolStripMenuItem1.Text = "FILE"
        '
        'LogViewerToolStripMenuItem
        '
        Me.LogViewerToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x320303
        Me.LogViewerToolStripMenuItem.Name = "LogViewerToolStripMenuItem"
        Me.LogViewerToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LogViewerToolStripMenuItem.Text = "Log Viewer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(129, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x320040
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'SmokeCalculatorToolStripMenuItem
        '
        Me.SmokeCalculatorToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.weIMAGE079
        Me.SmokeCalculatorToolStripMenuItem.Name = "SmokeCalculatorToolStripMenuItem"
        Me.SmokeCalculatorToolStripMenuItem.Size = New System.Drawing.Size(208, 32)
        Me.SmokeCalculatorToolStripMenuItem.Text = "Smoke Calculator"
        '
        'SmokeCalcMultiFuelsToolStripMenuItem
        '
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x321021
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Name = "SmokeCalcMultiFuelsToolStripMenuItem"
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Size = New System.Drawing.Size(208, 32)
        Me.SmokeCalcMultiFuelsToolStripMenuItem.Text = "Smoke Calc Multi-Fuels"
        '
        'ProbabilityOfIgnitionToolStripMenuItem
        '
        Me.ProbabilityOfIgnitionToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x321355
        Me.ProbabilityOfIgnitionToolStripMenuItem.Name = "ProbabilityOfIgnitionToolStripMenuItem"
        Me.ProbabilityOfIgnitionToolStripMenuItem.Size = New System.Drawing.Size(208, 32)
        Me.ProbabilityOfIgnitionToolStripMenuItem.Text = "Probability of Ignition"
        '
        'LVORIToolStripMenuItem
        '
        Me.LVORIToolStripMenuItem.Image = Global.pToolz.My.Resources.Resources.x320005
        Me.LVORIToolStripMenuItem.Name = "LVORIToolStripMenuItem"
        Me.LVORIToolStripMenuItem.Size = New System.Drawing.Size(208, 32)
        Me.LVORIToolStripMenuItem.Text = "LVORI "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 708)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents txLogLocation As TextBox
    Friend WithEvents LogViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsStat As ToolStripStatusLabel
    Friend WithEvents t1 As Timer
End Class
