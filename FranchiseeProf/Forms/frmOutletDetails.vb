Public Class frmOutletDetails
    Private Sub frmAddContract_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        modProfiling.getfocusedOId(lblOutletID)

        Dim unO As Integer = lblOutletID.Text
        modProfiling.displayContract(unO)
        modProfiling.displayInfoPackage(unO)

    End Sub
    Private Sub BtnAddContract_Click(sender As Object, e As EventArgs) Handles btnAddContract.Click
        Dim ac As clsContract = New clsContract

        ac.FPCStartTerm = dtpStartTerm.Value.Date
        ac.FPCEndTerm = dtpEndTerm.Value.Date
        ac.FPCRemark = txtRemarks.Text
        ac.unOutlet = lblOutletID.Text
        If ac.addContract() Then
            'modProfiling.getLatestCId()
            'MessageBox.Show(modProfiling.getLatestCId().ToString)
            Dim unO As Integer = ac.unOutlet
            modProfiling.displayContract(unO)

            clearText()
        End If
    End Sub

    Public Function clearText()
        txtRemarks.Text = " "
    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



End Class