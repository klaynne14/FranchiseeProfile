Imports System.Data.SqlClient

Public Class frmAddNewOutlet
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewOutlet_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()

    End Sub

    Dim lStatus As String
    Private Sub CbClosedStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbOutletStatus.CheckedChanged
        If cbOutletStatus.Checked Then
            lblOutletClosedDate.Visible = True
            lblOutletClosedStatus.Visible = True
            cbOutletClosedStatus.Visible = True
            dtpDateClosed.Visible = True

            lStatus = "Close"
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

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        'If lStatusClosed = "Relocated" Then

        'End If

        Dim ao As clsOutlet = New clsOutlet
        ao.FPOBusinessUnit = cbBusinessUnit.Text
        ao.idPackage = 1
        ao.idContract = 1
        ao.idLocation = 1
        'pass ids from forms

        Dim al As clsLocation = New clsLocation
        al.FPLLocationName = txtLocationName.Text
        al.FPLCurrentAddress = txtOutletAddress.Text
        al.FPLOldAddress = ""
        al.FPLDateOpened = dtpDateOpened.Value.Date
        al.FPLDateClosed = cbOutletClosedStatus.Text
        al.FPLStatus = lStatus
        al.FPLStatusClosed = cbOutletClosedStatus.Text

        If ao.addOutlet() And al.addLocation() Then
            Me.Close()
        End If
    End Sub

End Class