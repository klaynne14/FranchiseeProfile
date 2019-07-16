Public Class frmUpdateFranchiseeProfile
    Private Sub FrmUpdateFranchiseeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        modProfiling.getInfo()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class