<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txBurnSize = New System.Windows.Forms.TextBox()
        Me.txDistance = New System.Windows.Forms.TextBox()
        Me.txCatDay = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txFtype = New System.Windows.Forms.ComboBox()
        Me.txFload = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txAvFuels = New System.Windows.Forms.Label()
        Me.txAllowed = New System.Windows.Forms.Label()
        Me.txTotalTons = New System.Windows.Forms.Label()
        Me.txResults = New System.Windows.Forms.TextBox()
        Me.txRecommend = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pToolz.My.Resources.Resources._0814874ABC
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 44)
        Me.Panel1.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(330, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Light"
        '
        'Button1
        '
        Me.Button1.Image = Global.pToolz.My.Resources.Resources.weIMAGE118
        Me.Button1.Location = New System.Drawing.Point(451, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SINGLE FUEL CALCULATOR"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txBurnSize, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txDistance, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txCatDay, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(122, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(342, 58)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Size of Burn (acres):"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Target Distance (miles):"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Category Day:"
        '
        'txBurnSize
        '
        Me.txBurnSize.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txBurnSize.Location = New System.Drawing.Point(23, 33)
        Me.txBurnSize.Name = "txBurnSize"
        Me.txBurnSize.Size = New System.Drawing.Size(66, 20)
        Me.txBurnSize.TabIndex = 3
        '
        'txDistance
        '
        Me.txDistance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txDistance.Location = New System.Drawing.Point(151, 33)
        Me.txDistance.Name = "txDistance"
        Me.txDistance.Size = New System.Drawing.Size(45, 20)
        Me.txDistance.TabIndex = 4
        '
        'txCatDay
        '
        Me.txCatDay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txCatDay.Location = New System.Drawing.Point(272, 33)
        Me.txCatDay.Name = "txCatDay"
        Me.txCatDay.Size = New System.Drawing.Size(33, 20)
        Me.txCatDay.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txFtype, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txFload, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(122, 120)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(342, 58)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fuel Type:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Fuel Load:"
        '
        'txFtype
        '
        Me.txFtype.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txFtype.FormattingEnabled = True
        Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
        Me.txFtype.Location = New System.Drawing.Point(5, 33)
        Me.txFtype.Name = "txFtype"
        Me.txFtype.Size = New System.Drawing.Size(228, 21)
        Me.txFtype.TabIndex = 2
        '
        'txFload
        '
        Me.txFload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txFload.FormattingEnabled = True
        Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
        Me.txFload.Location = New System.Drawing.Point(245, 33)
        Me.txFload.Name = "txFload"
        Me.txFload.Size = New System.Drawing.Size(92, 21)
        Me.txFload.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txAvFuels, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txAllowed, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txTotalTons, 2, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(122, 184)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(342, 35)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Available Fuels:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Allowed Tonnage:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(195, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Tonnage:"
        '
        'txAvFuels
        '
        Me.txAvFuels.AutoSize = True
        Me.txAvFuels.Location = New System.Drawing.Point(5, 17)
        Me.txAvFuels.Name = "txAvFuels"
        Me.txAvFuels.Size = New System.Drawing.Size(13, 13)
        Me.txAvFuels.TabIndex = 3
        Me.txAvFuels.Text = "0"
        '
        'txAllowed
        '
        Me.txAllowed.AutoSize = True
        Me.txAllowed.Location = New System.Drawing.Point(94, 17)
        Me.txAllowed.Name = "txAllowed"
        Me.txAllowed.Size = New System.Drawing.Size(13, 13)
        Me.txAllowed.TabIndex = 4
        Me.txAllowed.Text = "0"
        '
        'txTotalTons
        '
        Me.txTotalTons.AutoSize = True
        Me.txTotalTons.Location = New System.Drawing.Point(195, 17)
        Me.txTotalTons.Name = "txTotalTons"
        Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
        Me.txTotalTons.TabIndex = 5
        Me.txTotalTons.Text = "0"
        '
        'txResults
        '
        Me.txResults.Location = New System.Drawing.Point(122, 225)
        Me.txResults.Name = "txResults"
        Me.txResults.Size = New System.Drawing.Size(342, 20)
        Me.txResults.TabIndex = 5
        '
        'txRecommend
        '
        Me.txRecommend.AutoSize = True
        Me.txRecommend.Location = New System.Drawing.Point(122, 252)
        Me.txRecommend.Name = "txRecommend"
        Me.txRecommend.Size = New System.Drawing.Size(18, 13)
        Me.txRecommend.TabIndex = 6
        Me.txRecommend.Text = "R:"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Image = Global.pToolz.My.Resources.Resources.x1602802
        Me.BtnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCalculate.Location = New System.Drawing.Point(0, 222)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(101, 23)
        Me.BtnCalculate.TabIndex = 8
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 275)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.txRecommend)
        Me.Controls.Add(Me.txResults)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txBurnSize As TextBox
    Friend WithEvents txDistance As TextBox
    Friend WithEvents txCatDay As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txFtype As ComboBox
    Friend WithEvents txFload As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txAvFuels As Label
    Friend WithEvents txAllowed As Label
    Friend WithEvents txTotalTons As Label
    Friend WithEvents txResults As TextBox
    Friend WithEvents txRecommend As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnCalculate As Button
End Class
