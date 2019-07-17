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

    'Public Function getOutletLocList(ByVal unF As Integer) As List(Of clsOutletLocation)
    '    Dim outletLocList As List(Of clsOutletLocation) = New List(Of clsOutletLocation)
    '    Dim ol As New clsOutletLocation
    '    Dim sQuery As String = "SELECT Outlet.unOutlet, Outlet.FPOBusinessUnit, Location.FPLLocationName, Location.FPLCurrentAddress, 
    '                             Location.FPLDateOpened, Location.FPLStatus, Location.FPLStatusClosed, Location.FPLDateClosed
    '                             FROM Outlet 
    '                             JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
    '                             JOIN Location On Location.unOutlet = Outlet.unOutlet
    '                             Where Outlet.unFranchisee = @unFranchisee"
    '    Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
    '        Try
    '            oConnection.Open()
    '            Using oCom As New SqlCommand(sQuery, oConnection)

    '                oCom.Parameters.AddWithValue("unFranchisee", unF)

    '                Dim oRead As SqlDataReader = oCom.ExecuteReader

    '                While oRead.Read
    '                    ol = New clsOutletLocation
    '                    ol.unOutlet = oRead("unOutlet")
    '                    ol.FPOBusinessUnit = oRead("FPOBusinessUnit")
    '                    ol.FPLLocationName = oRead("FPLLocationName")
    '                    ol.FPLCurrentAddress = oRead("FPLCurrentAddress")
    '                    ol.FPLDateOpened = oRead("FPLDateOpened")
    '                    ol.FPLStatus = oRead("FPLStatus")
    '                    ol.FPLStatusClosed = oRead("FPLStatusClosed")
    '                    ol.FPLDateClosed = oRead("FPLDateClosed")

    '                    OutletLocList.Add(ol)
    '                End While
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error @:getOutletLocList() " + ex.Message)
    '        End Try
    '    End Using
    '    Return outletLocList
    'End Function

    'Public Function loadOutletLocation(ByVal unF As Integer)
    '    pnlMain.lvOutlet.Items.Clear()
    '    Dim listOL As List(Of clsOutletLocation) = modProfiling.getOutletLocList(unF)
    '    'l = modProfiling.getFranchiseeList

    '    For Each item In listOL
    '        Dim lItem As New ListViewItem()
    '        lItem.Text = item.unOutlet
    '        lItem.SubItems.Add(item.FPOBusinessUnit)
    '        lItem.SubItems.Add(item.FPLLocationName)
    '        lItem.SubItems.Add(item.FPLCurrentAddress)
    '        lItem.SubItems.Add(item.FPLDateOpened)
    '        lItem.SubItems.Add(item.FPLStatus)
    '        lItem.SubItems.Add(item.FPLStatusClosed)
    '        lItem.SubItems.Add(item.FPLDateClosed)
    '        lItem.Tag = item.unOutlet

    '        pnlMain.lvOutlet.Items.Add(lItem)

    '    Next

    '    Return listOL
    'End Function

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
    Public Function displayInfoFranchisee()
        Dim focItem As Integer = pnlMain.lvUserProfile.FocusedItem.Index + 1
        Dim focItemUn As Integer = pnlMain.lvUserProfile.FocusedItem.Tag
        l = modProfiling.getFranchiseeList
        Dim pb = pnlMain.pbUserProfile
        Dim unF As Integer
        For Each o In l
            If o.unFranchisee = focItemUn Then
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

                unF = o.unFranchisee
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
        'Dim FranchiseeID As Integer = Convert.ToInt32(pnlMain.lblIDFranchisee.Text)
        modProfiling.displayOutlet(unF)
        'modProfiling.loadOutletLocation(unF)

        modProfiling.displayImage(focItem, pb)
        pnlMain.btnAddNewOutletMain.Visible = True
        pnlMain.btnConfirmOutlet.Visible = False
    End Function

    Public Function getInfo()
        Dim focItem As Integer = pnlMain.lvUserProfile.FocusedItem.Index + 1
        Dim focItemUn As Integer = pnlMain.lvUserProfile.FocusedItem.Tag
        Dim unF As Integer = Convert.ToInt32(pnlMain.lblIDFranchisee.Text)
        l = modProfiling.getFranchiseeList
        Dim pb = frmUpdateFranchiseeProfile.pbUserPhoto
        For Each o In l
            If o.unFranchisee = focItemUn Then
                frmUpdateFranchiseeProfile.txtFName.Text = o.FName
                frmUpdateFranchiseeProfile.txtMName.Text = o.MName
                frmUpdateFranchiseeProfile.txtLName.Text = o.LName
                frmUpdateFranchiseeProfile.cbGender.Text = o.Gender
                frmUpdateFranchiseeProfile.txtAddress1.Text = o.Address1
                frmUpdateFranchiseeProfile.txtAddress2.Text = o.Address2
                frmUpdateFranchiseeProfile.txtAge.Text = o.Age
                frmUpdateFranchiseeProfile.txtCivilStatus.Text = o.CivilStatus
                'frmUpdateFranchiseeProfile.dtpDateOfBirth.Value.Date = o.DateOfBirth
                frmUpdateFranchiseeProfile.txtNationality.Text = o.Nationality
                frmUpdateFranchiseeProfile.txtReligion.Text = o.Religion
                frmUpdateFranchiseeProfile.txtTelNum1.Text = o.TelNumber1
                frmUpdateFranchiseeProfile.txtTelNum2.Text = o.TelNumber2
                frmUpdateFranchiseeProfile.txtMobileNum1.Text = o.MobileNumber1
                frmUpdateFranchiseeProfile.txtMobileNum2.Text = o.MobileNumber1
                frmUpdateFranchiseeProfile.txtEmailAddress1.Text = o.EmailAdd1
                frmUpdateFranchiseeProfile.txtEmailAddress2.Text = o.EmailAdd2
                frmUpdateFranchiseeProfile.cbOwnershipType.Text = o.OwnershipType
                frmUpdateFranchiseeProfile.txtCorpAuthorizedName.Text = o.CorpAuthorizedName
                frmUpdateFranchiseeProfile.txtYearStarted.Text = o.YearStarted
                frmUpdateFranchiseeProfile.txtTinNumber.Text = o.TinNumber
                frmUpdateFranchiseeProfile.txtFaxNumber.Text = o.FaxNumber
                frmUpdateFranchiseeProfile.txtOccupation.Text = o.Occupation
            End If

            modProfiling.displayImage(focItem, pb)
        Next
    End Function
#End Region

#Region "Outlet Methods"

    Public Function getUnOutlet() As List(Of clsOutlet)
        Dim outletList As List(Of clsOutlet) = New List(Of clsOutlet)
        Dim getOutlet As New clsOutlet
        'Dim oQuery As String = "SELECT unOutlet, FPOBusinessUnit
        '                        FROM Outlet"

        Dim oQuery As String = "SELECT unOutlet FROM Outlet"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(oQuery, oConnection)
                    Dim oRead As SqlDataReader = oCom.ExecuteReader
                    While oRead.Read
                        getOutlet = New clsOutlet
                        'getOutlet.unOutlet = oRead("unOutlet")
                        'getOutlet.FPOBusinessUnit = oRead("FPOBusinessUnit")
                        getOutlet.unOutlet = oRead("unOutlet")
                        outletList.Add(getOutlet)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getUnOutlet() " + ex.Message)
            End Try
        End Using
        Return outletList
    End Function

    Public Function getfocusedOId(ByVal lblOutletID As Label) As List(Of clsOutlet)
        Dim listOutlet As List(Of clsOutlet)
        Dim getUnOutlet As String
        getUnOutlet = pnlMain.lvOutlet.FocusedItem.Tag
        listOutlet = modProfiling.getUnOutlet()

        For Each o In listOutlet
            If o.unOutlet = getUnOutlet Then
                lblOutletID.Text = o.unOutlet
            End If
        Next
        Return listOutlet
    End Function

    Public Function getLatestOId() As Integer
        Dim getOutlet As New clsOutlet
        'Dim listOutlet As List(Of clsOutlet)
        Dim latestOId As Integer
        Dim oQuery As String = "SELECT TOP 1 unOutlet FROM Outlet ORDER BY unOutlet DESC"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(oQuery, oConnection)
                    Dim oRead As SqlDataReader = oCom.ExecuteReader
                    While oRead.Read
                        getOutlet = New clsOutlet
                        getOutlet.unOutlet = oRead("unOutlet")
                    End While
                    latestOId = getOutlet.unOutlet
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getLatestOId() " + ex.Message)
            End Try
        End Using
        Return latestOId
    End Function

    Public Function getOutletList(unF As Integer) As List(Of clsOutlet)
        Dim outletList As List(Of clsOutlet) = New List(Of clsOutlet)
        Dim getOutlet As New clsOutlet
        Dim sQuery As String = "SELECT Outlet.unOutlet, Outlet.FPOBusinessUnit
                                FROM Outlet
                                INNER JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee where Outlet.unFranchisee = @unFranchisee
                                ORDER BY unOutlet desc"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    oCom.Parameters.AddWithValue("unFranchisee", unF)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        getOutlet = New clsOutlet
                        getOutlet.unOutlet = oRead("unOutlet")
                        getOutlet.FPOBusinessUnit = oRead("FPOBusinessUnit")
                        'getOutlet.unContract = oRead("unContract")
                        'getOutlet.unLocation = oRead("unLocation")

                        outletList.Add(getOutlet)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getOutletList() " + ex.Message)
            End Try
        End Using
        Return outletList
    End Function

    Public Function displayOutlet(unF As Integer)
        pnlMain.lvOutlet.Items.Clear()
        Dim listOutlet As List(Of clsOutlet) = modProfiling.getOutletList(unF)

        For Each item In listOutlet
            Dim oItem As New ListViewItem()
            oItem.Text = item.unOutlet
            oItem.SubItems.Add(item.FPOBusinessUnit)
            'oItem.SubItems.Add(item.unLocation)
            'oItem.SubItems.Add(item.unContract)
            oItem.Tag = item.unOutlet

            pnlMain.lvOutlet.Items.Add(oItem)
        Next
        Return listOutlet
    End Function

#End Region

#Region "Contract"
    Public Function getContractList(unO As Integer) As List(Of clsContract)
        Dim contractList As List(Of clsContract) = New List(Of clsContract)
        Dim getContract As New clsContract
        Dim sQuery As String = "SELECT Contract.unContract, FPCStartTerm, FPCEndTerm, FPCRemark 
                                FROM Contract
                                INNER JOIN Outlet On Contract.unOutlet = Outlet.unOutlet where Outlet.unOutlet = @unOutlet
                                ORDER BY unContract desc"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    oCom.Parameters.AddWithValue("unOutlet", unO)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        getContract = New clsContract
                        getContract.unContract = oRead("unContract")
                        getContract.FPCStartTerm = oRead("FPCStartTerm")
                        getContract.FPCEndTerm = oRead("FPCEndTerm")
                        getContract.FPCRemark = oRead("FPCRemark")

                        contractList.Add(getContract)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getContractList() " + ex.Message)
            End Try
        End Using
        Return contractList

    End Function

    Public Function displayContract(unO As Integer)
        frmOutletDetails.lvContract.Items.Clear()
        Dim listContract As List(Of clsContract) = modProfiling.getContractList(unO)

        For Each item In listContract
            Dim oItem As New ListViewItem()
            oItem.Text = item.unContract
            oItem.SubItems.Add(item.FPCStartTerm)
            oItem.SubItems.Add(item.FPCEndTerm)
            oItem.SubItems.Add(item.FPCRemark)
            oItem.SubItems.Add(item.unOutlet)
            oItem.Tag = item.unContract

            frmOutletDetails.lvContract.Items.Add(oItem)
        Next
        Return listContract
    End Function

    'Public Function getLatestCId() As Integer
    '    Dim getContract As New clsContract
    '    'Dim listOutlet As List(Of clsOutlet)
    '    Dim latestCId As Integer
    '    Dim oQuery As String = "SELECT TOP 1 unContract FROM Contract ORDER BY unContract DESC"
    '    'Dim oQuery As String = "SELECT Count(idContract) FROM Contract"

    '    Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
    '        Try
    '            oConnection.Open()
    '            Using oCom As New SqlCommand(oQuery, oConnection)
    '                Dim oRead As SqlDataReader = oCom.ExecuteReader
    '                While oRead.Read
    '                    getContract = New clsContract
    '                    getContract.unContract = oRead("unContract")
    '                End While
    '                latestCId = getContract.unContract
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error @:getLatestCId() " + ex.Message)
    '        End Try
    '    End Using
    '    Return latestCId
    'End Function

#End Region

#Region "Package"

    Public Function getPackageList(unO As Integer) As List(Of clsPackage)
        Dim packageList As List(Of clsPackage) = New List(Of clsPackage)
        Dim getPackage As New clsPackage
        Dim sQuery As String = "SELECT Package.unOutlet, FPPPackageType, FPPFranchiseFee, FPPPackageFee, FPPSecurityDeposit, FPPDateOfRefund, FPPFranchiseRemark, FPPPackageRemark, FPPDepositRemark
                                FROM Package
                                INNER JOIN Outlet On Package.unOutlet = Outlet.unOutlet where Outlet.unOutlet = @unOutlet"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    oCom.Parameters.AddWithValue("@unOutlet", unO)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        getPackage = New clsPackage
                        getPackage.unOutlet = oRead("unOutlet")
                        getPackage.FPPPackageType = oRead("FPPPackageType")
                        getPackage.FPPFranchiseFee = oRead("FPPFranchiseFee")
                        getPackage.FPPPackageFee = oRead("FPPPackageFee")
                        getPackage.FPPSecurityDeposit = oRead("FPPSecurityDeposit")
                        getPackage.FPPFranchiseRemark = oRead("FPPFranchiseRemark")
                        getPackage.FPPPackageRemark = oRead("FPPPackageRemark")
                        getPackage.FPPDepositRemark = oRead("FPPDepositRemark")
                        getPackage.FPPDateOfRefund = oRead("FPPDateOfRefund")

                        packageList.Add(getPackage)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getPackageList() " + ex.Message)
            End Try
        End Using
        Return packageList

    End Function

    Public Function displayInfoPackage(unO As Integer) As List(Of clsPackage)
        'Dim focItemUn As Integer = frmOutletDetails.lblOutletID.Text
        Dim listPackage As List(Of clsPackage) = modProfiling.getPackageList(unO)

        For Each o In listPackage
            If o.unOutlet = unO Then
                frmOutletDetails.lblPackageType.Text = o.FPPPackageType
                frmOutletDetails.lblFranchiseFee.Text = o.FPPFranchiseFee
                frmOutletDetails.lblFranchiseRemarks.Text = o.FPPFranchiseRemark
                frmOutletDetails.lblPackageFee.Text = o.FPPPackageFee
                frmOutletDetails.lblPackageRemarks.Text = o.FPPPackageRemark
                frmOutletDetails.lblSecurityDeposit.Text = o.FPPSecurityDeposit
                frmOutletDetails.lblDepositRemarks.Text = o.FPPDepositRemark
                frmOutletDetails.lblDateOfRefund.Text = o.FPPDateOfRefund
            End If
        Next
        Return listPackage
    End Function

    Public Function getInfoPackage(unO As Integer) As List(Of clsPackage)
        Dim listPackage As List(Of clsPackage) = modProfiling.getPackageList(unO)

        For Each o In listPackage
            If o.unOutlet = unO Then
                frmUpdatePackage.lblOutletID.Text = o.unOutlet
                frmUpdatePackage.cbPackageType.Text = o.FPPPackageType
                frmUpdatePackage.txtFranchiseeFee.Text = o.FPPFranchiseFee
                frmUpdatePackage.txtFranchiseRemark.Text = o.FPPFranchiseRemark
                frmUpdatePackage.txtPackageFee.Text = o.FPPPackageFee
                frmUpdatePackage.txtPackageRemark.Text = o.FPPPackageRemark
                frmUpdatePackage.txtSecurityDeposit.Text = o.FPPSecurityDeposit
                frmUpdatePackage.txtDepositRemark.Text = o.FPPDepositRemark
                'frmUpdatePackage.txtDateOfRefund.Text = o.FPPDateOfRefund
            End If
        Next
        Return listPackage
    End Function

    Public Function updateInfoPackage(ByVal unO As Integer) As Boolean
        Dim sQuery As String = "Update Package
                                Set FPPPackageType = @FPPPackageType, FPPFranchiseFee = @FPPFranchiseFee, FPPPackageFee = @FPPPackageFee, 
                                FPPSecurityDeposit = @FPPSecurityDeposit, FPPDateOfRefund = @FPPDateOfRefund, FPPFranchiseRemark = @FPPFranchiseRemark, 
                                FPPPackageRemark = @FPPPackageRemark, FPPDepositRemark = @FPPDepositRemark
                                where unOutlet = " & Val(unO)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPPPackageType", frmUpdatePackage.cbPackageType.Text)
                    oCommand.Parameters.AddWithValue("@FPPFranchiseFee", frmUpdatePackage.txtFranchiseeFee.Text)
                    oCommand.Parameters.AddWithValue("@FPPPackageFee", frmUpdatePackage.txtPackageFee.Text)
                    oCommand.Parameters.AddWithValue("@FPPSecurityDeposit", frmUpdatePackage.txtSecurityDeposit.Text)
                    oCommand.Parameters.AddWithValue("@FPPDateOfRefund", frmUpdatePackage.dtpDateOfRefund.Value.Date)
                    oCommand.Parameters.AddWithValue("@FPPFranchiseRemark", frmUpdatePackage.txtFranchiseRemark.Text)
                    oCommand.Parameters.AddWithValue("@FPPPackageRemark", frmUpdatePackage.txtPackageRemark.Text)
                    oCommand.Parameters.AddWithValue("@FPPDepositRemark", frmUpdatePackage.txtDepositRemark.Text)


                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
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

    Public Function displayImage(ByVal focItem As Integer, ByVal pb As PictureBox)
        Dim sQuery As String = "Select FPFImage from Franchisee where idFranchisee=" & Val(focItem)

        Using oConnection As New SqlConnection(getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)

                    Dim arrImage As Byte() = DirectCast(oCommand.ExecuteScalar(), Byte())
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    mstream.Write(arrImage, 0, arrImage.Length)

                    Dim bitmap As New Bitmap(mstream)
                    pb.Image = bitmap
                End Using
            Catch ex As Exception
                MsgBox("@displayImage " + ex.Message)
            End Try
        End Using
    End Function

End Module
