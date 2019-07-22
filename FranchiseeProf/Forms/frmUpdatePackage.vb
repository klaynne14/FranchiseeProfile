Public Class frmUpdatePackage

#Region "Package Type"
    Public Enum PackageType
        Customize
        Standard
        School
        Counter
        SchoolCounter
    End Enum

    Public Sub setPackageType(packageState As PackageType)
        Select Case packageState
            Case PackageType.Customize
                txtPackageFee.Text = "50000"
                txtFranchiseeFee.Text = "110000"
                txtSecurityDeposit.Text = "50000"

            Case PackageType.Standard
                txtPackageFee.Text = "50000"
                txtFranchiseeFee.Text = "200000"
                txtSecurityDeposit.Text = "50000"


            Case PackageType.School
                txtPackageFee.Text = "20000"
                txtFranchiseeFee.Text = "80000"
                txtSecurityDeposit.Text = "20000"

            Case PackageType.Counter
                txtPackageFee.Text = "50000"
                txtFranchiseeFee.Text = "0"
                txtSecurityDeposit.Text = "0"

            Case PackageType.SchoolCounter
                txtPackageFee.Text = "20000"
                txtFranchiseeFee.Text = "55000"
                txtSecurityDeposit.Text = "20000"

        End Select
    End Sub
#End Region
    Private Sub BtnUpdatePackage_Click(sender As Object, e As EventArgs) Handles btnUpdatePackage.Click
        Dim uno As Integer = lblOutletID.Text
        If updateInfoPackage(uno) Then
            MsgBox("Package updated!")
            modProfiling.displayInfoPackage(uno)
            Me.Close()
        End If
    End Sub

    Private Sub CbPackageType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPackageType.SelectedIndexChanged
        If cbPackageType.Text = "School" Then
            setPackageType(PackageType.School)
        ElseIf cbPackageType.Text = "Customize" Then
            setPackageType(PackageType.Customize)
        ElseIf cbPackageType.Text = "Standard" Then
            setPackageType(PackageType.Standard)
        ElseIf cbPackageType.Text = "School-Counter" Then
            setPackageType(PackageType.SchoolCounter)
        ElseIf cbPackageType.Text = "Counter" Then
            'setPackageType(PackageType.Counter)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class