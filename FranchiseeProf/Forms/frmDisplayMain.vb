Imports System.Data.SqlClient

Public Class pnlMain

    Public Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modProfiling.loadFranchisee()

        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size

        Dim List As List(Of clsFranchisee) = modProfiling.getFranchisee
        Dim autoComp As AutoCompleteStringCollection = New AutoCompleteStringCollection

        For Each item As clsFranchisee In List
            autoComp.Add(item.FName + " " + item.MName + " " + item.LName)
        Next
        txtSearchBar.AutoCompleteCustomSource = autoComp


    End Sub

    Private Sub BtnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmCreateNewFranchisee.ShowDialog()
        modProfiling.loadFranchisee()
        modProfiling.clearTextFranchisee()
    End Sub
    'Dim l As List(Of clsFranchisee)
    Private Sub lvUserProfile_DoubleClick(sender As Object, e As EventArgs) Handles lvUserProfile.DoubleClick
        'Dim idFLV As Integer = lvUserProfile.FocusedItem.Index + 1
        pnlInfo.Show()
        modProfiling.displayInfoFranchisee()
        modProfiling.getInfo()
        modProfiling.recolorListView(lvUserProfile)
    End Sub

    Private Sub BtnSelectedOutlet_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        frmUpdateFranchiseeProfile.ShowDialog()
        'modProfiling.getFranchiseeInfoText()
    End Sub

    Private Sub BtnAddNewOutletMain_Click_1(sender As Object, e As EventArgs) Handles btnAddNewOutletMain.Click
        If cbBusinessUnit.Text = " " Then
            MsgBox("Business unit cannot be empty!")
        Else
            Dim ao As clsOutlet = New clsOutlet
            ao.FPOBusinessUnit = cbBusinessUnit.Text
            ao.unFranchisee = lblIDFranchisee.Text
            If ao.addOutlet() Then
                frmAddNewOutlet.lblOutletID.Text = modProfiling.getLatestOId()
                'modProfiling.displayInfo()
                frmAddNewOutlet.ShowDialog()
            End If
        End If
        modProfiling.clearTextOutlet()
        frmAddNewOutlet.cbPackageType.Text = " "
    End Sub

    Private Sub BtnEditOutlet_Click(sender As Object, e As EventArgs) Handles btnEditOutlet.Click
        displayInfoOutletLocation()

    End Sub

    Private Sub BtnViewOutlet_Click(sender As Object, e As EventArgs) Handles btnViewOutlet.Click
        frmOutletDetails.ShowDialog()
        'modProfiling.getOId()
    End Sub

    Private Sub BtnConfirmOutlet_Click(sender As Object, e As EventArgs) Handles btnConfirmOutlet.Click
        cbBusinessUnit.Text = " "
        Dim unF As Integer = lblIDFranchisee.Text
        MsgBox("Outlet added successfully")
        modProfiling.loadOutletLocation(unF)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class