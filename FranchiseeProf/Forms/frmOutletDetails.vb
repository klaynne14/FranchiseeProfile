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
        modProfiling.getOId()
    End Sub

    'Dim lStatus As String
    Dim lDateClosed As DateTime
    Dim lStatus As String = "Open"

    Private Sub CbStatusOutlet_CheckedChanged(sender As Object, e As EventArgs) Handles cbStatusOutlet.CheckedChanged
        If cbStatusOutlet.Checked = True Then
            cbStatusClosed.Visible = False
            lblStatusClosed.Visible = False
            dtpCloseDate.Visible = False
            lblCloseDate.Visible = False
            txtRelocationAddress.Visible = False
            lblRelocationAddress.Visible = False

            lStatus = "Open"
        Else
            cbStatusClosed.Visible = True
            lblStatusClosed.Visible = True
            dtpCloseDate.Visible = True
            lblCloseDate.Visible = True

            lStatus = "Close"
            lDateClosed = dtpCloseDate.Value.Date
        End If
    End Sub

    Private Sub CbStatusClosed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatusClosed.SelectedIndexChanged
        Dim lStatusClosed As String = cbStatusClosed.Text
        If lStatusClosed = "Relocated" Then
            txtRelocationAddress.Visible = True
            lblRelocationAddress.Visible = True
        Else
            txtRelocationAddress.Visible = False
            lblRelocationAddress.Visible = False
        End If
    End Sub
End Class