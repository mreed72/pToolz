<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FarchiveChoose
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
        Me.bx1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bx1
        '
        Me.bx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.bx1.FormattingEnabled = True
        Me.bx1.Location = New System.Drawing.Point(0, 0)
        Me.bx1.Name = "bx1"
        Me.bx1.Size = New System.Drawing.Size(379, 264)
        Me.bx1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Double-Click selected archive to open"
        '
        'FarchiveChoose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 289)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FarchiveChoose"
        Me.Text = "Session Archives"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bx1 As ListBox
    Friend WithEvents Label1 As Label
End Class
