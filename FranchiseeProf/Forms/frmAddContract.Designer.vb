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
        Me.btnConfirmOutlet = New System.Windows.Forms.Button()
        Me.txtRelocationAddress = New System.Windows.Forms.TextBox()
        Me.lblRelocationAddress = New System.Windows.Forms.Label()
        Me.lblStatusClosed = New System.Windows.Forms.Label()
        Me.cbStatusClosed = New System.Windows.Forms.ComboBox()
        Me.dtpCloseDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCloseDate = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbStatusOutlet = New System.Windows.Forms.CheckBox()
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
        Me.Panel1.Controls.Add(Me.btnConfirmOutlet)
        Me.Panel1.Controls.Add(Me.txtRelocationAddress)
        Me.Panel1.Controls.Add(Me.lblRelocationAddress)
        Me.Panel1.Controls.Add(Me.lblStatusClosed)
        Me.Panel1.Controls.Add(Me.cbStatusClosed)
        Me.Panel1.Controls.Add(Me.dtpCloseDate)
        Me.Panel1.Controls.Add(Me.lblCloseDate)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.cbStatusOutlet)
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
        Me.Panel1.Location = New System.Drawing.Point(8, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 501)
        Me.Panel1.TabIndex = 0
        '
        'btnConfirmOutlet
        '
        Me.btnConfirmOutlet.BackColor = System.Drawing.Color.CadetBlue
        Me.btnConfirmOutlet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmOutlet.ForeColor = System.Drawing.SystemColors.Window
        Me.btnConfirmOutlet.Location = New System.Drawing.Point(404, 454)
        Me.btnConfirmOutlet.Name = "btnConfirmOutlet"
        Me.btnConfirmOutlet.Size = New System.Drawing.Size(86, 30)
        Me.btnConfirmOutlet.TabIndex = 39
        Me.btnConfirmOutlet.Text = "Confirm"
        Me.btnConfirmOutlet.UseVisualStyleBackColor = False
        '
        'txtRelocationAddress
        '
        Me.txtRelocationAddress.Location = New System.Drawing.Point(284, 69)
        Me.txtRelocationAddress.Name = "txtRelocationAddress"
        Me.txtRelocationAddress.Size = New System.Drawing.Size(209, 20)
        Me.txtRelocationAddress.TabIndex = 38
        '
        'lblRelocationAddress
        '
        Me.lblRelocationAddress.AutoSize = True
        Me.lblRelocationAddress.Location = New System.Drawing.Point(281, 92)
        Me.lblRelocationAddress.Name = "lblRelocationAddress"
        Me.lblRelocationAddress.Size = New System.Drawing.Size(99, 13)
        Me.lblRelocationAddress.TabIndex = 37
        Me.lblRelocationAddress.Text = "Relocation Address"
        '
        'lblStatusClosed
        '
        Me.lblStatusClosed.AutoSize = True
        Me.lblStatusClosed.Location = New System.Drawing.Point(102, 93)
        Me.lblStatusClosed.Name = "lblStatusClosed"
        Me.lblStatusClosed.Size = New System.Drawing.Size(72, 13)
        Me.lblStatusClosed.TabIndex = 36
        Me.lblStatusClosed.Text = "Closed Status"
        '
        'cbStatusClosed
        '
        Me.cbStatusClosed.FormattingEnabled = True
        Me.cbStatusClosed.Items.AddRange(New Object() {"Temporary", "Permanent", "Relocated"})
        Me.cbStatusClosed.Location = New System.Drawing.Point(105, 69)
        Me.cbStatusClosed.Name = "cbStatusClosed"
        Me.cbStatusClosed.Size = New System.Drawing.Size(83, 21)
        Me.cbStatusClosed.TabIndex = 35
        '
        'dtpCloseDate
        '
        Me.dtpCloseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCloseDate.Location = New System.Drawing.Point(194, 69)
        Me.dtpCloseDate.Name = "dtpCloseDate"
        Me.dtpCloseDate.Size = New System.Drawing.Size(84, 20)
        Me.dtpCloseDate.TabIndex = 34
        '
        'lblCloseDate
        '
        Me.lblCloseDate.AutoSize = True
        Me.lblCloseDate.Location = New System.Drawing.Point(191, 92)
        Me.lblCloseDate.Name = "lblCloseDate"
        Me.lblCloseDate.Size = New System.Drawing.Size(65, 13)
        Me.lblCloseDate.TabIndex = 33
        Me.lblCloseDate.Text = "Date Closed"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(28, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 14)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Status"
        '
        'cbStatusOutlet
        '
        Me.cbStatusOutlet.AutoSize = True
        Me.cbStatusOutlet.Checked = True
        Me.cbStatusOutlet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusOutlet.Location = New System.Drawing.Point(49, 72)
        Me.cbStatusOutlet.Name = "cbStatusOutlet"
        Me.cbStatusOutlet.Size = New System.Drawing.Size(52, 17)
        Me.cbStatusOutlet.TabIndex = 31
        Me.cbStatusOutlet.Text = "Open"
        Me.cbStatusOutlet.UseVisualStyleBackColor = True
        '
        'lblOutletID
        '
        Me.lblOutletID.AutoSize = True
        Me.lblOutletID.Location = New System.Drawing.Point(438, 23)
        Me.lblOutletID.Name = "lblOutletID"
        Me.lblOutletID.Size = New System.Drawing.Size(56, 13)
        Me.lblOutletID.TabIndex = 30
        Me.lblOutletID.Text = "lblOutletID"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(383, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Outlet ID:"
        '
        'btnAddContract
        '
        Me.btnAddContract.Location = New System.Drawing.Point(438, 285)
        Me.btnAddContract.Name = "btnAddContract"
        Me.btnAddContract.Size = New System.Drawing.Size(52, 23)
        Me.btnAddContract.TabIndex = 28
        Me.btnAddContract.Text = "Add"
        Me.btnAddContract.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(233, 287)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(202, 20)
        Me.txtRemarks.TabIndex = 27
        '
        'lvContract
        '
        Me.lvContract.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idContract, Me.FPCStartTerm, Me.FPCEndTerm, Me.FPCRemark})
        Me.lvContract.Location = New System.Drawing.Point(48, 337)
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
        Me.Label11.Location = New System.Drawing.Point(230, 310)
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
        Me.Label8.Location = New System.Drawing.Point(28, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 14)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Contract"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "End Term"
        '
        'dtpEndTerm
        '
        Me.dtpEndTerm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndTerm.Location = New System.Drawing.Point(138, 288)
        Me.dtpEndTerm.Name = "dtpEndTerm"
        Me.dtpEndTerm.Size = New System.Drawing.Size(84, 20)
        Me.dtpEndTerm.TabIndex = 17
        '
        'dtpStartTerm
        '
        Me.dtpStartTerm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartTerm.Location = New System.Drawing.Point(48, 288)
        Me.dtpStartTerm.Name = "dtpStartTerm"
        Me.dtpStartTerm.Size = New System.Drawing.Size(84, 20)
        Me.dtpStartTerm.TabIndex = 16
        '
        'lblDepositRemarks
        '
        Me.lblDepositRemarks.AutoSize = True
        Me.lblDepositRemarks.Location = New System.Drawing.Point(304, 212)
        Me.lblDepositRemarks.Name = "lblDepositRemarks"
        Me.lblDepositRemarks.Size = New System.Drawing.Size(95, 13)
        Me.lblDepositRemarks.TabIndex = 15
        Me.lblDepositRemarks.Text = "lblDepositRemarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Remarks:"
        '
        'lblFranchiseRemarks
        '
        Me.lblFranchiseRemarks.AutoSize = True
        Me.lblFranchiseRemarks.Location = New System.Drawing.Point(304, 189)
        Me.lblFranchiseRemarks.Name = "lblFranchiseRemarks"
        Me.lblFranchiseRemarks.Size = New System.Drawing.Size(105, 13)
        Me.lblFranchiseRemarks.TabIndex = 13
        Me.lblFranchiseRemarks.Text = "lblFranchiseRemarks"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(246, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Remarks:"
        '
        'lblPackageRemarks
        '
        Me.lblPackageRemarks.AutoSize = True
        Me.lblPackageRemarks.Location = New System.Drawing.Point(304, 165)
        Me.lblPackageRemarks.Name = "lblPackageRemarks"
        Me.lblPackageRemarks.Size = New System.Drawing.Size(102, 13)
        Me.lblPackageRemarks.TabIndex = 11
        Me.lblPackageRemarks.Text = "lblPackageRemarks"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(246, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Remarks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Start Term"
        '
        'lblSecurityDeposit
        '
        Me.lblSecurityDeposit.AutoSize = True
        Me.lblSecurityDeposit.Location = New System.Drawing.Point(138, 212)
        Me.lblSecurityDeposit.Name = "lblSecurityDeposit"
        Me.lblSecurityDeposit.Size = New System.Drawing.Size(91, 13)
        Me.lblSecurityDeposit.TabIndex = 7
        Me.lblSecurityDeposit.Text = "lblSecurityDeposit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Security Deposit:"
        '
        'lblFranchiseFee
        '
        Me.lblFranchiseFee.AutoSize = True
        Me.lblFranchiseFee.Location = New System.Drawing.Point(138, 189)
        Me.lblFranchiseFee.Name = "lblFranchiseFee"
        Me.lblFranchiseFee.Size = New System.Drawing.Size(81, 13)
        Me.lblFranchiseFee.TabIndex = 5
        Me.lblFranchiseFee.Text = "lblFranchiseFee"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Franchise Fee:"
        '
        'lblPackageFee
        '
        Me.lblPackageFee.AutoSize = True
        Me.lblPackageFee.Location = New System.Drawing.Point(138, 165)
        Me.lblPackageFee.Name = "lblPackageFee"
        Me.lblPackageFee.Size = New System.Drawing.Size(78, 13)
        Me.lblPackageFee.TabIndex = 3
        Me.lblPackageFee.Text = "lblPackageFee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Package Fee:"
        '
        'lblPackageType
        '
        Me.lblPackageType.AutoSize = True
        Me.lblPackageType.Location = New System.Drawing.Point(86, 134)
        Me.lblPackageType.Name = "lblPackageType"
        Me.lblPackageType.Size = New System.Drawing.Size(77, 13)
        Me.lblPackageType.TabIndex = 1
        Me.lblPackageType.Text = "Package Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(509, 11)
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
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Outlet Details"
        '
        'frmAddContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(546, 559)
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
    Friend WithEvents txtRelocAddress As TextBox
    Friend WithEvents lblRelocAddress As Label
    Friend WithEvents lblOutletClosedStatus As Label
    Friend WithEvents cbOutletClosedStatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbOutletStatus As CheckBox
    Friend WithEvents lblOutletClosedDate As Label
    Friend WithEvents dtpDateClosed As DateTimePicker
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtRelocationAddress As TextBox
    Friend WithEvents lblRelocationAddress As Label
    Friend WithEvents lblStatusClosed As Label
    Friend WithEvents cbStatusClosed As ComboBox
    Friend WithEvents dtpCloseDate As DateTimePicker
    Friend WithEvents lblCloseDate As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbStatusOutlet As CheckBox
    Friend WithEvents btnConfirmOutlet As Button
End Class
