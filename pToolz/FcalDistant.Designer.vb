<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FcalDistant
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lat1 = New System.Windows.Forms.MaskedTextBox()
        Me.long1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.long2 = New System.Windows.Forms.MaskedTextBox()
        Me.lat2 = New System.Windows.Forms.MaskedTextBox()
        Me.txResult = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txResult2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latitude and Longitude:"
        '
        'lat1
        '
        Me.lat1.Location = New System.Drawing.Point(24, 58)
        Me.lat1.Mask = "00.0000"
        Me.lat1.Name = "lat1"
        Me.lat1.Size = New System.Drawing.Size(100, 22)
        Me.lat1.TabIndex = 1
        Me.lat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'long1
        '
        Me.long1.Location = New System.Drawing.Point(24, 86)
        Me.long1.Mask = "-00.0000"
        Me.long1.Name = "long1"
        Me.long1.Size = New System.Drawing.Size(100, 22)
        Me.long1.TabIndex = 2
        Me.long1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Latitude and Longitude:"
        '
        'long2
        '
        Me.long2.Location = New System.Drawing.Point(268, 86)
        Me.long2.Mask = "-00.0000"
        Me.long2.Name = "long2"
        Me.long2.Size = New System.Drawing.Size(100, 22)
        Me.long2.TabIndex = 5
        Me.long2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lat2
        '
        Me.lat2.Location = New System.Drawing.Point(268, 58)
        Me.lat2.Mask = "00.0000"
        Me.lat2.Name = "lat2"
        Me.lat2.Size = New System.Drawing.Size(100, 22)
        Me.lat2.TabIndex = 4
        Me.lat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txResult
        '
        Me.txResult.Location = New System.Drawing.Point(51, 114)
        Me.txResult.Name = "txResult"
        Me.txResult.Size = New System.Drawing.Size(291, 22)
        Me.txResult.TabIndex = 6
        Me.txResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFind.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFind.Location = New System.Drawing.Point(158, 57)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 51)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Submit"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Point 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Point 2"
        '
        'txResult2
        '
        Me.txResult2.Location = New System.Drawing.Point(51, 142)
        Me.txResult2.Name = "txResult2"
        Me.txResult2.Size = New System.Drawing.Size(291, 22)
        Me.txResult2.TabIndex = 10
        Me.txResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FcalDistant
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(396, 176)
        Me.Controls.Add(Me.txResult2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txResult)
        Me.Controls.Add(Me.long2)
        Me.Controls.Add(Me.lat2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.long1)
        Me.Controls.Add(Me.lat1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FcalDistant"
        Me.Text = "Calculate distance between two points"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lat1 As MaskedTextBox
    Friend WithEvents long1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents long2 As MaskedTextBox
    Friend WithEvents lat2 As MaskedTextBox
    Friend WithEvents txResult As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txResult2 As TextBox
End Class
