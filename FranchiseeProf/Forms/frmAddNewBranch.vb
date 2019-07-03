Public Class frmAddNewOutlet
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddNewOutlet_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()

    End Sub

    Private Sub CbClosedStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbOutletStatus.CheckedChanged
        If cbOutletStatus.Checked Then
            lblOutletClosedDate.Visible = True
            lblOutletClosedStatus.Visible = True
            cbOutletClosedStatus.Visible = True
            dtpOutletClosedDate.Visible = True
        Else
            lblOutletClosedDate.Visible = False
            lblOutletClosedStatus.Visible = False
            cbOutletClosedStatus.Visible = False
            dtpOutletClosedDate.Visible = False
        End If

    End Sub

End Class