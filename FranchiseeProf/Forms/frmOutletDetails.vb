Public Class frmOutletDetails

    Private Sub frmAddContract_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        modProfiling.getfocusedOId(lblOutletID)
        Try
            Dim unO As Integer = lblOutletID.Text
            modProfiling.displayContract(unO)
            modProfiling.displayInfoPackage(unO)
        Catch ex As Exception
            Me.Close()
        End Try

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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEditPackage.LinkClicked
        Dim unO As Integer = lblOutletID.Text
        modProfiling.getInfoPackage(unO)
        frmUpdatePackage.ShowDialog()
    End Sub

    Private Sub BtnApply_click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.Close()
    End Sub

    Private Sub lvContract_DoubleClick(sender As Object, e As EventArgs) Handles lvContract.DoubleClick
        Dim unC As Integer = Me.lvContract.FocusedItem.Tag
        modProfiling.displayCon(unC)
        btnAddContract.Hide()
        btnUpdateContact.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdateContact.Click

    End Sub
End Class