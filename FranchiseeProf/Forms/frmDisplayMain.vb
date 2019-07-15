Imports System.Data.SqlClient

Public Class pnlMain

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnAddNewOutletMain_Click(sender As Object, e As EventArgs) Handles btnAddNewOutletMain.Click
        frmAddNewOutlet.lblOutletUn.Text = lblIDFranchisee.Text
        frmAddNewOutlet.ShowDialog()
        modProfiling.clearTextOutlet()
        frmAddNewOutlet.cbBusinessUnit.Text = " "
        frmAddNewOutlet.cbPackageType.Text = " "
    End Sub

    'Dim l As List(Of clsFranchisee)
    Private Sub lvUserProfile_DoubleClick(sender As Object, e As EventArgs) Handles lvUserProfile.DoubleClick
        'Dim idFLV As Integer = lvUserProfile.FocusedItem.Index + 1
        pnlInfo.Show()
        modProfiling.displayInfo()
    End Sub

    Private Sub BtnSelectedOutlet_Click(sender As Object, e As EventArgs) Handles btnSelectedOutlet.Click
        frmOutletDetails.ShowDialog()
        'modProfiling.getOId()
    End Sub

    Private Sub lvOutlet_DoubleClick(sender As Object, e As EventArgs) Handles lvOutlet.DoubleClick
        frmUpdateOutletDetails.ShowDialog()
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        frmUpdateFranchiseeProfile.ShowDialog()
    End Sub
End Class