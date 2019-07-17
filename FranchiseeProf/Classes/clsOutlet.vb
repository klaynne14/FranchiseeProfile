Imports System.Data.SqlClient
Public Class clsOutlet


    Public idOutlet As Integer
    Public unOutlet As Integer
    Public FPOBusinessUnit As String
    Public unPackage As Integer
    Public unContract As Integer
    Public unLocation As Integer
    Public unFranchisee As String

    Public Function addOutlet() As Boolean
        Dim sQuery As String = "INSERT INTO Outlet (unOutlet, FPOBusinessUnit, unFranchisee)
                                VALUES (((SELECT COUNT(*) FROM Outlet)+ 110000001), @FPOBusinessUnit, @unFranchisee)"
        Dim ol As New clsOutletLoc
        Using oConnection As New SqlConnection(modGeneral.getConnection("FranchiseProfiling"))
            Try
                oConnection.Open()

                Using oCommand As New SqlCommand(sQuery, oConnection)

                    oCommand.Parameters.AddWithValue("@FPOBusinessUnit", Me.FPOBusinessUnit)
                    oCommand.Parameters.AddWithValue("@unFranchisee", Me.unFranchisee)

                    oCommand.ExecuteNonQuery()
                    ol.mergeList()
                    Return True
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return False
    End Function

End Class
