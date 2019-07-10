Imports System.Data.SqlClient

Public Class pnlMain

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modProfiling.loadFranchisee()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size

        Dim List As List(Of clsFranchisee) = modProfiling.getFranchisee
        Dim autoComp As AutoCompleteStringCollection = New AutoCompleteStringCollection

        For Each item As clsFranchisee In List
            autoComp.Add(item.FName + item.MName + item.LName)
        Next
        txtSearchBar.AutoCompleteCustomSource = autoComp
    End Sub

    Private Sub BtnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmCreateNewFranchisee.ShowDialog()
        modProfiling.loadFranchisee()
        modProfiling.clearText1()
    End Sub

    Private Sub BtnAddNewOutletMain_Click(sender As Object, e As EventArgs) Handles btnAddNewOutletMain.Click
        frmAddNewOutlet.lblOutletUn.Text = lblIDFranchisee.Text
        frmAddNewOutlet.ShowDialog()
        modProfiling.clearText()
        frmAddNewOutlet.cbBusinessUnit.Text = " "
        frmAddNewOutlet.cbPackageType.Text = " "
    End Sub

    'Dim l As List(Of clsFranchisee)
    Private Sub lvUserProfile_DoubleClick(sender As Object, e As EventArgs) Handles lvUserProfile.DoubleClick
        pnlInfo.Show()
        modProfiling.displayInfo()
    End Sub

    Private Sub BtnSelectedOutlet_Click(sender As Object, e As EventArgs) Handles btnSelectedOutlet.Click
        frmAddContract.ShowDialog()
    End Sub
End Class