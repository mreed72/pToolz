<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fsmokecalc
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txResults = New System.Windows.Forms.TextBox()
        Me.txAllowed = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txTotalTons = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txAvFuels = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txFload = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txFtype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txDistance = New System.Windows.Forms.TextBox()
        Me.txBurnSize = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txCatDay = New System.Windows.Forms.TextBox()
        Me.txRecSize = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 133)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txResults)
        Me.Panel4.Controls.Add(Me.txAllowed)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txTotalTons)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txAvFuels)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(3, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(581, 53)
        Me.Panel4.TabIndex = 8
        '
        'txResults
        '
        Me.txResults.BackColor = System.Drawing.SystemColors.Control
        Me.txResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txResults.ForeColor = System.Drawing.Color.Black
        Me.txResults.Location = New System.Drawing.Point(3, 23)
        Me.txResults.Name = "txResults"
        Me.txResults.ReadOnly = True
        Me.txResults.Size = New System.Drawing.Size(565, 22)
        Me.txResults.TabIndex = 6
        Me.txResults.TabStop = False
        Me.txResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txAllowed
        '
        Me.txAllowed.AutoSize = True
        Me.txAllowed.Location = New System.Drawing.Point(465, 7)
        Me.txAllowed.Name = "txAllowed"
        Me.txAllowed.Size = New System.Drawing.Size(13, 13)
        Me.txAllowed.TabIndex = 5
        Me.txAllowed.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(385, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Allowed Tons:"
        '
        'txTotalTons
        '
        Me.txTotalTons.AutoSize = True
        Me.txTotalTons.Location = New System.Drawing.Point(315, 7)
        Me.txTotalTons.Name = "txTotalTons"
        Me.txTotalTons.Size = New System.Drawing.Size(13, 13)
        Me.txTotalTons.TabIndex = 3
        Me.txTotalTons.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Tons:"
        '
        'txAvFuels
        '
        Me.txAvFuels.AutoSize = True
        Me.txAvFuels.Location = New System.Drawing.Point(181, 7)
        Me.txAvFuels.Name = "txAvFuels"
        Me.txAvFuels.Size = New System.Drawing.Size(13, 13)
        Me.txAvFuels.TabIndex = 1
        Me.txAvFuels.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Available Fuels:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txFload)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txFtype)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(261, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(323, 61)
        Me.Panel3.TabIndex = 1
        '
        'txFload
        '
        Me.txFload.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txFload.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txFload.FormattingEnabled = True
        Me.txFload.Items.AddRange(New Object() {"Low", "Moderate", "Heavy"})
        Me.txFload.Location = New System.Drawing.Point(195, 22)
        Me.txFload.Name = "txFload"
        Me.txFload.Size = New System.Drawing.Size(121, 21)
        Me.txFload.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txFload, "Select the amount of fuel loading")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fuel Load:"
        '
        'txFtype
        '
        Me.txFtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txFtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txFtype.FormattingEnabled = True
        Me.txFtype.Items.AddRange(New Object() {"Shortleaf Pine with Oak", "Shortleaf Pine Regeneration", "Loblolly Pine with Oak", "Loblolly Pine Regeneration", "Hardwood Leaf Litter", "Grass or Brush", "Dispersed Slash", "Piled Debris", "Shortleaf Loblolly with Grass", "Corn", "Cotton", "Rice", "Soybean", "Wheat"})
        Me.txFtype.Location = New System.Drawing.Point(9, 22)
        Me.txFtype.Name = "txFtype"
        Me.txFtype.Size = New System.Drawing.Size(184, 21)
        Me.txFtype.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txFtype, "Select the type of fuel")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fuel Type:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txDistance)
        Me.Panel2.Controls.Add(Me.txBurnSize)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txCatDay)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 61)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Size of the burn or block (in acres):"
        '
        'txDistance
        '
        Me.txDistance.Location = New System.Drawing.Point(209, 35)
        Me.txDistance.Name = "txDistance"
        Me.txDistance.Size = New System.Drawing.Size(32, 20)
        Me.txDistance.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txDistance, "Target distance in MILES (decimals okay)")
        '
        'txBurnSize
        '
        Me.txBurnSize.Location = New System.Drawing.Point(180, 9)
        Me.txBurnSize.Name = "txBurnSize"
        Me.txBurnSize.Size = New System.Drawing.Size(61, 20)
        Me.txBurnSize.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txBurnSize, "Size of the burn (in acres) no decimals")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Target Distance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Category Day:"
        '
        'txCatDay
        '
        Me.txCatDay.Location = New System.Drawing.Point(91, 35)
        Me.txCatDay.Name = "txCatDay"
        Me.txCatDay.Size = New System.Drawing.Size(32, 20)
        Me.txCatDay.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txCatDay, "A Number 1 through 5")
        '
        'txRecSize
        '
        Me.txRecSize.AutoSize = True
        Me.txRecSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRecSize.Location = New System.Drawing.Point(159, 9)
        Me.txRecSize.Name = "txRecSize"
        Me.txRecSize.Size = New System.Drawing.Size(15, 16)
        Me.txRecSize.TabIndex = 4
        Me.txRecSize.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Recommended Acres:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Image = Global.pToolz.My.Resources.Resources._92055
        Me.btnClear.Location = New System.Drawing.Point(430, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(36, 25)
        Me.btnClear.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnClear, "CLEAR ALL FIELDS")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Image = Global.pToolz.My.Resources.Resources._56260
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(472, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 25)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnCalc, "Calculate Smoke Mgmt")
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.pToolz.My.Resources.Resources.weIMAGE118
        Me.Button1.Location = New System.Drawing.Point(578, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button1, "Close this form")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.txRecSize)
        Me.Panel5.Location = New System.Drawing.Point(12, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 35)
        Me.Panel5.TabIndex = 5
        '
        'Fsmokecalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(615, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Fsmokecalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smoke Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txFload As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txFtype As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txDistance As TextBox
    Friend WithEvents txBurnSize As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txCatDay As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txResults As TextBox
    Friend WithEvents txAllowed As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txTotalTons As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txAvFuels As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txRecSize As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel5 As Panel
End Class
