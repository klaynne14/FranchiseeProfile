﻿Imports System.Data.SqlClient

Public Class clsPackage
    Public idPackage As Integer
    Public unPackage As Integer
    Public FPPPackageType As String
    Public FPPFranchiseFee As Integer
    Public FPPPackageFee As Integer
    Public FPPSecurityDeposit As Integer
    Public FPPDateOfRefund As Date
    Public FPPFranchiseRemark As String
    Public FPPPackageRemark As String
    Public FPPDepositRemark As String
    Public unOutlet As Integer

    Public Function addPackage() As Boolean
        Dim sQuery As String = "INSERT INTO Package(unPackage, FPPPackageType, FPPFranchiseFee, FPPPackageFee, FPPSecurityDeposit,
                                FPPFranchiseRemark, FPPPackageRemark, FPPDepositRemark, unOutlet)

                                VALUES (((SELECT COUNT(*) FROM Package)+ 1), @FPPPackageType, @FPPFranchiseFee, @FPPPackageFee, @FPPSecurityDeposit,
                                @FPPFranchiseRemark, @FPPPackageRemark, @FPPDepositRemark, @unOutlet)"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseMasterFile"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPPPackageType", Me.FPPPackageType)
                    oCommand.Parameters.AddWithValue("@FPPFranchiseFee", Me.FPPFranchiseFee)
                    oCommand.Parameters.AddWithValue("@FPPPackageFee", Me.FPPPackageFee)
                    oCommand.Parameters.AddWithValue("@FPPSecurityDeposit", Me.FPPSecurityDeposit)
                    'oCommand.Parameters.AddWithValue("@FPPDateOfRefund", Me.FPPDateOfRefund)
                    oCommand.Parameters.AddWithValue("@FPPFranchiseRemark", Me.FPPFranchiseRemark)
                    oCommand.Parameters.AddWithValue("@FPPPackageRemark", Me.FPPPackageRemark)
                    oCommand.Parameters.AddWithValue("@FPPDepositRemark", Me.FPPDepositRemark)
                    oCommand.Parameters.AddWithValue("@unOutlet", Me.unOutlet)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function

End Class
