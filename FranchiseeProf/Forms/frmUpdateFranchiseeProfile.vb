Public Class frmUpdateFranchiseeProfile
    Private Sub FrmUpdateFranchiseeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        modProfiling.getInfo()
        Me.lblUnFranchisee.Text = pnlMain.lblIDFranchisee.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim pnl As New pnlMain
        Dim unF As Integer = Me.lblUnFranchisee.Text
        If modProfiling.updateFranchisee(unF) Then
            modProfiling.updateFranchisee(unF)
            MsgBox("Updated Successfully")
            Me.Close()
            modProfiling.displayInfoFranchisee()
            pnl.Main_Load(Me, New System.EventArgs)
            'pnl.pnlInfo.Refresh()
        End If
    End Sub
End Class