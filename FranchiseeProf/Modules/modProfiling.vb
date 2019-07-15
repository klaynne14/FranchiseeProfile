Imports System.Data.SqlClient
Imports System.IO

Module modProfiling

#Region "Franchisee Methods"

    'Get franchisee list details to display in list view
    Public Function getFranchisee() As List(Of clsFranchisee)
        Dim list As New List(Of clsFranchisee)
        Dim franchiseelist As clsFranchisee

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand("SELECT unFranchisee, FPFName,FPFLName,FPFMName FROM Franchisee", oConnection)
                    Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    While oReader.Read()
                        franchiseelist = New clsFranchisee
                        franchiseelist.unFranchisee = oReader("unFranchisee")
                        franchiseelist.FName = oReader("FPFName")
                        franchiseelist.MName = oReader("FPFMName")
                        franchiseelist.LName = oReader("FPFLName")
                        list.Add(franchiseelist)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("@getFranchisee()" + ex.Message)
            End Try
        End Using
        Return list
    End Function

    'Get Franchisee details for user profile
    Public Function getFranchiseeList() As List(Of clsFranchisee)
        Dim franchiseeList As List(Of clsFranchisee) = New List(Of clsFranchisee)
        Dim fs As New clsFranchisee
        Dim fsQuery As String = "Select idFranchisee, unFranchisee, FPFName,FPFLName,FPFMName, FPFStatus, FPFOwnershipType, FPFCorpAuthorizedName, FPFYearStarted,
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
                        fs.unFranchisee = oReader("unFranchisee")
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

    'Load existing Franchisee from db to listview 
    Dim l As List(Of clsFranchisee)
    Public Function loadFranchisee()
        pnlMain.lvUserProfile.Items.Clear()
        Dim listFs As List(Of clsFranchisee) = modProfiling.getFranchiseeList
        l = modProfiling.getFranchiseeList

        For Each item In listFs
            Dim lItem As New ListViewItem()
            lItem.Text = item.unFranchisee
            lItem.SubItems.Add(item.FName + " " + item.MName + " " + item.LName)
            lItem.Tag = item.unFranchisee

            pnlMain.lvUserProfile.Items.Add(lItem)
            If item.Status = "0" Then
                lItem.ForeColor = Color.Red
            End If
        Next

        Return listFs
    End Function

    'Display info from listview to panel
    Public Function displayInfo()
        Dim focItem As Integer
        focItem = pnlMain.lvUserProfile.FocusedItem.Index + 1
        l = modProfiling.getFranchiseeList

        For Each o In l
            If o.idFranchisee = focItem Then
                pnlMain.lblFullName.Text = o.FName + " " + o.MName + " " + o.LName
                pnlMain.lblIDFranchisee.Text = o.unFranchisee
                pnlMain.lblFPFStatus.Text = o.Status
                pnlMain.lblGender.Text = o.Gender
                pnlMain.lblAddress1.Text = o.Address1
                pnlMain.lblAddress2.Text = o.Address2
                pnlMain.lblAge.Text = o.Age
                pnlMain.lblCivilStatus.Text = o.CivilStatus
                pnlMain.lblDateOfBirth.Text = o.DateOfBirth
                pnlMain.lblNationality.Text = o.Nationality
                pnlMain.lblReligion.Text = o.Religion
                pnlMain.lblTelNum1.Text = o.TelNumber1
                pnlMain.lblTelNum2.Text = o.TelNumber2
                pnlMain.lblMobileNum1.Text = o.MobileNumber1
                pnlMain.lblMobileNum2.Text = o.MobileNumber1
                pnlMain.lblEmailAdd1.Text = o.EmailAdd1
                pnlMain.lblEmailAdd2.Text = o.EmailAdd2
                pnlMain.lblOwnershipType.Text = o.OwnershipType
                pnlMain.lblCorpAuthorizedName.Text = o.CorpAuthorizedName
                pnlMain.lblYearStarted.Text = o.YearStarted
                pnlMain.lblTinNumber.Text = o.TinNumber
                pnlMain.lblFaxNumber.Text = o.FaxNumber
                pnlMain.lblOccupation.Text = o.Occupation
            End If
        Next

        If pnlMain.lblFPFStatus.Text = "-1" Then
            pnlMain.lblFPFStatus.Text = "Active"
            pnlMain.lblFPFStatus.ForeColor = Color.Green
            pnlMain.btnAddNewOutletMain.Enabled = True
            pnlMain.btnAddNewOutletMain.BackColor = Color.CadetBlue
        Else
            pnlMain.lblFPFStatus.Text = "Inactive"
            pnlMain.lblFPFStatus.ForeColor = Color.Red
            pnlMain.btnAddNewOutletMain.Enabled = False
            pnlMain.btnAddNewOutletMain.BackColor = Color.LightGray
        End If

        'Display Outlet to Outlet Listview under franchisee's ID
        Dim FranchiseeID As String = pnlMain.lblIDFranchisee.Text
        modProfiling.displayOutlet(FranchiseeID)

        modProfiling.displayImage(focItem)
    End Function

#End Region

#Region "Outlet Methods"

    Public Function getIdOutlet() As List(Of clsOutlet)
        Dim outletList As List(Of clsOutlet) = New List(Of clsOutlet)
        Dim getOutlet As New clsOutlet
        'Dim oQuery As String = "SELECT unOutlet, FPOBusinessUnit
        '                        FROM Outlet"

        Dim oQuery As String = "SELECT idOutlet
                                FROM Outlet"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(oQuery, oConnection)
                    Dim oRead As SqlDataReader = oCom.ExecuteReader
                    While oRead.Read
                        getOutlet = New clsOutlet
                        'getOutlet.unOutlet = oRead("unOutlet")
                        'getOutlet.FPOBusinessUnit = oRead("FPOBusinessUnit")
                        getOutlet.idOutlet = oRead("idOutlet")
                        outletList.Add(getOutlet)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getIdOutlet() " + ex.Message)
            End Try
        End Using
        Return outletList
    End Function

    Public Function getOId() As List(Of clsOutlet)
        Dim listOutlet As List(Of clsOutlet)
        Dim getidOutlet As String
        getidOutlet = pnlMain.lvOutlet.FocusedItem.Tag
        listOutlet = modProfiling.getIdOutlet()

        For Each o In listOutlet
            If o.idOutlet = getidOutlet Then
                frmOutletDetails.lblOutletID.Text = o.idOutlet
            End If
        Next
        Return listOutlet
    End Function

    Public Function getOutletList(id As String) As List(Of clsOutlet)
        Dim outletList As List(Of clsOutlet) = New List(Of clsOutlet)
        Dim getOutlet As New clsOutlet
        Dim oQuery As String = "SELECT Outlet.idOutlet, Outlet.FPOBusinessUnit, Outlet.idLocation, Outlet.idContract
                                FROM Outlet
                                INNER JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee where Outlet.unFranchisee = @unFranchisee"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(oQuery, oConnection)

                    oCom.Parameters.AddWithValue("unFranchisee", id)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        getOutlet = New clsOutlet
                        getOutlet.idOutlet = oRead("idOutlet")
                        getOutlet.FPOBusinessUnit = oRead("FPOBusinessUnit")
                        'getOutlet.unFranchisee = oRead("unFranchisee")
                        getOutlet.idContract = oRead("idContract")
                        getOutlet.idLocation = oRead("idLocation")

                        outletList.Add(getOutlet)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getOutletList() " + ex.Message)
            End Try
        End Using
        Return outletList
    End Function

    Public Function displayOutlet(id As String)
        pnlMain.lvOutlet.Items.Clear()
        Dim listOutlet As List(Of clsOutlet) = modProfiling.getOutletList(id)

        For Each item In listOutlet
            Dim oItem As New ListViewItem()
            oItem.Text = item.idOutlet
            oItem.SubItems.Add(item.FPOBusinessUnit)
            oItem.SubItems.Add(item.idLocation)
            oItem.SubItems.Add(item.idContract)
            oItem.Tag = item.idOutlet

            pnlMain.lvOutlet.Items.Add(oItem)
        Next
        Return listOutlet
    End Function

#End Region

    Public Function clearTextOutlet()
        Dim unfControl As Control
        For Each unfControl In frmAddNewOutlet.Panel1.Controls
            If TypeName(unfControl) = "TextBox" Then
                unfControl.Text = ""
            End If
        Next unfControl
    End Function

    Public Function clearTextFranchisee()
        Dim unfControl As Control
        For Each unfControl In frmCreateNewFranchisee.Panel1.Controls
            If TypeName(unfControl) = "TextBox" Then
                unfControl.Text = ""
            End If
        Next unfControl
    End Function

    Public Sub recolorListView(ByVal profListView As ListView)
        'Scroll through each listview item
        For Each item In profListView.Items

            If profListView.SelectedItems.Contains(item) Then 'The item is selected
                CType(item, ListViewItem).BackColor = Color.CadetBlue 'Color it green!
            Else 'The item is not selected
                CType(item, ListViewItem).BackColor = Color.White 'Color it white
            End If
        Next
    End Sub

    Public Function browseImage()

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                Dim OFD As FileDialog = New OpenFileDialog()

                OFD.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

                If OFD.ShowDialog() = DialogResult.OK Then
                    Dim imgpath As String = OFD.FileName
                    frmCreateNewFranchisee.pbFranchisee.ImageLocation = imgpath

                End If

                OFD = Nothing

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End Using
        Return False
    End Function

    Public Function displayImage(ByVal selectedID As Integer)
        Dim sQuery As String = "Select testImage from Image where idImage=" & Val(selectedID)

        Using oConnection As New SqlConnection(getConnection("ImageTest"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)

                    Dim arrImage As Byte() = DirectCast(oCommand.ExecuteScalar(), Byte())
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    mstream.Write(arrImage, 0, arrImage.Length)

                    Dim bitmap As New Bitmap(mstream)
                    pnlMain.pbUserProfile.Image = bitmap
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Function

    Public Function getFranchiseeInfoText()
        Dim franchiseeUpdate As New frmUpdateFranchiseeProfile
        Dim frInfo As List(Of clsFranchisee) = New List(Of clsFranchisee)
        Dim fs As New clsFranchisee
        Dim sQuery As String = "Select idFranchisee, unFranchisee, FPFName,FPFLName,FPFMName, FPFStatus, FPFOwnershipType, FPFCorpAuthorizedName, FPFYearStarted,
                                    FPFAddress1, FPFAddress2, FPFTinNumber, FPFDateOfBirth, FPFAge, FPFGender, FPFCivilStatus, FPFNationality, FPFReligion,
                                    FPFOccupation, FPFMobileNum1, FPFMobileNum2, FPFTelNum1, FPFTelNum2, FPFFaxNum, FPFEmailAdd1, FPFEmailAdd2
                                FROM Franchisee Where unFranchisee = @unFranchisee" '& Val(pnlMain.lblIDFranchisee.Text)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseeProfiling"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oRead As SqlDataReader = oCommand.ExecuteReader
                    While oRead.Read
                        fs = New clsFranchisee
                        franchiseeUpdate.txtFName.Text = fs.FName
                        frInfo.Add(fs)
                    End While
                End Using
            Catch ex As Exception
                MsgBox("@getFranchiseeInfoText()" + ex.Message)
            End Try
        End Using
        Return frInfo
    End Function

End Module
