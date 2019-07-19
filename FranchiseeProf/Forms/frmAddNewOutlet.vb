Imports System.Data.SqlClient

Public Class frmAddNewOutlet

#Region "Package Type"
    Public Enum PackageType
        Customize
        Standard
        School
        Counter
        SchoolCounter
    End Enum

    Public Sub setPackageType(packageState As PackageType)
        Select Case packageState
            Case PackageType.Customize
                txtPackageFee.Text = "50000"
                txtFranchiseeFee.Text = "110000"
                txtSecurityDeposit.Text = "50000"

            Case PackageType.Standard
                txtPackageFee.Text = "50000"
                txtFranchiseeFee.Text = "200000"
                txtSecurityDeposit.Text = "50000"


            Case PackageType.School
                txtPackageFee.Text = "20000"
                txtFranchiseeFee.Text = "80000"
                txtSecurityDeposit.Text = "20000"

            Case PackageType.Counter
                txtPackageFee.Text = "50000"
                txtFranchiseeFee.Text = "0"
                txtSecurityDeposit.Text = "0"

            Case PackageType.SchoolCounter
                txtPackageFee.Text = "20000"
                txtFranchiseeFee.Text = "55000"
                txtSecurityDeposit.Text = "20000"

        End Select
    End Sub
#End Region

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewOutlet_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        'modProfiling.getOId(lblOutletID)
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        Dim unO As Integer = lblOutletID.Text

        Dim al As clsLocation = New clsLocation
        al.FPLLocationName = txtLocationName.Text
        al.FPLCurrentAddress = txtOutletAddress.Text
        al.FPLOldAddress = ""
        al.FPLDateOpened = dtpDateOpened.Value.Date
        al.FPLStatus = "Open"
        al.unOutlet = unO

        Dim ap As clsPackage = New clsPackage
        ap.FPPPackageType = cbPackageType.Text
        ap.FPPFranchiseFee = Convert.ToInt32(txtFranchiseeFee.Text)
        ap.FPPPackageFee = Convert.ToInt32(txtPackageFee.Text)
        ap.FPPSecurityDeposit = Convert.ToInt32(txtSecurityDeposit.Text)
        ap.FPPDateOfRefund = dtpDateOfRefund.Value.Date
        ap.FPPFranchiseRemark = txtFranchiseRemark.Text
        ap.FPPPackageRemark = txtPackageRemark.Text
        ap.FPPDepositRemark = txtDepositRemark.Text
        ap.unOutlet = unO

        If al.addLocation() And ap.addPackage() Then
            MsgBox("Outlet added successfully")
            pnlMain.cbBusinessUnit.Text = " "
            Dim unF As Integer = pnlMain.lblIDFranchisee.Text
            modProfiling.loadOutletLocation(unF)

            Me.Close()
        End If



    End Sub

    Private Sub cbPackageType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPackageType.SelectedIndexChanged
        If cbPackageType.Text = "School" Then
            setPackageType(PackageType.School)
        ElseIf cbPackageType.Text = "Customize" Then
            setPackageType(PackageType.Customize)
        ElseIf cbPackageType.Text = "Standard" Then
            setPackageType(PackageType.Standard)
        ElseIf cbPackageType.Text = "School-Counter" Then
            setPackageType(PackageType.SchoolCounter)
        ElseIf cbPackageType.Text = "Counter" Then
            setPackageType(PackageType.Counter)
        End If
    End Sub
End Class