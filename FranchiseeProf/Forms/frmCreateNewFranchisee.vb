Imports System.Data.SqlClient

Public Class frmCreateNewFranchisee
    Public Function browseImage()

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                Dim OFD As FileDialog = New OpenFileDialog()

                OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

                If OFD.ShowDialog() = DialogResult.OK Then
                    Dim imgpath As String = OFD.FileName
                    pbFranchisee.ImageLocation = imgpath

                End If

                OFD = Nothing

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End Using
        Return False
    End Function
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmCreateNewFranchisee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim afs As clsFranchisee = New clsFranchisee

        afs.FName = txtFName.Text
        afs.LName = txtLName.Text
        afs.MName = txtMName.Text
        afs.Status = activeStatus
        afs.OwnershipType = cbOwnershipType.Text
        afs.CorpAuthorizedName = txtCorpAuthorizedName.Text
        afs.YearStarted = txtYearStarted.Text
        afs.Address1 = txtAddress1.Text
        afs.Address2 = txtAddress2.Text
        afs.TinNumber = txtTinNumber.Text
        afs.DateOfBirth = dtpDateOfBirth.Value.Date
        afs.Age = txtAge.Text
        afs.Gender = cbGender.Text
        afs.CivilStatus = cbCivilStatus.Text
        afs.Nationality = txtNationality.Text
        afs.Religion = txtReligion.Text
        afs.Occupation = txtOccupation.Text
        afs.MobileNumber1 = txtMobileNum1.Text
        afs.MobileNumber2 = txtMobileNum2.Text
        afs.TelNumber1 = txtTelNum1.Text
        afs.TelNumber2 = txtTelNum2.Text
        afs.FaxNumber = txtFaxNumber.Text
        afs.EmailAdd1 = txtEmailAddress1.Text
        afs.EmailAdd2 = txtEmailAddress2.Text

        If afs.addFranchisee() Then
            MsgBox("Added Successfully")
            Me.Close()
        End If

    End Sub

    Dim activeStatus As Integer
    Private Sub cbFPFStatus_CheckedChanged(sender As Object, e As EventArgs) Handles cbFPFStatus.CheckedChanged
        If cbFPFStatus.Checked Then
            activeStatus = 1
        Else
            activeStatus = 0
        End If
    End Sub

    Private Sub cbOwnershipType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOwnershipType.SelectedIndexChanged
        Dim cbOwnershipValue As String = cbOwnershipType.Text

        If cbOwnershipValue = "Corporation" Then
            txtCorpAuthorizedName.Visible = True
            txtYearStarted.Visible = True
            lblIfCorp.Visible = True
            lblYearStart.Visible = True
        Else
            txtCorpAuthorizedName.Visible = False
            txtYearStarted.Visible = False
            lblIfCorp.Visible = False
            lblYearStart.Visible = False
        End If
    End Sub

    Private Sub PbFranchisee_Click(sender As Object, e As EventArgs) Handles pbFranchisee.Click
        browseImage()
    End Sub
End Class
