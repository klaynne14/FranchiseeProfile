Imports System.Data.SqlClient
Public Class clsOutlet
    Public idOutlet As Integer
    Public unOutlet As Integer
    Public FPOBusinessUnit As String
    Public idPackage As Integer
    Public idContract As Integer
    Public idLocation As Integer

    Public Function addOutlet() As Boolean
        Dim sQuery As String = "INSERT INTO Outlet (FPOBusinessUnit, idPackage, idContract, idLocation)
                                VALUES (@FPOBusinessUnit, @idPackage, @idContract, @idLocation)"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPOBusinessUnit", Me.FPOBusinessUnit)
                    oCommand.Parameters.AddWithValue("@idPackage", Me.idPackage)
                    oCommand.Parameters.AddWithValue("@idContract", Me.idContract)
                    oCommand.Parameters.AddWithValue("@idLocation", Me.idLocation)

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
