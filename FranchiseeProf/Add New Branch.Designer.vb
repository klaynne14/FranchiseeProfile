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
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbBranch = New System.Windows.Forms.ComboBox()
        Me.cbBusinessUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpStartTerm = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndTerm = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlBorderLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpEndTerm)
        Me.Panel1.Controls.Add(Me.dtpStartTerm)
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.cbBranch)
        Me.Panel1.Controls.Add(Me.cbBusinessUnit)
        Me.Panel1.Location = New System.Drawing.Point(6, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 198)
        Me.Panel1.TabIndex = 3
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddNew.Location = New System.Drawing.Point(328, 147)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(86, 30)
        Me.btnAddNew.TabIndex = 17
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'cbStatus
        '
        Me.cbStatus.ForeColor = System.Drawing.Color.DimGray
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(32, 147)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(101, 21)
        Me.cbStatus.TabIndex = 2
        '
        'cbBranch
        '
        Me.cbBranch.ForeColor = System.Drawing.Color.DimGray
        Me.cbBranch.FormattingEnabled = True
        Me.cbBranch.Location = New System.Drawing.Point(234, 42)
        Me.cbBranch.Name = "cbBranch"
        Me.cbBranch.Size = New System.Drawing.Size(180, 21)
        Me.cbBranch.TabIndex = 1
        '
        'cbBusinessUnit
        '
        Me.cbBusinessUnit.ForeColor = System.Drawing.Color.DimGray
        Me.cbBusinessUnit.FormattingEnabled = True
        Me.cbBusinessUnit.Location = New System.Drawing.Point(31, 42)
        Me.cbBusinessUnit.Name = "cbBusinessUnit"
        Me.cbBusinessUnit.Size = New System.Drawing.Size(180, 21)
        Me.cbBusinessUnit.TabIndex = 0
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
        'dtpStartTerm
        '
        Me.dtpStartTerm.Location = New System.Drawing.Point(31, 93)
        Me.dtpStartTerm.Name = "dtpStartTerm"
        Me.dtpStartTerm.Size = New System.Drawing.Size(180, 20)
        Me.dtpStartTerm.TabIndex = 18
        '
        'dtpEndTerm
        '
        Me.dtpEndTerm.CustomFormat = ""
        Me.dtpEndTerm.Location = New System.Drawing.Point(234, 93)
        Me.dtpEndTerm.Name = "dtpEndTerm"
        Me.dtpEndTerm.Size = New System.Drawing.Size(180, 20)
        Me.dtpEndTerm.TabIndex = 19
        Me.dtpEndTerm.Value = New Date(2019, 6, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Franchise Start Term"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Franchise End Term"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Business Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Branch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Status"
        '
        'Add_New_Branch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 255)
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
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBorderTop As Panel
    Friend WithEvents pnlBorderBottom As Panel
    Friend WithEvents pnlBorderRight As Panel
    Friend WithEvents pnlBorderLeft As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbBranch As ComboBox
    Friend WithEvents cbBusinessUnit As ComboBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpEndTerm As DateTimePicker
    Friend WithEvents dtpStartTerm As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
