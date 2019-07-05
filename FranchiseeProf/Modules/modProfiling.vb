Imports System.Data.SqlClient

Module modProfiling
    Public Function getFranchiseeList() As List(Of clsFranchisee)
        Dim franchiseeList As List(Of clsFranchisee) = New List(Of clsFranchisee)
        Dim franchiseeOutlet As List(Of clsOutlet) = New List(Of clsOutlet)
        Dim fs As New clsFranchisee
        'Dim fsOutlet As New clsOutlet
        Dim fsQuery As String = "Select idFranchisee,FPFName,FPFLName,FPFMName, FPFStatus, FPFOwnershipType, FPFCorpAuthorizedName, FPFYearStarted,
                                    FPFAddress1, FPFAddress2, FPFTinNumber, FPFDateOfBirth, FPFAge, FPFGender, FPFCivilStatus, FPFNationality, FPFReligion,
                                    FPFOccupation, FPFMobileNum1, FPFMobileNum2, FPFTelNum1, FPFTelNum2, FPFFaxNum, FPFEmailAdd1, FPFEmailAdd2
                                FROM Franchisee Order by idFranchisee"
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(fsQuery, oConnection)
                    Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    While oReader.Read
                        fs = New clsFranchisee
                        'fsOutlet = New clsOutlet
                        fs.idFranchisee = oReader("idFranchisee")
                        fs.FName = oReader("FPFName")
                        fs.LName = oReader("FPFLName")
                        fs.MName = oReader("FPFMName")
                        fs.Status = oReader("FPFStatus")
                        fs.OwnershipType = oReader("FPFOwnershipType")
                        fs.CorpAuthorizedName = oReader("FPFCorpAuthorizedName")
                        fs.YearStarted = oReader("FPFYearStarted")
                        fs.Address1 = oReader("FPFAddress1")
                        fs.Address2 = oReader("FPFAddress2")
                        fs.TinNumber = oReader("FPFTinNumber")
                        fs.DateOfBirth = oReader("FPFDateOfBirth")
                        fs.Age = oReader("FPFAge")
                        fs.Gender = oReader("FPFGender")
                        fs.CivilStatus = oReader("FPFCivilStatus")
                        fs.Nationality = oReader("FPFNationality")
                        fs.Religion = oReader("FPFReligion")
                        fs.Occupation = oReader("FPFOccupation")
                        fs.MobileNumber1 = oReader("FPFMobileNum1")
                        fs.MobileNumber2 = oReader("FPFMobileNum2")
                        fs.TelNumber1 = oReader("FPFTelNum1")
                        fs.TelNumber2 = oReader("FPFTelNum2")
                        fs.FaxNumber = oReader("FPFFaxNum")
                        fs.EmailAdd1 = oReader("FPFEmailAdd1")
                        fs.EmailAdd2 = oReader("FPFEmailAdd2")
                        'fsOutlet.idOutlet = oReader("idOutlet")

                        'franchiseeOutlet.Add(fsOutlet)
                        franchiseeList.Add(fs)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getFranchiseeList " + ex.Message)
            End Try
        End Using
        Return franchiseeList
    End Function

    Public Function getIdFranchisee() As Integer

        Dim fs As New clsFranchisee
        Dim fsQuery As String = "Select COUNT(*)
                                FROM Franchisee"
        Dim unF As Integer
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(fsQuery, oConnection)
                    Return oCommand.ExecuteScalar()
                    'Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    'While oReader.Read
                    '    fs = New clsFranchisee
                    '    fs.idFranchisee = oReader("idFranchisee")

                    '    Return unF = fs.idFranchisee
                    'End While
                End Using


            Catch ex As Exception
                MessageBox.Show("Error @:getIdFranchisee " + ex.Message)
            End Try
        End Using
        Return unF
    End Function

    Dim l As List(Of clsFranchisee)
    Public Function loadFranchisee()
        pnlMain.lvUserProfile.Items.Clear()
        Dim listFs As List(Of clsFranchisee) = modProfiling.getFranchiseeList
        l = modProfiling.getFranchiseeList

        For Each item In listFs
            Dim oItem As New ListViewItem()
            oItem.Text = item.idFranchisee
            oItem.SubItems.Add(item.FName + " " + item.MName + " " + item.LName)
            oItem.Tag = item.idFranchisee

            pnlMain.lvUserProfile.Items.Add(oItem)
            If item.Status = "0" Then
                oItem.ForeColor = Color.Red
            End If


        Next

        Return listFs
    End Function

End Module
