<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_New_Branch
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
        Me.pnlBorderTop = New System.Windows.Forms.Panel()
        Me.pnlBorderBottom = New System.Windows.Forms.Panel()
        Me.pnlBorderRight = New System.Windows.Forms.Panel()
        Me.pnlBorderLeft = New System.Windows.Forms.Panel()
        Me.pnlBorderLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBorderTop
        '
        Me.pnlBorderTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlBorderTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlBorderTop.Name = "pnlBorderTop"
        Me.pnlBorderTop.Size = New System.Drawing.Size(423, 0)
        Me.pnlBorderTop.TabIndex = 1
        '
        'pnlBorderBottom
        '
        Me.pnlBorderBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlBorderBottom.Location = New System.Drawing.Point(198, 470)
        Me.pnlBorderBottom.Name = "pnlBorderBottom"
        Me.pnlBorderBottom.Size = New System.Drawing.Size(423, 0)
        Me.pnlBorderBottom.TabIndex = 2
        '
        'pnlBorderRight
        '
        Me.pnlBorderRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlBorderRight.Location = New System.Drawing.Point(423, 0)
        Me.pnlBorderRight.Name = "pnlBorderRight"
        Me.pnlBorderRight.Size = New System.Drawing.Size(0, 215)
        Me.pnlBorderRight.TabIndex = 1
        '
        'pnlBorderLeft
        '
        Me.pnlBorderLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlBorderLeft.Controls.Add(Me.pnlBorderRight)
        Me.pnlBorderLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlBorderLeft.Name = "pnlBorderLeft"
        Me.pnlBorderLeft.Size = New System.Drawing.Size(0, 215)
        Me.pnlBorderLeft.TabIndex = 0
        '
        'Add_New_Branch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(423, 215)
        Me.Controls.Add(Me.pnlBorderBottom)
        Me.Controls.Add(Me.pnlBorderTop)
        Me.Controls.Add(Me.pnlBorderLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(198, 470)
        Me.Name = "Add_New_Branch"
        Me.Text = "Add_New_Branch"
        Me.pnlBorderLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBorderTop As Panel
    Friend WithEvents pnlBorderBottom As Panel
    Friend WithEvents pnlBorderRight As Panel
    Friend WithEvents pnlBorderLeft As Panel
End Class
