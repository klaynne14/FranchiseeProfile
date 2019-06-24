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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.pnlFranchiseTerm = New System.Windows.Forms.Panel()
        Me.lblFranchiseTerm = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.cbBusinessUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlBorderLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlFranchiseTerm.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Controls.Add(Me.pnlFranchiseTerm)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.cbBranch)
        Me.Panel1.Controls.Add(Me.cbBusinessUnit)
        Me.Panel1.Location = New System.Drawing.Point(6, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 162)
        Me.Panel1.TabIndex = 3
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddNew.Location = New System.Drawing.Point(318, 118)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(71, 30)
        Me.btnAddNew.TabIndex = 17
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'pnlFranchiseTerm
        '
        Me.pnlFranchiseTerm.BackColor = System.Drawing.SystemColors.Window
        Me.pnlFranchiseTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFranchiseTerm.Controls.Add(Me.lblFranchiseTerm)
        Me.pnlFranchiseTerm.Location = New System.Drawing.Point(31, 65)
        Me.pnlFranchiseTerm.Name = "pnlFranchiseTerm"
        Me.pnlFranchiseTerm.Size = New System.Drawing.Size(136, 21)
        Me.pnlFranchiseTerm.TabIndex = 3
        '
        'lblFranchiseTerm
        '
        Me.lblFranchiseTerm.AutoSize = True
        Me.lblFranchiseTerm.BackColor = System.Drawing.SystemColors.Window
        Me.lblFranchiseTerm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFranchiseTerm.ForeColor = System.Drawing.Color.DimGray
        Me.lblFranchiseTerm.Location = New System.Drawing.Point(3, 3)
        Me.lblFranchiseTerm.Name = "lblFranchiseTerm"
        Me.lblFranchiseTerm.Size = New System.Drawing.Size(94, 13)
        Me.lblFranchiseTerm.TabIndex = 0
        Me.lblFranchiseTerm.Text = "Franchise Term"
        '
        'cbStatus
        '
        Me.cbStatus.ForeColor = System.Drawing.Color.DimGray
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(226, 65)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(101, 21)
        Me.cbStatus.TabIndex = 2
        Me.cbStatus.Text = "Status"
        '
        'cbBranch
        '
        Me.cbBranch.ForeColor = System.Drawing.Color.DimGray
        Me.cbBranch.FormattingEnabled = True
        Me.cbBranch.Location = New System.Drawing.Point(226, 26)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(163, 21)
        Me.cbBranch.TabIndex = 1
        Me.cbBranch.Text = "Branch"
        '
        'cbBusinessUnit
        '
        Me.cbBusinessUnit.ForeColor = System.Drawing.Color.DimGray
        Me.cbBusinessUnit.FormattingEnabled = True
        Me.cbBusinessUnit.Location = New System.Drawing.Point(30, 26)
        Me.cbBusinessUnit.Name = "cbBusinessUnit"
        Me.cbBusinessUnit.Size = New System.Drawing.Size(155, 21)
        Me.cbBusinessUnit.TabIndex = 0
        Me.cbBusinessUnit.Text = "Business Unit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Add New Branch"
        '
        'Add_New_Branch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(423, 215)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBorderBottom)
        Me.Controls.Add(Me.pnlBorderTop)
        Me.Controls.Add(Me.pnlBorderLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(198, 470)
        Me.Name = "Add_New_Branch"
        Me.Text = "Add_New_Branch"
        Me.pnlBorderLeft.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlFranchiseTerm.ResumeLayout(False)
        Me.pnlFranchiseTerm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBorderTop As Panel
    Friend WithEvents pnlBorderBottom As Panel
    Friend WithEvents pnlBorderRight As Panel
    Friend WithEvents pnlBorderLeft As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlFranchiseTerm As Panel
    Friend WithEvents lblFranchiseTerm As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbBranch As ComboBox
    Friend WithEvents cbBusinessUnit As ComboBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents Label2 As Label
End Class
