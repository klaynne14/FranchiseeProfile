Public Class frmUpdateFranchiseeProfile
    Private Sub FrmUpdateFranchiseeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Me.txtFName.Text = pnlMain.lblFullName.Text
        'modProfiling.getFranchiseeInfoText()
    End Sub
End Class