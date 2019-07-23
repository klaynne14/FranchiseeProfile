Public Class frmUpdateOutletDetails

    Private Sub frmUpdateOutletDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        modProfiling.getfocusedOId(lblOutletUn)

    End Sub

    Dim lDateClosed As DateTime
    Dim lStatus As String
    Dim lStatusClosed As String
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
            lStatusClosed = cbStatusClosed.Text
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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateOutletDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateOutletDetails.Click
        Dim unO As Integer = lblOutletUn.Text
        Dim unF As Integer = pnlMain.lblIDFranchisee.Text


        modProfiling.updateInfoLocation(unO, lStatus)
        modProfiling.loadOutletLocation(unF)
        Me.Close()
    End Sub
End Class