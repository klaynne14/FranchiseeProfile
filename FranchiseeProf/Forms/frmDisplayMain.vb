Imports System.Data.SqlClient

Public Class pnlMain

    Dim l As List(Of clsFranchisee)

    Private Sub loadFrnchisee()
        lvUserProfile.Items.Clear()
        Dim listFs As List(Of clsFranchisee) = modProfiling.getFranchiseeList
        l = modProfiling.getFranchiseeList

        For Each item In listFs
            Dim oItem As New ListViewItem()
            oItem.Text = item.idFranchisee
            oItem.SubItems.Add(item.FName + " " + item.MName + " " + item.LName)
            oItem.Tag = item.idFranchisee

            lvUserProfile.Items.Add(oItem)
            If item.Status = "0" Then
                oItem.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'getlistview()
        loadFrnchisee()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub BtnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmCreateNewFranchisee.ShowDialog()
        loadFrnchisee()
    End Sub

    Private Sub BtnAddNewOutletMain_Click(sender As Object, e As EventArgs) Handles btnAddNewOutletMain.Click
        frmAddNewOutlet.ShowDialog()
    End Sub

    Private Sub lvUserProfile_DoubleClick(sender As Object, e As EventArgs) Handles lvUserProfile.DoubleClick

        Dim i As Integer
        i = lvUserProfile.FocusedItem.Index + 1

        For Each o In l
            If o.idFranchisee = i Then
                lblFullName.Text = o.FName + " " + o.MName + " " + o.LName
                lblIDFranchisee.Text = o.idFranchisee
                lblFPFStatus.Text = o.Status
                lblGender.Text = o.Gender
            End If
        Next

        If lblFPFStatus.Text = "-1" Then
            lblFPFStatus.Text = "Active"
            lblFPFStatus.ForeColor = Color.Green
        Else
            lblFPFStatus.Text = "Inactive"
            lblFPFStatus.ForeColor = Color.Red
        End If
    End Sub

End Class