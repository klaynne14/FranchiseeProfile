Imports System.Data.SqlClient

Module modGeneral
    'Open Connection to database
    Public Function getConnection(database As String) As String
        Return "data source=10.1.1.11;uid=sa;pwd=intok;Initial Catalog = " & database
        'Return "data source=192.168.9.102;uid=sa;pwd=intok;Initial Catalog = " & database
        'Return "data source=DESKTOP-C9VIMER\SQLEXPRESS;uid=sa;pwd=intok;Initial Catalog = " & database
    End Function
End Module
