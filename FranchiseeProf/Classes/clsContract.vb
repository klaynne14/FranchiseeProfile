Imports System.Data.SqlClient
Public Class clsContract
    Public idContract As Integer
    Public unContract As Integer
    Public FPCStartTerm As DateTime
    Public FPCEndTerm As DateTime
    Public FPCRemark As String

    Public Function addContract() As Boolean
        Dim sQuery As String = "INSERT INTO Contract(unContract, FPCStartTerm, FPCEndTerm, FPCRemark)
                                VALUES (((SELECT COUNT(*) FROM contract)+ 1), @FPCStartTerm, @FPCEndTerm, @FPCRemark)"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPCStartTerm", Me.FPCStartTerm)
                    oCommand.Parameters.AddWithValue("@FPCEndTerm", Me.FPCEndTerm)
                    oCommand.Parameters.AddWithValue("@FPCRemark", Me.FPCRemark)

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
