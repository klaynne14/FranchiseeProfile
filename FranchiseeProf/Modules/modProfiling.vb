Imports System.Data.SqlClient
Imports System.IO

'FranchiseProfiling
'FranchiseMasterFile

Module modProfiling
    Public Class clsOutletLocation

        Public FPOBusinessUnit As String
        Public unFranchisee As String

        Public unOutlet As Integer

        Public FPLLocationName As String
        Public FPLCurrentAddress As String
        Public FPLOldAddress As String
        Public FPLDateOpened As Date
        Public FPLDateClosed As Date
        Public FPLStatus As String
        Public FPLStatusClosed As String

        Public Function mergeList() As Boolean
            Dim olList As New List(Of clsOutletLocation)
            Dim ol As clsOutletLocation
            Dim o As New clsOutlet
            Dim l As New clsLocation
            Try
                ol = New clsOutletLocation
                ol.unOutlet = o.unOutlet
                ol.FPOBusinessUnit = o.FPOBusinessUnit
                ol.FPLLocationName = l.FPLLocationName
                ol.FPLCurrentAddress = l.FPLCurrentAddress
                ol.FPLDateOpened = l.FPLDateOpened
                ol.FPLDateClosed = l.FPLDateClosed
                ol.FPLStatus = l.FPLStatus
                ol.FPLStatusClosed = l.FPLStatus
                ol.FPLOldAddress = l.FPLOldAddress
                Return True

            Catch ex As Exception
                MsgBox("@mergeList: " + ex.Message)
            End Try

            Return False
        End Function
    End Class

#Region "Franchisee Methods"

    'Get franchisee list details to display in list view
    Public Function getFranchisee() As List(Of clsFranchisee)
        Dim list As New List(Of clsFranchisee)
        Dim franchiseelist As clsFranchisee

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
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
        Dim fsQuery As String = "Select idFranchisee, unFranchisee, FPFName,FPFLName,FPFMName, FPFStatus, FPFTotalActive, FPFTotalTempClosed, FPFTotalPermClosed, FPFOwnershipType, FPFCorpAuthorizedName, FPFYearStarted,
                                    FPFAddress1, FPFAddress2, FPFTinNumber, FPFDateOfBirth, FPFAge, FPFGender, FPFCivilStatus, FPFNationality, FPFReligion,
                                    FPFOccupation, FPFMobileNum1, FPFMobileNum2, FPFTelNum1, FPFTelNum2, FPFFaxNum, FPFEmailAdd1, FPFEmailAdd2
                                    FROM Franchisee Order by idFranchisee"
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
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
                        fs.totalactive = oReader("FPFTotalActive")
                        fs.totaltempclosed = oReader("FPFTotalTempClosed")
                        fs.totalpermclosed = oReader("FPFTotalPermClosed")
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
        pnlMain.tslblRowCount.Text = pnlMain.lvUserProfile.Items.Count
        Return listFs
    End Function

    'Public Function searchList(unF As Integer) As List(Of clsFranchisee)
    '    Dim franchiseeList As List(Of clsFranchisee) = New List(Of clsFranchisee)
    '    Dim fs As New clsFranchisee
    '    Dim sQuery As String = "Select FPFName, FPLName, FPMName From Franchisee Where FPFFName like '%" & Val(unF) & "%' And FPFMName like'%" & Val(unF) & "%'  And FPFLName like'%" & Val(unF) & "%'"

    '    Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseeProfiling"))
    '        Try
    '            oConnection.Open()
    '            Using oCommand As New SqlCommand(sQuery, oConnection)
    '                Dim oReader As SqlDataReader = oCommand.ExecuteReader
    '                While oReader.Read()
    '                    fs = New clsFranchisee
    '                    fs.FName = oReader("FPFFName")
    '                    fs.MName = oReader("FPFMName")
    '                    fs.LName = oReader("FPFLName")
    '                End While
    '            End Using
    '        Catch ex As Exception
    '            MsgBox("@searchList:" + ex.Message)
    '        End Try
    '    End Using
    '    Return franchiseeList
    'End Function

    'Dim lvList As New List(Of ListViewItem)
    'Public Function searchList()
    '    pnlMain.lvUserProfile.BeginUpdate()
    '    If pnlMain.txtSearchBar.Text.Trim().Length = 0 Then
    '        pnlMain.lvUserProfile.Items.Clear()
    '        For Each item In lvList
    '            pnlMain.lvUserProfile.Items.Add(item)
    '        Next
    '    Else
    '        'pnlMain.lvUserProfile.Items.Clear()
    '        For Each item In lvList
    '            If item.Text.Contains(pnlMain.txtSearchBar.Text) Then
    '                pnlMain.lvUserProfile.Items.Add(item)
    '            End If
    '        Next
    '    End If
    '    pnlMain.lvUserProfile.EndUpdate()
    'End Function

    Public Function searchList()
        pnlMain.lvUserProfile.SelectedIndices.Clear()
        Dim searchstring As String = pnlMain.txtSearchBar.Text
        For Each lvi As ListViewItem In pnlMain.lvUserProfile.Items
            For Each lvisub As ListViewItem.ListViewSubItem In lvi.SubItems
                If lvisub.Text = searchstring Then
                    pnlMain.lvUserProfile.SelectedIndices.Add(lvi.Index)
                    If lvi.Index > 0 Then
                        lvi.EnsureVisible()
                    End If
                    Exit For
                End If
            Next
        Next
        pnlMain.lvUserProfile.Focus()
    End Function

    'Public Sub SwapListViewItems(index1 As Integer)
    '    Dim item1 = pnlMain.lvUserProfile.Items(index1)
    '    Dim item2 = pnlMain.lvUserProfile.Items(index1 + 1)

    '    Dim text As String

    '    For i = 0 To item1.SubItems.Count - 1
    '        Dim subitem1 = item1.SubItems(i)
    '        Dim subitem2 = item2.SubItems(i)

    '        text = subitem1.Text
    '        subitem1.Text = subitem2.Text
    '        subitem2.Text = text
    '    Next
    'End Sub

    'Public Function searchList()


    '    If pnlMain.txtSearchBar.Text = String.Empty Then
    '        'Don't bother searching if there's no text to search for.
    '        MessageBox.Show("Please enter search text.")
    '    Else
    '        Dim startIndex = 0
    '        Dim item As ListViewItem = Nothing

    '        'If one item is selected and it already matches the search text, start searching from the next item.
    '        'Otherwise, start searching from the beginning.
    '        If pnlMain.lvUserProfile.SelectedItems.Count >= 1 AndAlso pnlMain.lvUserProfile.SelectedItems(0).Text = pnlMain.txtSearchBar.Text Then
    '            startIndex = pnlMain.lvUserProfile.SelectedIndices(0) + 1
    '        End If

    '        'Don't search if we're already at the end of the items.
    '        If startIndex < pnlMain.lvUserProfile.Items.Count Then
    '            Do
    '                'Find the first partial match.
    '                item = pnlMain.lvUserProfile.FindItemWithText(pnlMain.txtSearchBar.Text, False, startIndex)

    '                If item Is Nothing OrElse item.Text = pnlMain.txtSearchBar.Text Then
    '                    'There is no partial match or we have already found a full match.
    '                    Exit Do
    '                End If

    '                'Search again from the item after the last partial match.
    '                startIndex = item.Index + 1

    '                'Stop searching if we're at the end of the items.
    '                If startIndex >= pnlMain.lvUserProfile.Items.Count Then
    '                    Exit Do
    '                End If
    '            Loop
    '        End If

    '        'Clear the current selection.
    '        pnlMain.lvUserProfile.SelectedItems.Clear()

    '        If item Is Nothing Then
    '            MessageBox.Show("No match found.")
    '        Else
    '            'Select the matching item.
    '            item.Selected = True
    '            item.EnsureVisible()
    '            pnlMain.lvUserProfile.Select()
    '        End If
    '    End If


    'End Function

    '*************************************************************************************
    'Display info from listview to panel

    Public Function displayInfoFranchisee()
        Dim focItemUn As Integer
        Try
            focItemUn = pnlMain.lvUserProfile.FocusedItem.Tag
        Catch ex As Exception
            focItemUn = pnlMain.lblIDFranchisee.Text
        End Try

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
            frmOutletDetails.btnAddEnabled.Enabled = False
        End If

        'Display Outlet to Outlet Listview under franchisee's ID (unFranchisee)
        modProfiling.loadOutletLocation(unF)

        modProfiling.displayImage(focItemUn, pb)
        pnlMain.btnAddNewOutletMain.Visible = True

        modProfiling.countOutlet(unF)
        modProfiling.updateCount(unF)
        modProfiling.displayCount(unF)
    End Function

    Public Function getInfo()
        Try
            Dim focItem As Integer = pnlMain.lvUserProfile.FocusedItem.Index + 1
            Dim focItemUn As Integer = pnlMain.lvUserProfile.FocusedItem.Tag
            Dim unF As Integer = Convert.ToInt32(pnlMain.lblIDFranchisee.Text)
            l = modProfiling.getFranchiseeList
            Dim pb = frmUpdateFranchiseeProfile.pbUserPhoto
            Dim checkState As Boolean
            For Each o In l
                If o.unFranchisee = focItemUn Then
                    frmUpdateFranchiseeProfile.txtFName.Text = o.FName
                    frmUpdateFranchiseeProfile.txtMName.Text = o.MName
                    frmUpdateFranchiseeProfile.txtLName.Text = o.LName

                    If o.Status = 0 Then
                        checkState = False
                    Else
                        checkState = True
                    End If

                    frmUpdateFranchiseeProfile.cbFPFStatus.Checked = checkState
                    frmUpdateFranchiseeProfile.cbGender.Text = o.Gender
                    frmUpdateFranchiseeProfile.txtAddress1.Text = o.Address1
                    frmUpdateFranchiseeProfile.txtAddress2.Text = o.Address2
                    frmUpdateFranchiseeProfile.txtAge.Text = o.Age
                    frmUpdateFranchiseeProfile.cbCivilStatus.Text = o.CivilStatus
                    frmUpdateFranchiseeProfile.dtpDateBirth.Value = o.DateOfBirth
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

                modProfiling.displayImage(focItemUn, pb)
            Next
        Catch ex As Exception
            'MsgBox("No selected item!")
        End Try

    End Function

    Public Function updateFranchisee(unF As Integer, statStat As Integer) As Boolean

        Dim mstream As New System.IO.MemoryStream()
        frmUpdateFranchiseeProfile.pbUserPhoto.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage As Byte() = mstream.GetBuffer()
        Dim FileSize As UInt32
        FileSize = mstream.Length

        mstream.Close()

        Dim uQuery As String = "UPDATE Franchisee
                                SET FPFImage=@FPFImage, FPFName=@FPFName,FPFLName=@FPFLName,FPFMName=@FPFMName, FPFOwnershipType=@FPFOwnershipType, 
                                    FPFCorpAuthorizedName = @FPFCorpAuthorizedName, FPFYearStarted=@FPFYearStarted, FPFAddress1=@FPFAddress1, FPFStatus=@FPFStatus,
                                    FPFAddress2=@FPFAddress2, FPFTinNumber=@FPFTinNumber, FPFDateOfBirth=@FPFDateOfBirth, FPFAge=@FPFAge, 
                                    FPFGender=@FPFGender, FPFCivilStatus=@FPFCivilStatus, FPFNationality=@FPFNationality, FPFReligion=@FPFReligion,
                                    FPFOccupation=@FPFOccupation, FPFMobileNum1=@FPFMobileNum1, FPFMobileNum2=@FPFMobileNum2, FPFTelNum1=@FPFTelNum1, 
                                    FPFTelNum2=@FPFTelNum2, FPFFaxNum=@FPFFaxNum, FPFEmailAdd1=@FPFEmailAdd1, FPFEmailAdd2=@FPFEmailAdd2
                                    WHERE unFranchisee = " & Val(unF)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(uQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@FPFImage", arrImage)
                    oCommand.Parameters.AddWithValue("@FPFName", frmUpdateFranchiseeProfile.txtFName.Text)
                    oCommand.Parameters.AddWithValue("@FPFLName", frmUpdateFranchiseeProfile.txtLName.Text)
                    oCommand.Parameters.AddWithValue("@FPFMName", frmUpdateFranchiseeProfile.txtMName.Text)
                    oCommand.Parameters.AddWithValue("@FPFStatus", statStat)
                    oCommand.Parameters.AddWithValue("@FPFOwnershipType", frmUpdateFranchiseeProfile.cbOwnershipType.Text)
                    oCommand.Parameters.AddWithValue("@FPFCorpAuthorizedName", frmUpdateFranchiseeProfile.txtCorpAuthorizedName.Text)
                    oCommand.Parameters.AddWithValue("@FPFYearStarted", frmUpdateFranchiseeProfile.txtYearStarted.Text)
                    oCommand.Parameters.AddWithValue("@FPFAddress1", frmUpdateFranchiseeProfile.txtAddress1.Text)
                    oCommand.Parameters.AddWithValue("@FPFAddress2", frmUpdateFranchiseeProfile.txtAddress2.Text)
                    oCommand.Parameters.AddWithValue("@FPFTinNumber", frmUpdateFranchiseeProfile.txtTinNumber.Text)
                    oCommand.Parameters.AddWithValue("@FPFDateOfBirth", frmUpdateFranchiseeProfile.dtpDateBirth.Value)
                    oCommand.Parameters.AddWithValue("@FPFAge", frmUpdateFranchiseeProfile.txtAge.Text)
                    oCommand.Parameters.AddWithValue("@FPFGender", frmUpdateFranchiseeProfile.cbGender.Text)
                    oCommand.Parameters.AddWithValue("@FPFCivilStatus", frmUpdateFranchiseeProfile.cbCivilStatus.Text)
                    oCommand.Parameters.AddWithValue("@FPFNationality", frmUpdateFranchiseeProfile.txtNationality.Text)
                    oCommand.Parameters.AddWithValue("@FPFReligion", frmUpdateFranchiseeProfile.txtReligion.Text)
                    oCommand.Parameters.AddWithValue("@FPFOccupation", frmUpdateFranchiseeProfile.txtOccupation.Text)
                    oCommand.Parameters.AddWithValue("@FPFMobileNum1", frmUpdateFranchiseeProfile.txtMobileNum1.Text)
                    oCommand.Parameters.AddWithValue("@FPFMobileNum2", frmUpdateFranchiseeProfile.txtMobileNum2.Text)
                    oCommand.Parameters.AddWithValue("@FPFTelNum1", frmUpdateFranchiseeProfile.txtTelNum1.Text)
                    oCommand.Parameters.AddWithValue("@FPFTelNum2", frmUpdateFranchiseeProfile.txtTelNum2.Text)
                    oCommand.Parameters.AddWithValue("@FPFFaxNum", frmUpdateFranchiseeProfile.txtFaxNumber.Text)
                    oCommand.Parameters.AddWithValue("@FPFEmailAdd1", frmUpdateFranchiseeProfile.txtEmailAddress1.Text)
                    oCommand.Parameters.AddWithValue("@FPFEmailAdd2", frmUpdateFranchiseeProfile.txtEmailAddress2.Text)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("@updateFranchisee:" + ex.Message)
            End Try
        End Using
        Return False
    End Function
#End Region

#Region "Outlet Methods"

    Public Function getUnOutlet() As List(Of clsOutlet)
        Dim outletList As List(Of clsOutlet) = New List(Of clsOutlet)
        Dim getOutlet As New clsOutlet

        Dim oQuery As String = "SELECT unOutlet FROM Outlet"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(oQuery, oConnection)
                    Dim oRead As SqlDataReader = oCom.ExecuteReader
                    While oRead.Read
                        getOutlet = New clsOutlet
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
        listOutlet = modProfiling.getUnOutlet()

        Try
            getUnOutlet = pnlMain.lvOutlet.FocusedItem.Tag
            For Each o In listOutlet
                If o.unOutlet = getUnOutlet Then
                    lblOutletID.Text = o.unOutlet
                End If
            Next
        Catch ex As Exception
            MsgBox("No selected item!")
            frmOutletDetails.Close()
        End Try

        Return listOutlet
    End Function

    Public Function getLatestOId() As Integer
        Dim getOutlet As New clsOutlet
        'Dim listOutlet As List(Of clsOutlet)
        Dim latestOId As Integer
        Dim oQuery As String = "SELECT TOP 1 unOutlet FROM Outlet ORDER BY unOutlet DESC"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
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

    Public Function deleteLatestUn(unO As Integer) As Boolean

        Dim oQuery As String = "DELETE FROM Outlet WHERE unOutlet=" & Val(unO)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(oQuery, oConnection)
                    oCom.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:deleteLatestUn() " + ex.Message)
            End Try
        End Using
        Return False
    End Function

    Public Function getOutletLocList(ByVal unF As Integer) As List(Of clsOutletLocation)
        Dim outletLocList As List(Of clsOutletLocation) = New List(Of clsOutletLocation)
        Dim ol As New clsOutletLocation
        Dim sQuery As String = "SELECT Outlet.unOutlet, Outlet.FPOBusinessUnit, Location.FPLLocationName, Location.FPLCurrentAddress, 
                                 Location.FPLDateOpened, Location.FPLStatus, Location.FPLStatusClosed, Location.FPLDateClosed, Location.FPLOldAddress
                                 FROM Outlet 
                                 JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                 JOIN Location On Location.unOutlet = Outlet.unOutlet
                                 Where Outlet.unFranchisee = @unFranchisee
                                 ORDER BY unOutlet DESC"
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    oCom.Parameters.AddWithValue("unFranchisee", unF)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        ol = New clsOutletLocation
                        ol.unOutlet = oRead("unOutlet")
                        ol.FPOBusinessUnit = oRead("FPOBusinessUnit")
                        ol.FPLLocationName = oRead("FPLLocationName")
                        ol.FPLCurrentAddress = oRead("FPLCurrentAddress")
                        ol.FPLDateOpened = oRead("FPLDateOpened")
                        ol.FPLStatus = oRead("FPLStatus")

                        If ol.FPLStatus = "Open" Then
                            ol.FPLStatusClosed = " "
                        Else
                            ol.FPLStatusClosed = oRead("FPLStatusClosed")
                        End If

                        ol.FPLDateClosed = oRead("FPLDateClosed")
                        ol.FPLOldAddress = oRead("FPLOldAddress")

                        outletLocList.Add(ol)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getOutletLocList() " + ex.Message)
            End Try
        End Using
        Return outletLocList
    End Function

    Public Function loadOutletLocation(ByVal unF As Integer)
        pnlMain.lvOutlet.Items.Clear()
        Dim listOL As List(Of clsOutletLocation) = modProfiling.getOutletLocList(unF)
        'l = modProfiling.getFranchiseeList

        Dim fl As List(Of clsFranchisee)
        fl = modProfiling.getFranchiseeList()

        For Each f In fl
            pnlMain.lblTotalActive.Text = f.totalactive
            pnlMain.lblTemporaryClosed.Text = f.totaltempclosed
            pnlMain.lblPermanentlyClosed.Text = f.totalpermclosed
        Next

        For Each item In listOL
            Dim lItem As New ListViewItem()
            lItem.Text = item.unOutlet
            lItem.SubItems.Add(item.FPOBusinessUnit)
            lItem.SubItems.Add(item.FPLLocationName)
            lItem.SubItems.Add(item.FPLCurrentAddress)
            lItem.SubItems.Add(item.FPLDateOpened)
            lItem.SubItems.Add(item.FPLStatus)
            lItem.SubItems.Add(item.FPLStatusClosed)
            lItem.SubItems.Add(item.FPLOldAddress)

            If item.FPLStatus = "Close" Then
                lItem.SubItems.Add(item.FPLDateClosed)

                frmOutletDetails.btnAddEnabled.Enabled = False
                frmOutletDetails.enabledConInfo(False)
                lItem.ForeColor = Color.Red
            Else
                frmOutletDetails.btnAddEnabled.Enabled = True
                frmOutletDetails.enabledConInfo(True)
            End If

            lItem.Tag = item.unOutlet

            pnlMain.lvOutlet.Items.Add(lItem)
            modProfiling.countOutlet(unF)
            modProfiling.updateCount(unF)
            modProfiling.displayCount(unF)
        Next
        Return listOL
    End Function

    Public Function getInfoOutletLocation(ByVal unO As Integer)
        Dim outletLocList As List(Of clsOutletLocation) = New List(Of clsOutletLocation)
        Dim ol As New clsOutletLocation
        Dim sQuery As String = "SELECT Outlet.unOutlet, Outlet.FPOBusinessUnit, Location.FPLLocationName, Location.FPLCurrentAddress, 
                                 Location.FPLDateOpened, Location.FPLStatus, Location.FPLStatusClosed, Location.FPLDateClosed, FPLOldAddress
                                 FROM Outlet 
                                 JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                 JOIN Location On Location.unOutlet = Outlet.unOutlet
                                 Where Outlet.unOutlet=" & Val(unO)
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    'oCom.Parameters.AddWithValue("unFranchisee", unO)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        ol = New clsOutletLocation
                        ol.unOutlet = oRead("unOutlet")
                        ol.FPOBusinessUnit = oRead("FPOBusinessUnit")
                        ol.FPLLocationName = oRead("FPLLocationName")
                        ol.FPLCurrentAddress = oRead("FPLCurrentAddress")
                        ol.FPLDateOpened = oRead("FPLDateOpened")
                        ol.FPLStatus = oRead("FPLStatus")
                        ol.FPLStatusClosed = oRead("FPLStatusClosed")
                        ol.FPLDateClosed = oRead("FPLDateClosed")
                        ol.FPLOldAddress = oRead("FPLOldAddress")

                        outletLocList.Add(ol)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getOutletLocList() " + ex.Message)
            End Try
        End Using
        Return outletLocList
    End Function

    Public Function updateInfoOutlet(ByVal unO As Integer) As Boolean
        Dim sQuery As String = "Update Outlet
                                Set FPOBusinessUnit = @FPOBusinessUnit
                                where unOutlet = " & Val(unO)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPOBusinessUnit", frmUpdateOutletDetails.cbBusinessUnit.Text)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function

    Public Function updateInfoLocation(ByVal unO As Integer, ByVal status As String) As Boolean
        Dim lStatusClosed As String
        Dim lRelocation As String
        Dim sQuery As String = "Update Location
                                Set FPLLocationName = @FPLLocationName, FPLCurrentAddress = @FPLCurrentAddress, 
                                FPLDateOpened = @FPLDateOpened,FPLStatus = @FPLStatus, FPLStatusClosed = @FPLStatusClosed, 
                                FPLDateClosed = @FPLDateClosed, FPLOldAddress = @FPLOldAddress
                                where unOutlet = " & Val(unO)

        If status = "Open" Then
            lStatusClosed = " "
            lRelocation = " "

        Else
            lStatusClosed = frmUpdateOutletDetails.cbStatusClosed.Text
            lRelocation = frmUpdateOutletDetails.txtRelocationAddress.Text
        End If


        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPLLocationName", frmUpdateOutletDetails.txtLocationName.Text)
                    oCommand.Parameters.AddWithValue("@FPLCurrentAddress", frmUpdateOutletDetails.txtOutletAddress.Text)
                    oCommand.Parameters.AddWithValue("@FPLDateOpened", frmUpdateOutletDetails.dtpDateOpened.Value)
                    oCommand.Parameters.AddWithValue("@FPLStatus", status)
                    oCommand.Parameters.AddWithValue("@FPLStatusClosed", lStatusClosed)
                    oCommand.Parameters.AddWithValue("@FPLOldAddress", lRelocation)
                    oCommand.Parameters.AddWithValue("@FPLDateClosed", frmUpdateOutletDetails.dtpCloseDate.Value.Date)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function

    Public Function displayInfoOutletLocation()

        Dim state As Boolean
        Try

            Dim ol As List(Of clsOutletLocation)
            Dim focOutletUn As Integer = pnlMain.lvOutlet.FocusedItem.Tag
            ol = modProfiling.getInfoOutletLocation(focOutletUn)

            For Each o In ol
                If o.unOutlet = focOutletUn Then
                    frmUpdateOutletDetails.cbBusinessUnit.Text = o.FPOBusinessUnit
                    frmUpdateOutletDetails.txtLocationName.Text = o.FPLLocationName
                    frmUpdateOutletDetails.txtOutletAddress.Text = o.FPLCurrentAddress
                    frmUpdateOutletDetails.dtpDateOpened.Value = o.FPLDateOpened
                    If o.FPLStatus = "Open" Then
                        state = True
                    Else
                        state = False
                    End If
                    frmUpdateOutletDetails.cbStatusOutlet.Checked = state
                    frmUpdateOutletDetails.cbStatusClosed.Text = o.FPLStatusClosed
                    frmUpdateOutletDetails.dtpCloseDate.Value = o.FPLDateClosed
                    frmUpdateOutletDetails.txtRelocationAddress.Text = o.FPLOldAddress

                    frmUpdateOutletDetails.ShowDialog()
                End If
            Next

        Catch ex As Exception
            MsgBox("No selected item!")
        End Try
    End Function

    Public Function outletRemarks(ByVal unO As Integer) As Boolean
        '
        Dim uQuery As String = "Update Outlet 
                                Set FPORemarks = @FPORemarks 
                                Where unOutlet=" & Val(unO)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(uQuery, oConnection)
                    oCommand.Parameters.AddWithValue("@FPORemarks", frmAddNewOutlet.txtOutletRemarks.Text)
                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("@addOutlet()" + ex.Message)
            End Try
        End Using
        Return False
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

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("unOutlet", unO)

                    Dim oRead As SqlDataReader = oCommand.ExecuteReader

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

    Public Function getConList(unC As Integer) As List(Of clsContract)
        Dim contractList As List(Of clsContract) = New List(Of clsContract)
        Dim getContract As New clsContract
        Dim sQuery As String = "SELECT unContract, FPCStartTerm, FPCEndTerm, FPCRemark 
                                FROM Contract  
                                WHERE unContract =" & Val(unC)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    Dim oRead As SqlDataReader = oCom.ExecuteReader

                    While oRead.Read
                        getContract = New clsContract
                        'getContract.unContract = oRead("unContract")
                        getContract.unContract = oRead("unContract")
                        getContract.FPCStartTerm = oRead("FPCStartTerm")
                        getContract.FPCEndTerm = oRead("FPCEndTerm")
                        getContract.FPCRemark = oRead("FPCRemark")

                        contractList.Add(getContract)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @:getConList() " + ex.Message)
            End Try
        End Using
        Return contractList
    End Function

    Public Function displayCon(unC As Integer) As Boolean
        Dim focItemUn As Integer = frmOutletDetails.lvContract.Tag
        Dim cl As List(Of clsContract) = modProfiling.getConList(unC)
        'Dim frm As frmOutletDetails... d gid ni pag gamita gina gago yaka
        For Each o In cl
            If o.idContract = focItemUn Then
                'frmOutletDetails.lblUnContract.Text = o.unContract
                frmOutletDetails.dtpStartTerm.Value = o.FPCStartTerm
                frmOutletDetails.dtpEndTerm.Value = o.FPCEndTerm
                frmOutletDetails.txtRemarks.Text = o.FPCRemark

                Return True
            End If
        Next
        Return False
    End Function

    Public Function updateContract(unC As Integer)
        Dim cQuery As String = "UPDATE Contract SET FPCStartTerm=@FPCStartTerm, FPCEndTerm=@FPCEndTerm, FPCRemark=@FPCRemark
                                WHERE unContract =" & Val(unC)
        'Dim listContract As List(Of clsContract) = modProfiling.getConList(unC)
        'Dim getContract As New clsContract
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(cQuery, oConnection)
                    With oCommand
                        .Parameters.AddWithValue("@FPCStartTerm", frmOutletDetails.dtpStartTerm.Value)
                        .Parameters.AddWithValue("@FPCEndTerm", frmOutletDetails.dtpEndTerm.Value)
                        .Parameters.AddWithValue("@FPCRemark", frmOutletDetails.txtRemarks.Text)
                        .ExecuteNonQuery()
                    End With
                End Using
            Catch ex As Exception
                MsgBox("@updateContract:" + ex.Message)
            End Try
        End Using
    End Function



#End Region

#Region "Package"

    Public Function getPackageList(unO As Integer) As List(Of clsPackage)
        Dim packageList As List(Of clsPackage) = New List(Of clsPackage)
        Dim getPackage As New clsPackage
        Dim sQuery As String = "SELECT Package.unOutlet, FPPPackageType, FPPFranchiseFee, FPPPackageFee, FPPSecurityDeposit, FPPDateOfRefund, FPPFranchiseRemark, FPPPackageRemark, FPPDepositRemark
                                FROM Package
                                INNER JOIN Outlet On Package.unOutlet = Outlet.unOutlet where Outlet.unOutlet = @unOutlet"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
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
                frmUpdatePackage.dtpDateOfRefund.Value = o.FPPDateOfRefund
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

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
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

    Public Function displayImage(ByVal focItem As Integer, ByVal pb As PictureBox)
        Dim sQuery As String = "Select FPFImage from Franchisee where unFranchisee=" & Val(focItem)

        Using oConnection As New SqlConnection(getConnection("FranchiseMasterFile"))
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

    Public Function countOutlet(unF As Integer) As Boolean
        Dim ctOutlet As Integer
        Dim sQuery As String = "SELECT COUNT (Outlet.unOutlet)
                                FROM Outlet 
                                JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                JOIN Location On Location.unOutlet = Outlet.unOutlet
                                Where Outlet.unFranchisee = " & Val(unF)

        Using oConnection As New SqlConnection(getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    ctOutlet = Convert.ToInt32(oCom.ExecuteScalar())
                    pnlMain.lblTotalOutlets.Text = ctOutlet
                    Return True
                End Using
            Catch ex As Exception
                MsgBox("@countOutlet " + ex.Message)
            End Try
        End Using
        Return False
    End Function


    'Put in Updates
    Public Function countOutletActive(unF As Integer) As Integer
        Dim ctOutlet As Integer
        Dim sQuery As String = "SELECT COUNT (Outlet.unOutlet)
                                FROM Outlet 
                                JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                JOIN Location On Location.unOutlet = Outlet.unOutlet
                                Where Location.FPLStatus = 'Open' AND Outlet.unFranchisee =" & Val(unF)

        Using oConnection As New SqlConnection(getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    ctOutlet = Convert.ToInt32(oCom.ExecuteScalar())

                    Return ctOutlet
                End Using
            Catch ex As Exception
                MsgBox("@countOutlet " + ex.Message)
            End Try
        End Using
    End Function

    Public Function countOutletTemp(unF As Integer) As Integer
        Dim ctOutlet As Integer
        Dim sQuery As String = "SELECT COUNT (Outlet.unOutlet)
                                FROM Outlet 
                                JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                JOIN Location On Location.unOutlet = Outlet.unOutlet
                                Where Location.FPLStatusClosed = 'Temporary' AND Outlet.unFranchisee =" & Val(unF)

        Using oConnection As New SqlConnection(getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    ctOutlet = Convert.ToInt32(oCom.ExecuteScalar())

                    Return ctOutlet
                End Using
            Catch ex As Exception
                MsgBox("@countOutlet " + ex.Message)
            End Try
        End Using

    End Function

    Public Function countOutletPerm(unF As Integer) As Integer
        Dim ctOutlet As Integer
        Dim sQuery As String = "SELECT COUNT (Outlet.unOutlet)
                                FROM Outlet 
                                JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                JOIN Location On Location.unOutlet = Outlet.unOutlet
                                Where Location.FPLStatusClosed = 'Permanent' AND Outlet.unFranchisee =" & Val(unF)

        Using oConnection As New SqlConnection(getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCom As New SqlCommand(sQuery, oConnection)

                    ctOutlet = Convert.ToInt32(oCom.ExecuteScalar())

                    Return ctOutlet
                End Using
            Catch ex As Exception
                MsgBox("@countOutlet " + ex.Message)
            End Try
        End Using
        Return False
    End Function



    'Public Sub SwapListViewItems(index1 As Integer)
    '    Dim item1 = pnlMain.lvUserProfile.Items(index1)
    '    Dim item2 = pnlMain.lvUserProfile.Items(index1 + 1)

    '    Dim text As String

    '    For i = 0 To item1.SubItems.Count - 1
    '        Dim subitem1 = item1.SubItems(i)
    '        Dim subitem2 = item2.SubItems(i)

    '        text = subitem1.Text
    '        subitem1.Text = subitem2.Text
    '        subitem2.Text = text
    '    Next
    'End Sub

    Public Function updateCount(unF As Integer) As Boolean


        Dim sQuery As String = "Update Franchisee
                                Set FPFTotalActive = @FPFTotalActive, FPFTotalTempClosed = @FPFTotalTempClosed, FPFTotalPermClosed = @FPFTotalTempClosed
                                FROM Outlet 
                                JOIN Franchisee On Outlet.unFranchisee = Franchisee.unFranchisee 
                                JOIN Location On Location.unOutlet = Outlet.unOutlet
                                Where Outlet.unFranchisee = " & Val(unF)

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPFTotalActive", countOutletActive(unF))
                    oCommand.Parameters.AddWithValue("@FPFTotalTempClosed", countOutletTemp(unF))
                    oCommand.Parameters.AddWithValue("@FPFTotalPermClosed", countOutletPerm(unF))

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("@updateCount" + ex.Message)
            End Try
        End Using
        Return False
    End Function

    Public Function displayCount(unF As Integer) As Boolean
        Try
            pnlMain.lblTotalActive.Text = countOutletActive(unF)
            pnlMain.lblTemporaryClosed.Text = countOutletTemp(unF)
            pnlMain.lblPermanentlyClosed.Text = countOutletPerm(unF)

            Return True
        Catch ex As Exception
            MsgBox("@displayCount" + ex.Message)
        End Try
        Return False
    End Function

End Module
