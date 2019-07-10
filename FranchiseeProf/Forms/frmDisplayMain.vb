Imports System.Data.SqlClient

Public Class pnlMain

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        modProfiling.loadFranchisee()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size

        Dim List As List(Of clsFranchisee) = modProfiling.getFranchisee
        Dim autoComp As AutoCompleteStringCollection = New AutoCompleteStringCollection


        For Each item As clsFranchisee In List
            autoComp.Add(item.FName + item.MName + item.LName)
        Next
        txtSearchBar.AutoCompleteCustomSource = autoComp
    End Sub

    Private Sub BtnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmCreateNewFranchisee.ShowDialog()
        'modProfiling.loadFranchisee()
    End Sub

    Private Sub BtnAddNewOutletMain_Click(sender As Object, e As EventArgs) Handles btnAddNewOutletMain.Click
        frmAddNewOutlet.lblOutletUn.Text = lblIDFranchisee.Text
        frmAddNewOutlet.ShowDialog()
        modProfiling.clearText()
    End Sub

    Dim l As List(Of clsFranchisee)
    Private Sub lvUserProfile_DoubleClick(sender As Object, e As EventArgs) Handles lvUserProfile.DoubleClick
        pnlInfo.Show()

        Dim i As Integer
        i = lvUserProfile.FocusedItem.Index + 1
        l = modProfiling.getFranchiseeList

        For Each o In l
            If o.idFranchisee = i Then
                lblFullName.Text = o.FName + " " + o.MName + " " + o.LName
                lblIDFranchisee.Text = o.idFranchisee
                lblFPFStatus.Text = o.Status
                lblGender.Text = o.Gender
                lblAddress1.Text = o.Address1
                lblAddress2.Text = o.Address2
                lblAge.Text = o.Age
                lblCivilStatus.Text = o.CivilStatus
                lblDateOfBirth.Text = o.DateOfBirth
                lblNationality.Text = o.Nationality
                lblReligion.Text = o.Religion
                lblTelNum1.Text = o.TelNumber1
                lblTelNum2.Text = o.TelNumber2
                lblMobileNum1.Text = o.MobileNumber1
                lblMobileNum2.Text = o.MobileNumber1
                lblEmailAdd1.Text = o.EmailAdd1
                lblEmailAdd2.Text = o.EmailAdd2
            End If
        Next

        If lblFPFStatus.Text = "-1" Then
            lblFPFStatus.Text = "Active"
            lblFPFStatus.ForeColor = Color.Green
            btnAddNewOutletMain.Enabled = True
            btnAddNewOutletMain.BackColor = Color.Teal
        Else
            lblFPFStatus.Text = "Inactive"
            lblFPFStatus.ForeColor = Color.Red
            btnAddNewOutletMain.Enabled = False
            btnAddNewOutletMain.BackColor = Color.LightGray
        End If

        Dim FranchiseeID As String = lblIDFranchisee.Text
        modProfiling.displayOutlet(FranchiseeID)
    End Sub

    Private Sub BtnSelectedOutlet_Click(sender As Object, e As EventArgs) Handles btnSelectedOutlet.Click
        frmAddContract.ShowDialog()
    End Sub

    Private Sub txtSearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchBar.KeyDown

    End Sub
End Class