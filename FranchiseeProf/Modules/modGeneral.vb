Imports System.Data.SqlClient

Module modGeneral
    'Open Connection to database
    Public Function getConnection(database As String) As String
        Return "data source=DESKTOP-C9VIMER\SQLEXPRESS;uid=sa;pwd=intok;Initial Catalog = " & database
    End Function
End Module
