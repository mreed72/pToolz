<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmultiCalc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txBlockSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txFtype = New System.Windows.Forms.ComboBox()
        Me.txFload = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bFtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bFload = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bavfuels = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bTons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txTotalSize = New System.Windows.Forms.Label()
        Me.txTotalTons = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txResults = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txCatDay = New System.Windows.Forms.TextBox()
        Me.txDistance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txAllowed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txDistance)
        Me.Panel1.Controls.Add(Me.txCatDay)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnCalc)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txFload)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txFtype)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txBlockSize)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 81)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Block Size:"
        '
        'txBlockSize
        '
        Me.txBlockSize.Location = New System.Drawing.Point(6, 20)
        Me.txBlockSize.Name = "txBlockSize"
        Me.txBlockSize.Size = New System.Drawing.Size(63, 22)
        Me.txBlockSize.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fuel Type:"
        '
        'txFtype
        '
        Me.txFtype.FormattingEnabled = True
        Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
        Me.txFtype.Location = New System.Drawing.Point(92, 20)
        Me.txFtype.Name = "txFtype"
        Me.txFtype.Size = New System.Drawing.Size(243, 25)
        Me.txFtype.TabIndex = 3
        '
        'txFload
        '
        Me.txFload.FormattingEnabled = True
        Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
        Me.txFload.Location = New System.Drawing.Point(341, 20)
        Me.txFload.Name = "txFload"
        Me.txFload.Size = New System.Drawing.Size(113, 25)
        Me.txFload.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fuel Load:"
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bSize, Me.bFtype, Me.bFload, Me.bavfuels, Me.bTons})
        Me.dgv.Location = New System.Drawing.Point(12, 99)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(638, 225)
        Me.dgv.TabIndex = 7
        '
        'bSize
        '
        Me.bSize.HeaderText = "Size"
        Me.bSize.Name = "bSize"
        '
        'bFtype
        '
        Me.bFtype.HeaderText = "Fuel Type"
        Me.bFtype.Name = "bFtype"
        '
        'bFload
        '
        Me.bFload.HeaderText = "Fuel Load"
        Me.bFload.Name = "bFload"
        '
        'bavfuels
        '
        Me.bavfuels.HeaderText = "AvFuels"
        Me.bavfuels.Name = "bavfuels"
        '
        'bTons
        '
        Me.bTons.HeaderText = "Total Tons"
        Me.bTons.Name = "bTons"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Size:"
        '
        'txTotalSize
        '
        Me.txTotalSize.AutoSize = True
        Me.txTotalSize.Location = New System.Drawing.Point(84, 327)
        Me.txTotalSize.Name = "txTotalSize"
        Me.txTotalSize.Size = New System.Drawing.Size(15, 17)
        Me.txTotalSize.TabIndex = 8
        Me.txTotalSize.Text = "0"
        '
        'txTotalTons
        '
        Me.txTotalTons.AutoSize = True
        Me.txTotalTons.Location = New System.Drawing.Point(524, 327)
        Me.txTotalTons.Name = "txTotalTons"
        Me.txTotalTons.Size = New System.Drawing.Size(15, 17)
        Me.txTotalTons.TabIndex = 10
        Me.txTotalTons.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(452, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Tons:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Image = Global.pToolz.My.Resources.Resources.weIMAGE072
        Me.btnClear.Location = New System.Drawing.Point(579, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(47, 42)
        Me.btnClear.TabIndex = 8
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Image = Global.pToolz.My.Resources.Resources.weIMAGE048
        Me.btnCalc.Location = New System.Drawing.Point(526, 3)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(47, 42)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Image = Global.pToolz.My.Resources.Resources.weIMAGE096
        Me.btnAdd.Location = New System.Drawing.Point(460, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(44, 42)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txResults
        '
        Me.txResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txResults.Location = New System.Drawing.Point(12, 357)
        Me.txResults.Name = "txResults"
        Me.txResults.Size = New System.Drawing.Size(638, 22)
        Me.txResults.TabIndex = 11
        Me.txResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Category Day:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Target Distance:"
        '
        'txCatDay
        '
        Me.txCatDay.Location = New System.Drawing.Point(102, 48)
        Me.txCatDay.Name = "txCatDay"
        Me.txCatDay.Size = New System.Drawing.Size(39, 22)
        Me.txCatDay.TabIndex = 11
        '
        'txDistance
        '
        Me.txDistance.Location = New System.Drawing.Point(258, 48)
        Me.txDistance.Name = "txDistance"
        Me.txDistance.Size = New System.Drawing.Size(50, 22)
        Me.txDistance.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Allowed Tons:"
        '
        'txAllowed
        '
        Me.txAllowed.AutoSize = True
        Me.txAllowed.Location = New System.Drawing.Point(303, 327)
        Me.txAllowed.Name = "txAllowed"
        Me.txAllowed.Size = New System.Drawing.Size(15, 17)
        Me.txAllowed.TabIndex = 14
        Me.txAllowed.Text = "0"
        '
        'FmultiCalc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(659, 391)
        Me.Controls.Add(Me.txAllowed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txResults)
        Me.Controls.Add(Me.txTotalTons)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txTotalSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FmultiCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Fuels Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents txFload As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txFtype As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txBlockSize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents bSize As DataGridViewTextBoxColumn
    Friend WithEvents bFtype As DataGridViewTextBoxColumn
    Friend WithEvents bFload As DataGridViewTextBoxColumn
    Friend WithEvents bavfuels As DataGridViewTextBoxColumn
    Friend WithEvents bTons As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txTotalSize As Label
    Friend WithEvents txTotalTons As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txResults As TextBox
    Friend WithEvents txDistance As TextBox
    Friend WithEvents txCatDay As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txAllowed As Label
End Class
