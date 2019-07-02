Imports System.Data.SqlClient

Module modGeneral

    Public Function getConnection(database As String) As String
        Return "data source=192.168.9.102,1433;uid=sa;pwd=intok;Initial Catalog = " & database
    End Function

End Module
