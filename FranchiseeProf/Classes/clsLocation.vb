Imports System.Data.SqlClient
Public Class clsLocation
    Public idLocation As Integer
    Public unLocation As Integer
    Public FPLLocationName As String
    Public FPLCurrentAddress As String
    Public FPLOldAddress As String
    Public FPLDateOpened As Date
    Public FPLDateClosed As Date
    Public FPLStatus As String
    Public FPLStatusClosed As String
    Public unOutlet As Integer

    Public Function addLocation() As Boolean
        Dim sQuery As String = "INSERT INTO Location (unLocation, FPLLocationName, FPLCurrentAddress, FPLOldAddress, FPLDateOpened, FPLStatus, unOutlet)
                                VALUES (((SELECT COUNT(*) FROM Location)+ 1),@FPLLocationName, @FPLCurrentAddress, @FPLOldAddress, @FPLDateOpened, @FPLStatus, @unOutlet)"
        Dim ol As New clsOutletLoc
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPLLocationName", Me.FPLLocationName)
                    oCommand.Parameters.AddWithValue("@FPLCurrentAddress", Me.FPLCurrentAddress)
                    oCommand.Parameters.AddWithValue("@FPLOldAddress", Me.FPLOldAddress)
                    oCommand.Parameters.AddWithValue("@FPLDateOpened", Me.FPLDateOpened)
                    oCommand.Parameters.AddWithValue("@FPLStatus", Me.FPLStatus)
                    oCommand.Parameters.AddWithValue("@unOutlet", Me.unOutlet)

                    oCommand.ExecuteNonQuery()
                    ol.mergeList()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message + "@addLocation()")
            End Try
        End Using
        Return False
    End Function
End Class
