Imports System.Data.SqlClient
Public Class clsLocation
    Public idLocation As Integer
    Public unLocation As Integer
    Public FPLLocationName As String
    Public FPLCurrentAddress As String
    Public FPLOldAddress As String
    Public FPLDateOpened As DateTime
    Public FPLDateClosed As DateTime
    Public FPLStatus As String
    Public FPLStatusClosed As String

    Public Function addLocation() As Boolean
        Dim sQuery As String = "INSERT INTO Location (FPLLocationName, FPLCurrentAddress, FPLOldAddress, FPLDateOpened, FPLStatus)
                                VALUES (@FPLLocationName, @FPLCurrentAddress, @FPLOldAddress, @FPLDateOpened, @FPLStatus)"

        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPLLocationName", Me.FPLLocationName)
                    oCommand.Parameters.AddWithValue("@FPLCurrentAddress", Me.FPLCurrentAddress)
                    oCommand.Parameters.AddWithValue("@FPLOldAddress", Me.FPLOldAddress)
                    oCommand.Parameters.AddWithValue("@FPLDateOpened", Me.FPLDateOpened)
                    oCommand.Parameters.AddWithValue("@FPLStatus", Me.FPLStatus)

                    oCommand.ExecuteNonQuery()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message + "@addLocation()")
            End Try
        End Using
        Return False
    End Function
End Class
