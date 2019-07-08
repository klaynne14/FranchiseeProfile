Imports System.Data.SqlClient

Public Class frmAddNewOutlet
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewOutlet_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
    End Sub

    'Dim lStatus As String
    Dim lDateClosed As DateTime
    Dim lStatus As String = "Open"
    Private Sub CbClosedStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbOutletStatus.CheckedChanged
        If cbOutletStatus.Checked Then
            lblOutletClosedDate.Visible = True
            lblOutletClosedStatus.Visible = True
            cbOutletClosedStatus.Visible = True
            dtpDateClosed.Visible = True

            lStatus = "Close"
            lDateClosed = dtpDateClosed.Value.Date
        Else
            lblOutletClosedDate.Visible = False
            lblOutletClosedStatus.Visible = False
            cbOutletClosedStatus.Visible = False
            dtpDateClosed.Visible = False

            lStatus = "Open"

        End If
    End Sub

    Private Sub CbOutletClosedStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOutletClosedStatus.SelectedIndexChanged
        Dim lStatusClosed As String = cbOutletClosedStatus.Text
        If lStatusClosed = "Relocated" Then
            lblRelocAddress.Visible = True
            txtRelocAddress.Visible = True
        Else
            lblRelocAddress.Visible = False
            txtRelocAddress.Visible = False
        End If
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
        al.FPLDateClosed = lDateClosed
        al.FPLStatus = lStatus
        al.FPLStatusClosed = cbOutletClosedStatus.Text

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

        If ao.addOutlet() Then
            MsgBox("Outlet added successfully")
            Me.Close()
        End If
    End Sub

End Class