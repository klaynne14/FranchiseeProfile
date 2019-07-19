Imports System.Data.SqlClient

Public Class frmUpdateFranchiseeProfile
    Public Function browseImage()

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                Dim OFD As FileDialog = New OpenFileDialog()

                OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

                If OFD.ShowDialog() = DialogResult.OK Then
                    Dim imgpath As String = OFD.FileName
                    pbUserPhoto.ImageLocation = imgpath

                End If

                OFD = Nothing

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End Using
        Return False
    End Function
    Private Sub FrmUpdateFranchiseeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        modProfiling.getInfo()
        Me.lblUnFranchisee.Text = pnlMain.lblIDFranchisee.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim statState As Integer
    Private Sub cbFPFStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbFPFStatus.CheckedChanged

        If cbFPFStatus.Checked = True Then
            statState = 1
        ElseIf cbFPFStatus.Checked = False Then
            statState = 0
        End If


    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim pnl As New pnlMain
        Dim unF As Integer = Me.lblUnFranchisee.Text
        If modProfiling.updateFranchisee(unF, statState) Then
            'modProfiling.updateFranchisee(unF, statState)
            MsgBox("Updated Successfully")
            Me.Close()
            modProfiling.displayInfoFranchisee()
            pnl.Main_Load(Me, New System.EventArgs)
            'pnl.pnlInfo.Refresh()
        End If
    End Sub


    Private Sub LnkChangePicture_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkChangePicture.LinkClicked
        browseImage()
    End Sub



End Class