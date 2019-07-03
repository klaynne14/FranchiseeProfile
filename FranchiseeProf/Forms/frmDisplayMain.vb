Public Class pnlMain

    Private Sub loadFrnchisee()
        Dim listFs As List(Of clsFranchisee) = modGeneral.getFranchiseeList

        For Each item In listFs
            Dim oItem As New ListViewItem(item.idFranchisee)
            oItem.SubItems.Add(item.FName + " " + item.MName + " " + item.LName)
            'oItem.SubItems.Add(item.LName)
            oItem.Tag = item

            lvUserProfile.Items.Add(oItem)
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFrnchisee()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

    Private Sub BtnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        frmCreateNewFranchisee.Show()

    End Sub

    Private Sub BtnAddNewOutletMain_Click(sender As Object, e As EventArgs) Handles btnAddNewOutletMain.Click
        frmAddNewOutlet.Show()

    End Sub

End Class