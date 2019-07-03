Imports System.Data.SqlClient

Public Class clsFranchisee
    Public idFranchisee As Integer
    Public unFranchisee As Integer
    Public FName As String
    Public LName As String
    Public MName As String
    Public Status As Integer
    'Public TotalActive As Integer
    'Public TotalTempCLosed As Integer
    'Public TotalPermClosed As Integer
    Public OwnershipType As String
    Public CorpAuthorizedName As String
    Public YearStarted As String
    Public Address1 As String
    Public Address2 As String
    Public TinNumber As String
    Public DateOfBirth As DateTime
    Public Age As Integer
    Public Gender As String
    Public CivilStatus As String
    Public Nationality As String
    Public Religion As String
    Public Occupation As String
    Public MobileNumber1 As String
    Public MobileNumber2 As String
    Public TelNumber1 As String
    Public TelNumber2 As String
    Public FaxNumber As String
    Public EmailAdd1 As String
    Public EmailAdd2 As String
    'Public Image As Byte
    'Public idOutlet As Integer



    Public Function addFranchisee() As Boolean

        Dim sQuery As String = "INSERT INTO Franchisee(FPFName ,FPFLName, FPFMName, FPFStatus, FPFOwnershipType, FPFCorpAuthorizedName, FPFYearStarted,
                                                        FPFAddress1, FPFAddress2, FPFTinNumber, FPFDateOfBirth ,FPFAge, FPFGender, FPFCivilStatus, FPFNationality, FPFReligion,
                                                        FPFOccupation, FPFMobileNum1, FPFMobileNum2, FPFTelNum1, FPFTelNum2, FPFFaxNum, FPFEmailAdd1, FPFEmailAdd2)

                                Values(@FPFName,@FPFLName,@FPFMName,@FPFStatus,@FPFOwnershipType,@FPFCorpAuthorizedName,@FPFYearStarted,
                                        @FPFAddress1,@FPFAddress2,@FPFTinNumber,@FPFDateOfBirth,@FPFAge,@FPFGender,@FPFCivilStatus,@FPFNationality,@FPFReligion,@FPFOccupation,@FPFMobileNum1,
                                        @FPFMobileNum2,@FPFTelNum1,@FPFTelNum2,@FPFFaxNum,@FPFEmailAdd1,@FPFEmailAdd2)"

        ',FPFImage,FPFTotalActive,FPFTotalTempClosed,FPFTotalPermClosed,idOutlet



        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPFName", Me.FName)
                    oCommand.Parameters.AddWithValue("@FPFLName", Me.LName)
                    oCommand.Parameters.AddWithValue("@FPFMName", Me.MName)
                    oCommand.Parameters.AddWithValue("@FPFStatus", Me.Status)
                    'oCommand.Parameters.AddWithValue("@FPFTotalActive", Me.TotalActive)
                    'oCommand.Parameters.AddWithValue("@FPFTotalTempClosed", Me.TotalTempCLosed)
                    'oCommand.Parameters.AddWithValue("@FPFTotalPermClosed", Me.TotalPermClosed)
                    oCommand.Parameters.AddWithValue("@FPFOwnershipType", Me.OwnershipType)
                    oCommand.Parameters.AddWithValue("@FPFCorpAuthorizedName", Me.CorpAuthorizedName)
                    oCommand.Parameters.AddWithValue("@FPFYearStarted", Me.YearStarted)
                    oCommand.Parameters.AddWithValue("@FPFAddress1", Me.Address1)
                    oCommand.Parameters.AddWithValue("@FPFAddress2", Me.Address2)
                    oCommand.Parameters.AddWithValue("@FPFTinNumber", Me.TinNumber)
                    oCommand.Parameters.AddWithValue("@FPFDateOfBirth", Me.DateOfBirth)
                    oCommand.Parameters.AddWithValue("@FPFAge", Me.Age)
                    oCommand.Parameters.AddWithValue("@FPFGender", Me.Gender)
                    oCommand.Parameters.AddWithValue("@FPFCivilStatus", Me.CivilStatus)
                    oCommand.Parameters.AddWithValue("@FPFNationality", Me.Nationality)
                    oCommand.Parameters.AddWithValue("@FPFReligion", Me.Religion)
                    oCommand.Parameters.AddWithValue("@FPFOccupation", Me.Occupation)
                    oCommand.Parameters.AddWithValue("@FPFMobileNum1", Me.MobileNumber1)
                    oCommand.Parameters.AddWithValue("@FPFMobileNum2", Me.MobileNumber2)
                    oCommand.Parameters.AddWithValue("@FPFTelNum1", Me.TelNumber1)
                    oCommand.Parameters.AddWithValue("@FPFTelNum2", Me.TelNumber2)
                    oCommand.Parameters.AddWithValue("@FPFFaxNum", Me.FaxNumber)
                    oCommand.Parameters.AddWithValue("@FPFEmailAdd1", Me.EmailAdd1)
                    oCommand.Parameters.AddWithValue("@FPFEmailAdd2", Me.EmailAdd2)
                    'oCommand.Parameters.AddWithValue("@FPFImage", Me.Image)
                    'oCommand.Parameters.AddWithValue("@idOutlet",)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function


End Class
