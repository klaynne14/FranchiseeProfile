Imports System.Data.SqlClient

Public Class frmOutletDetails

    Public Function enabledConInfo(state As Boolean)
        dtpStartTerm.Enabled = state
        dtpEndTerm.Enabled = state
        txtRemarks.Enabled = state
    End Function

    Private Sub frmAddContract_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        modProfiling.getfocusedOId(lblOutletID)

        Dim unO As Integer = lblOutletID.Text
        Try
            modProfiling.displayContract(unO)
            modProfiling.displayInfoPackage(unO)
        Catch ex As Exception
            Me.Close()
        End Try
        'Dim outCls As clsOutlet = New clsOutlet
        Dim sQuery As String = "Select FPORemarks From Outlet Where unOutlet=" & Val(unO)
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()
                Using oCommand As New SqlCommand(sQuery, oConnection)
                    Dim oRead As SqlDataReader = oCommand.ExecuteReader
                    While oRead.Read
                        lblOutletRemarks.Text = oRead("FPORemarks")
                    End While
                End Using
            Catch ex As Exception

            End Try
        End Using

        btnAddEnabled.Show()

        If btnAddEnabled.Enabled = True Then
            enabledConInfo(False)
        End If

        btnAddContract.Hide()
        btnUpdateContact.Enabled = False
    End Sub

    Private Sub BtnAddContract_Click(sender As Object, e As EventArgs) Handles btnAddContract.Click
        Dim ac As clsContract = New clsContract

        ac.FPCStartTerm = dtpStartTerm.Value.Date
        ac.FPCEndTerm = dtpEndTerm.Value.Date
        ac.FPCRemark = txtRemarks.Text
        ac.unOutlet = lblOutletID.Text

        If ac.FPCRemark = Nothing Then
            MsgBox("Please fill up remark")
        Else
            If ac.addContract() Then
                'modProfiling.getLatestCId()
                'MessageBox.Show(modProfiling.getLatestCId().ToString)
                Dim unO As Integer = ac.unOutlet
                modProfiling.displayContract(unO)
                enabledConInfo(False)
                btnAddContract.Hide()
                btnAddEnabled.Show()
                clearText()
            End If
        End If

    End Sub

    Public Function clearText()
        dtpStartTerm.Value = Now
        dtpEndTerm.Value = Now
        txtRemarks.Clear()
    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEditPackage.LinkClicked
        Dim unO As Integer = lblOutletID.Text
        modProfiling.getInfoPackage(unO)
        frmUpdatePackage.ShowDialog()
    End Sub

    Private Sub BtnApply_click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.Close()
    End Sub

    Private Sub lvContract_DoubleClick(sender As Object, e As EventArgs) Handles lvContract.DoubleClick
        Dim unC As Integer = Me.lvContract.FocusedItem.Tag
        modProfiling.displayCon(unC)
        btnAddContract.Enabled = True
        btnAddEnabled.Enabled = False
        btnUpdateContact.Enabled = True
        enabledConInfo(True)
    End Sub

    Private Sub BtnUpdateContact_Click(sender As Object, e As EventArgs) Handles btnUpdateContact.Click
        Dim unC As Integer = lvContract.FocusedItem.Tag
        modProfiling.updateContract(unC)
        Me.frmAddContract_Load(sender, e)
        If btnUpdateContact.Enabled = False Then
            btnAddEnabled.Enabled = True
            enabledConInfo(False)

        End If
        clearText()
    End Sub

    Private Sub BtnAddEnabled_Click(sender As Object, e As EventArgs) Handles btnAddEnabled.Click
        enabledConInfo(True)


        btnAddEnabled.Hide()
        btnAddContract.Show()
    End Sub
End Class