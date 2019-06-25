<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateNewFranchisee
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblPersoInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddFranchise = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.btnAddFranchise)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.lblAddress)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblLName)
        Me.Panel1.Controls.Add(Me.lblFName)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtLName)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.lblPersoInfo)
        Me.Panel1.Location = New System.Drawing.Point(10, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 452)
        Me.Panel1.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(43, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 44
        Me.lblStatus.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cbStatus.Location = New System.Drawing.Point(46, 156)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(93, 21)
        Me.cbStatus.TabIndex = 43
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(408, 93)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(64, 13)
        Me.lblContact.TabIndex = 42
        Me.lblContact.Text = "Contact No."
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(43, 93)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 41
        Me.lblAddress.Text = "Address"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(408, 46)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 40
        Me.lblEmail.Text = "Email"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(224, 46)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 39
        Me.lblLName.Text = "Last Name"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(43, 46)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 38
        Me.lblFName.Text = "First Name"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.SystemColors.Window
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.DarkGray
        Me.txtContact.Location = New System.Drawing.Point(411, 109)
        Me.txtContact.MaxLength = 32
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(167, 24)
        Me.txtContact.TabIndex = 37
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.DarkGray
        Me.txtAddress.Location = New System.Drawing.Point(46, 109)
        Me.txtAddress.MaxLength = 64
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(348, 24)
        Me.txtAddress.TabIndex = 36
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.txtEmail.Location = New System.Drawing.Point(411, 62)
        Me.txtEmail.MaxLength = 32
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 24)
        Me.txtEmail.TabIndex = 35
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtLName.Location = New System.Drawing.Point(227, 62)
        Me.txtLName.MaxLength = 32
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(167, 24)
        Me.txtLName.TabIndex = 34
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.ForeColor = System.Drawing.Color.DarkGray
        Me.txtFName.Location = New System.Drawing.Point(46, 62)
        Me.txtFName.MaxLength = 32
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(167, 24)
        Me.txtFName.TabIndex = 33
        '
        'lblPersoInfo
        '
        Me.lblPersoInfo.AutoSize = True
        Me.lblPersoInfo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersoInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPersoInfo.Location = New System.Drawing.Point(19, 16)
        Me.lblPersoInfo.Name = "lblPersoInfo"
        Me.lblPersoInfo.Size = New System.Drawing.Size(174, 17)
        Me.lblPersoInfo.TabIndex = 7
        Me.lblPersoInfo.Text = "Personal Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Create New Franchisee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(19, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Franchise"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(556, 116)
        Me.DataGridView1.TabIndex = 46
        '
        'btnAddFranchise
        '
        Me.btnAddFranchise.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddFranchise.FlatAppearance.BorderSize = 0
        Me.btnAddFranchise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFranchise.ForeColor = System.Drawing.Color.White
        Me.btnAddFranchise.Location = New System.Drawing.Point(22, 239)
        Me.btnAddFranchise.Name = "btnAddFranchise"
        Me.btnAddFranchise.Size = New System.Drawing.Size(123, 23)
        Me.btnAddFranchise.TabIndex = 47
        Me.btnAddFranchise.Text = "Add New Franchise"
        Me.btnAddFranchise.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSubmit.Location = New System.Drawing.Point(492, 404)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(86, 30)
        Me.btnSubmit.TabIndex = 48
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(589, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 49
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmCreateNewFranchisee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 512)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreateNewFranchisee"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPersoInfo As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddFranchise As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClose As Button
End Class
