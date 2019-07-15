<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewOutlet
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
        Me.lblOutletID = New System.Windows.Forms.Label()
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDateOfRefund = New System.Windows.Forms.DateTimePicker()
        Me.txtLocationName = New System.Windows.Forms.TextBox()
        Me.txtDepositRemark = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSecurityDeposit = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFranchiseRemark = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFranchiseeFee = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPackageRemark = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPackageFee = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPackageType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateOpened = New System.Windows.Forms.DateTimePicker()
        Me.txtOutletAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.lblOutletID)
        Me.Panel1.Controls.Add(Me.lblOutlet)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpDateOfRefund)
        Me.Panel1.Controls.Add(Me.txtLocationName)
        Me.Panel1.Controls.Add(Me.txtDepositRemark)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtSecurityDeposit)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtFranchiseRemark)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtFranchiseeFee)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtPackageRemark)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtPackageFee)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cbPackageType)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpDateOpened)
        Me.Panel1.Controls.Add(Me.txtOutletAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Location = New System.Drawing.Point(6, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 456)
        Me.Panel1.TabIndex = 3
        '
        'lblOutletID
        '
        Me.lblOutletID.AutoSize = True
        Me.lblOutletID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletID.Location = New System.Drawing.Point(119, 23)
        Me.lblOutletID.Name = "lblOutletID"
        Me.lblOutletID.Size = New System.Drawing.Size(0, 13)
        Me.lblOutletID.TabIndex = 55
        '
        'lblOutlet
        '
        Me.lblOutlet.AutoSize = True
        Me.lblOutlet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutlet.Location = New System.Drawing.Point(18, 23)
        Me.lblOutlet.Name = "lblOutlet"
        Me.lblOutlet.Size = New System.Drawing.Size(95, 13)
        Me.lblOutlet.TabIndex = 54
        Me.lblOutlet.Text = "Franchisee ID: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(163, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Date of Refund"
        '
        'dtpDateOfRefund
        '
        Me.dtpDateOfRefund.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateOfRefund.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfRefund.Location = New System.Drawing.Point(166, 349)
        Me.dtpDateOfRefund.Name = "dtpDateOfRefund"
        Me.dtpDateOfRefund.Size = New System.Drawing.Size(90, 20)
        Me.dtpDateOfRefund.TabIndex = 52
        '
        'txtLocationName
        '
        Me.txtLocationName.Location = New System.Drawing.Point(36, 61)
        Me.txtLocationName.Name = "txtLocationName"
        Me.txtLocationName.Size = New System.Drawing.Size(202, 20)
        Me.txtLocationName.TabIndex = 49
        '
        'txtDepositRemark
        '
        Me.txtDepositRemark.Location = New System.Drawing.Point(166, 305)
        Me.txtDepositRemark.Name = "txtDepositRemark"
        Me.txtDepositRemark.Size = New System.Drawing.Size(169, 20)
        Me.txtDepositRemark.TabIndex = 48
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(164, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Remarks"
        '
        'txtSecurityDeposit
        '
        Me.txtSecurityDeposit.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSecurityDeposit.Location = New System.Drawing.Point(34, 305)
        Me.txtSecurityDeposit.Name = "txtSecurityDeposit"
        Me.txtSecurityDeposit.Size = New System.Drawing.Size(126, 20)
        Me.txtSecurityDeposit.TabIndex = 46
        Me.txtSecurityDeposit.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(33, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Security Deposit"
        '
        'txtFranchiseRemark
        '
        Me.txtFranchiseRemark.Location = New System.Drawing.Point(167, 260)
        Me.txtFranchiseRemark.Name = "txtFranchiseRemark"
        Me.txtFranchiseRemark.Size = New System.Drawing.Size(169, 20)
        Me.txtFranchiseRemark.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(164, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Remarks"
        '
        'txtFranchiseeFee
        '
        Me.txtFranchiseeFee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFranchiseeFee.Location = New System.Drawing.Point(35, 260)
        Me.txtFranchiseeFee.Name = "txtFranchiseeFee"
        Me.txtFranchiseeFee.Size = New System.Drawing.Size(126, 20)
        Me.txtFranchiseeFee.TabIndex = 42
        Me.txtFranchiseeFee.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(35, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Franchise fee"
        '
        'txtPackageRemark
        '
        Me.txtPackageRemark.Location = New System.Drawing.Point(167, 214)
        Me.txtPackageRemark.Name = "txtPackageRemark"
        Me.txtPackageRemark.Size = New System.Drawing.Size(169, 20)
        Me.txtPackageRemark.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(164, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Remarks"
        '
        'txtPackageFee
        '
        Me.txtPackageFee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPackageFee.Location = New System.Drawing.Point(35, 214)
        Me.txtPackageFee.Name = "txtPackageFee"
        Me.txtPackageFee.Size = New System.Drawing.Size(126, 20)
        Me.txtPackageFee.TabIndex = 38
        Me.txtPackageFee.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(35, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Package fee"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(32, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Package Type"
        '
        'cbPackageType
        '
        Me.cbPackageType.ForeColor = System.Drawing.Color.DimGray
        Me.cbPackageType.FormattingEnabled = True
        Me.cbPackageType.Items.AddRange(New Object() {" ", "Customize", "School", "Counter", "School-Counter", "Standard"})
        Me.cbPackageType.Location = New System.Drawing.Point(36, 168)
        Me.cbPackageType.Name = "cbPackageType"
        Me.cbPackageType.Size = New System.Drawing.Size(125, 21)
        Me.cbPackageType.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(241, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Date Opened"
        '
        'dtpDateOpened
        '
        Me.dtpDateOpened.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateOpened.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOpened.Location = New System.Drawing.Point(244, 61)
        Me.dtpDateOpened.Name = "dtpDateOpened"
        Me.dtpDateOpened.Size = New System.Drawing.Size(92, 20)
        Me.dtpDateOpened.TabIndex = 27
        '
        'txtOutletAddress
        '
        Me.txtOutletAddress.Location = New System.Drawing.Point(36, 106)
        Me.txtOutletAddress.Name = "txtOutletAddress"
        Me.txtOutletAddress.Size = New System.Drawing.Size(301, 20)
        Me.txtOutletAddress.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(35, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(33, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Location"
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.CadetBlue
        Me.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddNew.Location = New System.Drawing.Point(252, 407)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(85, 30)
        Me.btnAddNew.TabIndex = 17
        Me.btnAddNew.Text = "Add"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Add New Outlet"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(348, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmAddNewOutlet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(379, 507)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBorderBottom)
        Me.Controls.Add(Me.pnlBorderTop)
        Me.Controls.Add(Me.pnlBorderLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(198, 470)
        Me.Name = "frmAddNewOutlet"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDepositRemark As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSecurityDeposit As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFranchiseRemark As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFranchiseeFee As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPackageRemark As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPackageFee As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbPackageType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateOpened As DateTimePicker
    Friend WithEvents txtOutletAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents txtLocationName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDateOfRefund As DateTimePicker
    Friend WithEvents lblOutletID As Label
    Friend WithEvents lblOutlet As Label
    Friend WithEvents btnAddNew As Button
End Class
