<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddContract
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
        Me.lblOutletID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAddContract = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lvContract = New System.Windows.Forms.ListView()
        Me.idContract = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FPCStartTerm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FPCEndTerm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FPCRemark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpEndTerm = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTerm = New System.Windows.Forms.DateTimePicker()
        Me.lblDepositRemarks = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFranchiseRemarks = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPackageRemarks = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSecurityDeposit = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFranchiseFee = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPackageFee = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPackageType = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblOutletID)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnAddContract)
        Me.Panel1.Controls.Add(Me.txtRemarks)
        Me.Panel1.Controls.Add(Me.lvContract)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtpEndTerm)
        Me.Panel1.Controls.Add(Me.dtpStartTerm)
        Me.Panel1.Controls.Add(Me.lblDepositRemarks)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblFranchiseRemarks)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblPackageRemarks)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblSecurityDeposit)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblFranchiseFee)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblPackageFee)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblPackageType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 441)
        Me.Panel1.TabIndex = 0
        '
        'lblOutletID
        '
        Me.lblOutletID.AutoSize = True
        Me.lblOutletID.Location = New System.Drawing.Point(70, 255)
        Me.lblOutletID.Name = "lblOutletID"
        Me.lblOutletID.Size = New System.Drawing.Size(56, 13)
        Me.lblOutletID.TabIndex = 30
        Me.lblOutletID.Text = "lblOutletID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Outlet ID:"
        '
        'btnAddContract
        '
        Me.btnAddContract.Location = New System.Drawing.Point(428, 277)
        Me.btnAddContract.Name = "btnAddContract"
        Me.btnAddContract.Size = New System.Drawing.Size(49, 23)
        Me.btnAddContract.TabIndex = 28
        Me.btnAddContract.Text = "Add"
        Me.btnAddContract.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(220, 279)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(202, 20)
        Me.txtRemarks.TabIndex = 27
        '
        'lvContract
        '
        Me.lvContract.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idContract, Me.FPCStartTerm, Me.FPCEndTerm, Me.FPCRemark})
        Me.lvContract.Location = New System.Drawing.Point(35, 329)
        Me.lvContract.Name = "lvContract"
        Me.lvContract.Size = New System.Drawing.Size(442, 97)
        Me.lvContract.TabIndex = 26
        Me.lvContract.UseCompatibleStateImageBehavior = False
        Me.lvContract.View = System.Windows.Forms.View.Details
        '
        'idContract
        '
        Me.idContract.Text = "ID"
        '
        'FPCStartTerm
        '
        Me.FPCStartTerm.Text = "Start Term"
        Me.FPCStartTerm.Width = 100
        '
        'FPCEndTerm
        '
        Me.FPCEndTerm.Text = "End Term"
        Me.FPCEndTerm.Width = 107
        '
        'FPCRemark
        '
        Me.FPCRemark.Text = "Remarks"
        Me.FPCRemark.Width = 171
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(217, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Remarks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(14, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Contract"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "End Term"
        '
        'dtpEndTerm
        '
        Me.dtpEndTerm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndTerm.Location = New System.Drawing.Point(125, 280)
        Me.dtpEndTerm.Name = "dtpEndTerm"
        Me.dtpEndTerm.Size = New System.Drawing.Size(84, 20)
        Me.dtpEndTerm.TabIndex = 17
        '
        'dtpStartTerm
        '
        Me.dtpStartTerm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartTerm.Location = New System.Drawing.Point(35, 280)
        Me.dtpStartTerm.Name = "dtpStartTerm"
        Me.dtpStartTerm.Size = New System.Drawing.Size(84, 20)
        Me.dtpStartTerm.TabIndex = 16
        '
        'lblDepositRemarks
        '
        Me.lblDepositRemarks.AutoSize = True
        Me.lblDepositRemarks.Location = New System.Drawing.Point(306, 190)
        Me.lblDepositRemarks.Name = "lblDepositRemarks"
        Me.lblDepositRemarks.Size = New System.Drawing.Size(95, 13)
        Me.lblDepositRemarks.TabIndex = 15
        Me.lblDepositRemarks.Text = "lblDepositRemarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(248, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Remarks:"
        '
        'lblFranchiseRemarks
        '
        Me.lblFranchiseRemarks.AutoSize = True
        Me.lblFranchiseRemarks.Location = New System.Drawing.Point(306, 167)
        Me.lblFranchiseRemarks.Name = "lblFranchiseRemarks"
        Me.lblFranchiseRemarks.Size = New System.Drawing.Size(105, 13)
        Me.lblFranchiseRemarks.TabIndex = 13
        Me.lblFranchiseRemarks.Text = "lblFranchiseRemarks"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Remarks:"
        '
        'lblPackageRemarks
        '
        Me.lblPackageRemarks.AutoSize = True
        Me.lblPackageRemarks.Location = New System.Drawing.Point(306, 143)
        Me.lblPackageRemarks.Name = "lblPackageRemarks"
        Me.lblPackageRemarks.Size = New System.Drawing.Size(102, 13)
        Me.lblPackageRemarks.TabIndex = 11
        Me.lblPackageRemarks.Text = "lblPackageRemarks"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(248, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Remarks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Start Term"
        '
        'lblSecurityDeposit
        '
        Me.lblSecurityDeposit.AutoSize = True
        Me.lblSecurityDeposit.Location = New System.Drawing.Point(125, 190)
        Me.lblSecurityDeposit.Name = "lblSecurityDeposit"
        Me.lblSecurityDeposit.Size = New System.Drawing.Size(91, 13)
        Me.lblSecurityDeposit.TabIndex = 7
        Me.lblSecurityDeposit.Text = "lblSecurityDeposit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Security Deposit:"
        '
        'lblFranchiseFee
        '
        Me.lblFranchiseFee.AutoSize = True
        Me.lblFranchiseFee.Location = New System.Drawing.Point(125, 167)
        Me.lblFranchiseFee.Name = "lblFranchiseFee"
        Me.lblFranchiseFee.Size = New System.Drawing.Size(81, 13)
        Me.lblFranchiseFee.TabIndex = 5
        Me.lblFranchiseFee.Text = "lblFranchiseFee"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Franchise Fee:"
        '
        'lblPackageFee
        '
        Me.lblPackageFee.AutoSize = True
        Me.lblPackageFee.Location = New System.Drawing.Point(125, 143)
        Me.lblPackageFee.Name = "lblPackageFee"
        Me.lblPackageFee.Size = New System.Drawing.Size(78, 13)
        Me.lblPackageFee.TabIndex = 3
        Me.lblPackageFee.Text = "lblPackageFee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Package Fee:"
        '
        'lblPackageType
        '
        Me.lblPackageType.AutoSize = True
        Me.lblPackageType.Location = New System.Drawing.Point(73, 112)
        Me.lblPackageType.Name = "lblPackageType"
        Me.lblPackageType.Size = New System.Drawing.Size(77, 13)
        Me.lblPackageType.TabIndex = 1
        Me.lblPackageType.Text = "Package Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(483, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Add Contract"
        '
        'frmAddContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(516, 488)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddContract"
        Me.Text = "frmAddContract"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDepositRemarks As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFranchiseRemarks As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPackageRemarks As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSecurityDeposit As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFranchiseFee As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPackageFee As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPackageType As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpEndTerm As DateTimePicker
    Friend WithEvents dtpStartTerm As DateTimePicker
    Friend WithEvents btnAddContract As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lvContract As ListView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOutletID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents idContract As ColumnHeader
    Friend WithEvents FPCStartTerm As ColumnHeader
    Friend WithEvents FPCEndTerm As ColumnHeader
    Friend WithEvents FPCRemark As ColumnHeader
End Class
