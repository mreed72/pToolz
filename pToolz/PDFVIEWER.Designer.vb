<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFVIEWER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFVIEWER))
        Me.Acro1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Acro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Acro1
        '
        Me.Acro1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Acro1.Enabled = True
        Me.Acro1.Location = New System.Drawing.Point(0, 55)
        Me.Acro1.Name = "Acro1"
        Me.Acro1.OcxState = CType(resources.GetObject("Acro1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Acro1.Size = New System.Drawing.Size(748, 730)
        Me.Acro1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = Global.pToolz.My.Resources.Resources.pdficonSMALL
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Industry Guidelines"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.pToolz.My.Resources.Resources.pdficonSMALL
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(169, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Row Crop Guidelines"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.pToolz.My.Resources.Resources.x320040
        Me.Button3.Location = New System.Drawing.Point(677, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 47)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PDFVIEWER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 785)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Acro1)
        Me.Name = "PDFVIEWER"
        Me.Text = "PDFVIEWER"
        CType(Me.Acro1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Acro1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
