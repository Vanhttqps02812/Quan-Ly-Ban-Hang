Imports System.Data.SqlClient

Module ModuleConnect
    Public ds As New DataSet

    '---Kết nối database trên local---
    Public Connectionstring As String = "Data Source=DESKTOP-M1N5O8F\SQLEXPRESS;Initial Catalog=QL_Ban_Hang;Integrated Security=True"


    Public Sub ExecuteNonQuery(sql As String)
        Dim Connection As New SqlConnection(Connectionstring)
        Dim Command As New SqlCommand(sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Connect(sql As String, TableName As String)
        Dim Connection As New SqlConnection(Connectionstring)
        Dim DataAdapter As New SqlDataAdapter(sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
        Connection.Close()
    End Sub

End Module
