Public Class frmAddContract
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
    End Sub

    'Dim lStatus As String
    Dim lDateClosed As DateTime
    Dim lStatus As String = "Open"

    Private Sub CbOutletStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbOutletStatus.CheckedChanged
        If cbOutletStatus.Checked = True Then
            lblOutletClosedDate.Visible = False
            lblOutletClosedStatus.Visible = False
            cbOutletClosedStatus.Visible = False
            dtpDateClosed.Visible = False
            txtRelocAddress.Visible = False
            lblRelocAddress.Visible = False

            lStatus = "Open"
        Else
            lblOutletClosedDate.Visible = True
            lblOutletClosedStatus.Visible = True
            cbOutletClosedStatus.Visible = True
            dtpDateClosed.Visible = True

            lStatus = "Close"
            lDateClosed = dtpDateClosed.Value.Date
        End If
    End Sub

    Private Sub CbOutletClosedStatus_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbOutletClosedStatus.SelectedIndexChanged
        Dim lStatusClosed As String = cbOutletClosedStatus.Text
        If lStatusClosed = "Relocated" Then
            lblRelocAddress.Visible = True
            txtRelocAddress.Visible = True
        Else
            lblRelocAddress.Visible = False
            txtRelocAddress.Visible = False
        End If
    End Sub
End Class