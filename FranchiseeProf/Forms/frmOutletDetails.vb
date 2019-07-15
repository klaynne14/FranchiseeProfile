Public Class frmOutletDetails
    Private Sub BtnAddContract_Click(sender As Object, e As EventArgs) Handles btnAddContract.Click
        Dim ac As clsContract = New clsContract

        ac.FPCStartTerm = dtpStartTerm.Value.Date
        ac.FPCEndTerm = dtpEndTerm.Value.Date
        ac.FPCRemark = txtRemarks.Text

        If ac.addContract() Then
            MsgBox("Contract added successfully")
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddContract_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        modProfiling.getfocusedOId(lblOutletID)

    End Sub

End Class