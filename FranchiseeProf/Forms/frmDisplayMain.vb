Public Class pnlMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub BtnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmCreateNewFranchisee.Show()

    End Sub

    Private Sub BtnAddNewFranchisee_Click(sender As Object, e As EventArgs) Handles btnAddNewFranchisee.Click
        frmAddNewOutlet.Show()

    End Sub
End Class