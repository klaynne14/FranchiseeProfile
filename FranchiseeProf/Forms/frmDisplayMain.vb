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
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getlistview()
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
        ' getlistview()
        Dim i As Integer
        i = lvUserProfile.FocusedItem.Index + 1

        For Each o In l
            If o.idFranchisee = i Then
                MsgBox("ID: " + Convert.ToString(o.idFranchisee) + " Fullname: " + o.FName + " " + o.MName + " " + o.LName)

            End If
        Next



        'If lvUserProfile.SelectedItems.Count < 1 Then Return
        'lvUserProfile.SelectedItems(0).Tag
    End Sub

    Public Function getlistview() As Boolean

        Dim fslvQuery As String = "Select idFranchisee,FPFName From Franchisee where idFranchisee = @idFranchisee"
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(fslvQuery, oConnection)
                    Dim oReader As SqlDataReader = oCommand.ExecuteReader

                    While oReader.Read

                        lblIDFranchisee.Text = oReader("idFranchisee")
                        lblFullName.Text = oReader("FPFName")

                    End While
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error @getlistview() " + ex.Message)
            End Try
        End Using
        Return False
    End Function

    Private Sub lvUserProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUserProfile.SelectedIndexChanged


    End Sub
End Class