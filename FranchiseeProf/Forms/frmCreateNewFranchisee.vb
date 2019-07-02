Imports System.Data.SqlClient


Public Class frmCreateNewFranchisee

    Dim afs As clsFranchisee = New clsFranchisee

    Public Function addFranchisee() As Boolean

        Dim sQuery As String = "Insert Into Franchisee(FPFName,FPFLName,FPFMName,FPFStatus,FPFTotalActive,FPFTotalTempClosed,FPFTotalPermClosed,FPFOwnershipType,FPFCorpAuthorizedName,FPFYearStarted,
                                                        FPFAddress1,FPFAddress2,FPFTinNumber,FPFAge,FPFGender,FPFCivilStatus,FPFNationality,FPFReligion,FPFOccupation,FPFMobileNum1,
                                                        FPFMobileNum2,FPFTelNum1,FPFTelNum2,FPFFaxNum,FPFEmailAdd1,FPFEmailAdd2,idOutlet,FPFImage)
                                Values(@FPFName,@FPFLName,@FPFMName,@FPFStatus,@FPFTotalActive,@FPFTotalTempClosed,@FPFTotalPermClosed,@FPFOwnershipType,@FPFCorpAuthorizedName,@FPFYearStarted,
                                        @FPFAddress1,@FPFAddress2,@FPFTinNumber,@FPFAge,@FPFGender,@FPFCivilStatus,@FPFNationality,@FPFReligion,@FPFOccupation,@FPFMobileNum1,
                                        @FPFMobileNum2,@FPFTelNum1,@FPFTelNum2,@FPFFaxNum,@FPFEmailAdd1,@FPFEmailAdd2,@idOutlet,@FPFImage)"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPFName", afs.FName)
                    oCommand.Parameters.AddWithValue("@FPLName", afs.LName)
                    oCommand.Parameters.AddWithValue("@FPFMName", afs.MName)
                    oCommand.Parameters.AddWithValue("@FPFStatus", afs.Status)
                    oCommand.Parameters.AddWithValue("@FPFTotalActive", afs.TotalActive)
                    oCommand.Parameters.AddWithValue("@FPFTotalTempClosed", afs.TotalTempCLosed)
                    oCommand.Parameters.AddWithValue("@FPFTotalPermClosed", afs.TotalPermClosed)
                    oCommand.Parameters.AddWithValue("@FPFOwnershipType", afs.OwnershipType)
                    oCommand.Parameters.AddWithValue("@FPFCorpAuthorizedName", afs.CorpAuthorizedName)
                    oCommand.Parameters.AddWithValue("@FPFYearStarted", afs.YearStarted)
                    oCommand.Parameters.AddWithValue("@FPFAddress1", afs.Address1)
                    oCommand.Parameters.AddWithValue("@FPFAddress2", afs.Address2)
                    oCommand.Parameters.AddWithValue("@FPFTinNumber", afs.TinNumber)
                    'oCommand.Parameters.AddWithValue("@FPFDateOfBirth", afs.DateOfBirth)
                    oCommand.Parameters.AddWithValue("@FPFAge", afs.Age)
                    oCommand.Parameters.AddWithValue("@FPFGender", afs.Gender)
                    oCommand.Parameters.AddWithValue("@FPFCivilStatus", afs.CivilStatus)
                    oCommand.Parameters.AddWithValue("@FPFNationality", afs.Nationality)
                    oCommand.Parameters.AddWithValue("@FPFReligion", afs.Religion)
                    oCommand.Parameters.AddWithValue("@FPFOccupation", afs.Occupation)
                    oCommand.Parameters.AddWithValue("@FPFMobileNum1", afs.MobileNumber1)
                    oCommand.Parameters.AddWithValue("@FPFMobileNum2", afs.MobileNumber2)
                    oCommand.Parameters.AddWithValue("@FPFTelNum1", afs.TelNumber1)
                    oCommand.Parameters.AddWithValue("@FPFTelNum2", afs.TelNumber2)
                    oCommand.Parameters.AddWithValue("@FPFFaxNum", afs.FaxNumber)
                    oCommand.Parameters.AddWithValue("@FPFEmailAdd1", afs.EmailAdd1)
                    oCommand.Parameters.AddWithValue("@FPFEmailAdd2", afs.EmailAdd2)
                    oCommand.Parameters.AddWithValue("@FPFImage", afs.Image)
                    oCommand.Parameters.AddWithValue("@idOutlet", afs.LName)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("ERROR @addFranchisee" + ex.Message)
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
        afs.FName = txtFName.Text
        'afs.DateOfBirth = dtpDateOfBirth.Value
        If addFranchisee() Then
            Me.Close()
        End If
    End Sub
End Class
