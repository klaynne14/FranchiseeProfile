Imports System.Data.SqlClient

Module modGeneral

    Public Function getConnection(database As String) As String
        Return "data source=localhost,1433;uid=sa;pwd=intok;Initial Catalog = " & database
    End Function

End Module
