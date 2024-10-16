Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module SQLCON
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public qry As String
    Public adp As New MySqlDataAdapter

    Public Sub connect()
        Dim myConString As String
        myConString = "server=localhost;" _
            & "uid=root;" _
            & "pwd=Admin123;" _
            & "database=feedmill"
        conn = New MySqlConnection(myConString)


        'Try

        '    conn.Open()
        '    cmd = conn.CreateCommand

        '    cmd.CommandText = "SELECT * FROM formula WHERE ID='1'"

        '    dr = cmd.ExecuteReader()
        '    If dr.HasRows Then
        '        MsgBox("Connected to Database", vbExclamation, "Feedmill Batching System")
        '    End If

        '    conn.Close()
        '    conn.Dispose()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

End Module
