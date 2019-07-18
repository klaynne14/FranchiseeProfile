<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateOutletDetails
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
        Me.txtRelocationAddress = New System.Windows.Forms.TextBox()
        Me.lblRelocationAddress = New System.Windows.Forms.Label()
        Me.lblStatusClosed = New System.Windows.Forms.Label()
        Me.cbStatusClosed = New System.Windows.Forms.ComboBox()
        Me.dtpCloseDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCloseDate = New System.Windows.Forms.Label()
        Me.cbStatusOutlet = New System.Windows.Forms.CheckBox()
        Me.lblOutletUn = New System.Windows.Forms.Label()
        Me.lblOutlet = New System.Windows.Forms.Label()
        Me.txtLocationName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateOpened = New System.Windows.Forms.DateTimePicker()
        Me.txtOutletAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdateOutletDetails = New System.Windows.Forms.Button()
        Me.cbBusinessUnit = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.txtRelocationAddress)
        Me.Panel1.Controls.Add(Me.lblRelocationAddress)
        Me.Panel1.Controls.Add(Me.lblStatusClosed)
        Me.Panel1.Controls.Add(Me.cbStatusClosed)
        Me.Panel1.Controls.Add(Me.dtpCloseDate)
        Me.Panel1.Controls.Add(Me.lblCloseDate)
        Me.Panel1.Controls.Add(Me.cbStatusOutlet)
        Me.Panel1.Controls.Add(Me.lblOutletUn)
        Me.Panel1.Controls.Add(Me.lblOutlet)
        Me.Panel1.Controls.Add(Me.txtLocationName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpDateOpened)
        Me.Panel1.Controls.Add(Me.txtOutletAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnUpdateOutletDetails)
        Me.Panel1.Controls.Add(Me.cbBusinessUnit)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 242)
        Me.Panel1.TabIndex = 4
        '
        'txtRelocationAddress
        '
        Me.txtRelocationAddress.Location = New System.Drawing.Point(212, 147)
        Me.txtRelocationAddress.Name = "txtRelocationAddress"
        Me.txtRelocationAddress.Size = New System.Drawing.Size(218, 20)
        Me.txtRelocationAddress.TabIndex = 62
        '
        'lblRelocationAddress
        '
        Me.lblRelocationAddress.AutoSize = True
        Me.lblRelocationAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRelocationAddress.Location = New System.Drawing.Point(209, 170)
        Me.lblRelocationAddress.Name = "lblRelocationAddress"
        Me.lblRelocationAddress.Size = New System.Drawing.Size(99, 13)
        Me.lblRelocationAddress.TabIndex = 61
        Me.lblRelocationAddress.Text = "Relocation Address"
        '
        'lblStatusClosed
        '
        Me.lblStatusClosed.AutoSize = True
        Me.lblStatusClosed.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStatusClosed.Location = New System.Drawing.Point(29, 170)
        Me.lblStatusClosed.Name = "lblStatusClosed"
        Me.lblStatusClosed.Size = New System.Drawing.Size(72, 13)
        Me.lblStatusClosed.TabIndex = 60
        Me.lblStatusClosed.Text = "Closed Status"
        '
        'cbStatusClosed
        '
        Me.cbStatusClosed.FormattingEnabled = True
        Me.cbStatusClosed.Items.AddRange(New Object() {"Temporary", "Permanent", "Relocated"})
        Me.cbStatusClosed.Location = New System.Drawing.Point(32, 146)
        Me.cbStatusClosed.Name = "cbStatusClosed"
        Me.cbStatusClosed.Size = New System.Drawing.Size(83, 21)
        Me.cbStatusClosed.TabIndex = 59
        '
        'dtpCloseDate
        '
        Me.dtpCloseDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpCloseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCloseDate.Location = New System.Drawing.Point(121, 147)
        Me.dtpCloseDate.Name = "dtpCloseDate"
        Me.dtpCloseDate.Size = New System.Drawing.Size(84, 20)
        Me.dtpCloseDate.TabIndex = 58
        '
        'lblCloseDate
        '
        Me.lblCloseDate.AutoSize = True
        Me.lblCloseDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCloseDate.Location = New System.Drawing.Point(118, 170)
        Me.lblCloseDate.Name = "lblCloseDate"
        Me.lblCloseDate.Size = New System.Drawing.Size(65, 13)
        Me.lblCloseDate.TabIndex = 57
        Me.lblCloseDate.Text = "Date Closed"
        '
        'cbStatusOutlet
        '
        Me.cbStatusOutlet.AutoSize = True
        Me.cbStatusOutlet.Checked = True
        Me.cbStatusOutlet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusOutlet.Location = New System.Drawing.Point(378, 20)
        Me.cbStatusOutlet.Name = "cbStatusOutlet"
        Me.cbStatusOutlet.Size = New System.Drawing.Size(52, 17)
        Me.cbStatusOutlet.TabIndex = 56
        Me.cbStatusOutlet.Text = "Open"
        Me.cbStatusOutlet.UseVisualStyleBackColor = True
        '
        'lblOutletUn
        '
        Me.lblOutletUn.AutoSize = True
        Me.lblOutletUn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutletUn.Location = New System.Drawing.Point(98, 20)
        Me.lblOutletUn.Name = "lblOutletUn"
        Me.lblOutletUn.Size = New System.Drawing.Size(55, 13)
        Me.lblOutletUn.TabIndex = 55
        Me.lblOutletUn.Text = "unOutlet"
        '
        'lblOutlet
        '
        Me.lblOutlet.AutoSize = True
        Me.lblOutlet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutlet.Location = New System.Drawing.Point(29, 20)
        Me.lblOutlet.Name = "lblOutlet"
        Me.lblOutlet.Size = New System.Drawing.Size(68, 13)
        Me.lblOutlet.TabIndex = 54
        Me.lblOutlet.Text = "Outlet ID: "
        '
        'txtLocationName
        '
        Me.txtLocationName.Location = New System.Drawing.Point(163, 53)
        Me.txtLocationName.Name = "txtLocationName"
        Me.txtLocationName.Size = New System.Drawing.Size(169, 20)
        Me.txtLocationName.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(335, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Date Opened"
        '
        'dtpDateOpened
        '
        Me.dtpDateOpened.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateOpened.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOpened.Location = New System.Drawing.Point(338, 53)
        Me.dtpDateOpened.Name = "dtpDateOpened"
        Me.dtpDateOpened.Size = New System.Drawing.Size(92, 20)
        Me.dtpDateOpened.TabIndex = 27
        '
        'txtOutletAddress
        '
        Me.txtOutletAddress.Location = New System.Drawing.Point(32, 99)
        Me.txtOutletAddress.Name = "txtOutletAddress"
        Me.txtOutletAddress.Size = New System.Drawing.Size(398, 20)
        Me.txtOutletAddress.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(28, 122)
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
        Me.Label5.Location = New System.Drawing.Point(160, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(28, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Business Unit"
        '
        'btnUpdateOutletDetails
        '
        Me.btnUpdateOutletDetails.BackColor = System.Drawing.Color.CadetBlue
        Me.btnUpdateOutletDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateOutletDetails.ForeColor = System.Drawing.SystemColors.Window
        Me.btnUpdateOutletDetails.Location = New System.Drawing.Point(344, 197)
        Me.btnUpdateOutletDetails.Name = "btnUpdateOutletDetails"
        Me.btnUpdateOutletDetails.Size = New System.Drawing.Size(86, 24)
        Me.btnUpdateOutletDetails.TabIndex = 17
        Me.btnUpdateOutletDetails.Text = "Update"
        Me.btnUpdateOutletDetails.UseVisualStyleBackColor = False
        '
        'cbBusinessUnit
        '
        Me.cbBusinessUnit.ForeColor = System.Drawing.Color.DimGray
        Me.cbBusinessUnit.FormattingEnabled = True
        Me.cbBusinessUnit.Items.AddRange(New Object() {" ", "Waffle Time", "Coffeebreak"})
        Me.cbBusinessUnit.Location = New System.Drawing.Point(32, 53)
        Me.cbBusinessUnit.Name = "cbBusinessUnit"
        Me.cbBusinessUnit.Size = New System.Drawing.Size(125, 21)
        Me.cbBusinessUnit.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Update Outlet Details"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.CadetBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(439, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmUpdateOutletDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(476, 292)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateOutletDetails"
        Me.Text = "frmUpdateOutletDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblOutletUn As Label
    Friend WithEvents lblOutlet As Label
    Friend WithEvents txtLocationName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateOpened As DateTimePicker
    Friend WithEvents txtOutletAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdateOutletDetails As Button
    Friend WithEvents cbBusinessUnit As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRelocationAddress As TextBox
    Friend WithEvents lblRelocationAddress As Label
    Friend WithEvents lblStatusClosed As Label
    Friend WithEvents cbStatusClosed As ComboBox
    Friend WithEvents dtpCloseDate As DateTimePicker
    Friend WithEvents lblCloseDate As Label
    Friend WithEvents cbStatusOutlet As CheckBox
    Friend WithEvents btnClose As Button
End Class
