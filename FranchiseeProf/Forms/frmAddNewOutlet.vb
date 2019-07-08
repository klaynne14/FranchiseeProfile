Imports System.Data.SqlClient

Public Class frmAddNewOutlet
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewOutlet_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
    End Sub

    Dim idF As New pnlMain
    Dim id As String = idF.lblIDFranchisee.Text
    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        'If lStatusClosed = "Relocated" Then

        'End If

        Dim ao As clsOutlet = New clsOutlet
        ao.FPOBusinessUnit = cbBusinessUnit.Text
        ao.idPackage = 1
        ao.idContract = 1
        ao.idLocation = 1
        ao.idFranchisee = 0
        'pass ids from forms

        Dim al As clsLocation = New clsLocation
        al.FPLLocationName = txtLocationName.Text
        al.FPLCurrentAddress = txtOutletAddress.Text
        al.FPLOldAddress = ""
        al.FPLDateOpened = dtpDateOpened.Value.Date
        'al.FPLDateClosed = lDateClosed
        'al.FPLStatus = lStatus
        'al.FPLStatusClosed = cbOutletClosedStatus.Text

        Dim ap As clsPackage = New clsPackage
        ap.FPPPackageType = cbPackageType.Text
        ap.FPPFranchiseFee = Convert.ToInt32(txtFranchiseeFee.Text)
        ap.FPPPackageFee = Convert.ToInt32(txtPackageFee.Text)
        ap.FPPSecurityDeposit = Convert.ToInt32(txtSecurityDeposit.Text)
        ap.FPPDateOfRefund = dtpDateOfRefund.Value.Date
        ap.FPPFranchiseRemark = txtFranchiseRemark.Text
        ap.FPPPackageRemark = txtPackageRemark.Text
        ap.FPPDepositRemark = txtDepositRemark.Text

        If ao.addOutlet() And al.addLocation() And ap.addPackage() Then
            MsgBox("Outlet added successfully")
            Me.Close()
        End If

    End Sub

End Class