<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePackage
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
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDateOfRefund = New System.Windows.Forms.DateTimePicker()
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
        Me.btnUpdatePackage = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblOutletID)
        Me.Panel1.Controls.Add(Me.lblOutlet)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpDateOfRefund)
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
        Me.Panel1.Controls.Add(Me.btnUpdatePackage)
        Me.Panel1.Location = New System.Drawing.Point(6, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 356)
        Me.Panel1.TabIndex = 4
        '
        'lblOutletID
        '
        Me.lblOutletID.AutoSize = True
        Me.lblOutletID.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletID.Location = New System.Drawing.Point(82, 23)
        Me.lblOutletID.Name = "lblOutletID"
        Me.lblOutletID.Size = New System.Drawing.Size(55, 13)
        Me.lblOutletID.TabIndex = 55
        Me.lblOutletID.Text = "unOutlet"
        '
        'lblOutlet
        '
        Me.lblOutlet.AutoSize = True
        Me.lblOutlet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutlet.Location = New System.Drawing.Point(18, 23)
        Me.lblOutlet.Name = "lblOutlet"
        Me.lblOutlet.Size = New System.Drawing.Size(68, 13)
        Me.lblOutlet.TabIndex = 54
        Me.lblOutlet.Text = "Outlet ID: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(160, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Date of Refund"
        '
        'dtpDateOfRefund
        '
        Me.dtpDateOfRefund.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateOfRefund.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfRefund.Location = New System.Drawing.Point(163, 240)
        Me.dtpDateOfRefund.Name = "dtpDateOfRefund"
        Me.dtpDateOfRefund.Size = New System.Drawing.Size(90, 20)
        Me.dtpDateOfRefund.TabIndex = 8
        '
        'txtDepositRemark
        '
        Me.txtDepositRemark.Location = New System.Drawing.Point(163, 196)
        Me.txtDepositRemark.Name = "txtDepositRemark"
        Me.txtDepositRemark.Size = New System.Drawing.Size(169, 20)
        Me.txtDepositRemark.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(161, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Remarks"
        '
        'txtSecurityDeposit
        '
        Me.txtSecurityDeposit.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSecurityDeposit.Location = New System.Drawing.Point(31, 196)
        Me.txtSecurityDeposit.Name = "txtSecurityDeposit"
        Me.txtSecurityDeposit.Size = New System.Drawing.Size(126, 20)
        Me.txtSecurityDeposit.TabIndex = 6
        Me.txtSecurityDeposit.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(30, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Security Deposit"
        '
        'txtFranchiseRemark
        '
        Me.txtFranchiseRemark.Location = New System.Drawing.Point(164, 151)
        Me.txtFranchiseRemark.Name = "txtFranchiseRemark"
        Me.txtFranchiseRemark.Size = New System.Drawing.Size(169, 20)
        Me.txtFranchiseRemark.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(161, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Remarks"
        '
        'txtFranchiseeFee
        '
        Me.txtFranchiseeFee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFranchiseeFee.Location = New System.Drawing.Point(32, 151)
        Me.txtFranchiseeFee.Name = "txtFranchiseeFee"
        Me.txtFranchiseeFee.Size = New System.Drawing.Size(126, 20)
        Me.txtFranchiseeFee.TabIndex = 4
        Me.txtFranchiseeFee.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(32, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Franchise fee"
        '
        'txtPackageRemark
        '
        Me.txtPackageRemark.Location = New System.Drawing.Point(164, 105)
        Me.txtPackageRemark.Name = "txtPackageRemark"
        Me.txtPackageRemark.Size = New System.Drawing.Size(169, 20)
        Me.txtPackageRemark.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(161, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Remarks"
        '
        'txtPackageFee
        '
        Me.txtPackageFee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPackageFee.Location = New System.Drawing.Point(32, 105)
        Me.txtPackageFee.Name = "txtPackageFee"
        Me.txtPackageFee.Size = New System.Drawing.Size(126, 20)
        Me.txtPackageFee.TabIndex = 2
        Me.txtPackageFee.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(32, 128)
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
        Me.Label9.Location = New System.Drawing.Point(29, 83)
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
        Me.cbPackageType.Location = New System.Drawing.Point(33, 59)
        Me.cbPackageType.Name = "cbPackageType"
        Me.cbPackageType.Size = New System.Drawing.Size(125, 21)
        Me.cbPackageType.TabIndex = 1
        '
        'btnUpdatePackage
        '
        Me.btnUpdatePackage.BackColor = System.Drawing.Color.CadetBlue
        Me.btnUpdatePackage.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.btnUpdatePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePackage.ForeColor = System.Drawing.SystemColors.Window
        Me.btnUpdatePackage.Location = New System.Drawing.Point(248, 301)
        Me.btnUpdatePackage.Name = "btnUpdatePackage"
        Me.btnUpdatePackage.Size = New System.Drawing.Size(85, 30)
        Me.btnUpdatePackage.TabIndex = 17
        Me.btnUpdatePackage.Text = "Update"
        Me.btnUpdatePackage.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(11, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Update Package"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(348, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmUpdatePackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(379, 400)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdatePackage"
        Me.Text = "frmUpdatePackage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblOutletID As Label
    Friend WithEvents lblOutlet As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDateOfRefund As DateTimePicker
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
    Friend WithEvents btnUpdatePackage As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
End Class
