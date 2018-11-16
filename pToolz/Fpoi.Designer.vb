<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fpoi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txFDFM = New System.Windows.Forms.NumericUpDown()
        Me.txDryBulb = New System.Windows.Forms.NumericUpDown()
        Me.txShading = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bLog = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txResult = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.txFDFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txDryBulb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txShading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txFDFM)
        Me.Panel1.Controls.Add(Me.txDryBulb)
        Me.Panel1.Controls.Add(Me.txShading)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 100)
        Me.Panel1.TabIndex = 0
        '
        'txFDFM
        '
        Me.txFDFM.Location = New System.Drawing.Point(169, 65)
        Me.txFDFM.Name = "txFDFM"
        Me.txFDFM.Size = New System.Drawing.Size(51, 22)
        Me.txFDFM.TabIndex = 2
        '
        'txDryBulb
        '
        Me.txDryBulb.Location = New System.Drawing.Point(169, 37)
        Me.txDryBulb.Name = "txDryBulb"
        Me.txDryBulb.Size = New System.Drawing.Size(51, 22)
        Me.txDryBulb.TabIndex = 1
        '
        'txShading
        '
        Me.txShading.Location = New System.Drawing.Point(169, 9)
        Me.txShading.Name = "txShading"
        Me.txShading.Size = New System.Drawing.Size(51, 22)
        Me.txShading.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fine Dead Fuel Moisture:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dry Bulb Temp:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shading (%):"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.bLog)
        Me.Panel2.Controls.Add(Me.pb)
        Me.Panel2.Controls.Add(Me.btnCalc)
        Me.Panel2.Controls.Add(Me.txResult)
        Me.Panel2.Location = New System.Drawing.Point(12, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 100)
        Me.Panel2.TabIndex = 1
        '
        'bLog
        '
        Me.bLog.AutoSize = True
        Me.bLog.Location = New System.Drawing.Point(115, 66)
        Me.bLog.Name = "bLog"
        Me.bLog.Size = New System.Drawing.Size(48, 17)
        Me.bLog.TabIndex = 4
        Me.bLog.Text = "Label4"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(91, 65)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(18, 18)
        Me.pb.TabIndex = 3
        Me.pb.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.Image = Global.pToolz.My.Resources.Resources._56260
        Me.btnCalc.Location = New System.Drawing.Point(157, 13)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(38, 30)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txResult
        '
        Me.txResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txResult.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txResult.Location = New System.Drawing.Point(46, 13)
        Me.txResult.Name = "txResult"
        Me.txResult.ReadOnly = True
        Me.txResult.Size = New System.Drawing.Size(100, 30)
        Me.txResult.TabIndex = 0
        Me.txResult.TabStop = False
        Me.txResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fpoi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(275, 231)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Fpoi"
        Me.Text = "Probability of Ignition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txFDFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txDryBulb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txShading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txFDFM As NumericUpDown
    Friend WithEvents txDryBulb As NumericUpDown
    Friend WithEvents txShading As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txResult As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents bLog As Label
    Friend WithEvents pb As PictureBox
End Class
