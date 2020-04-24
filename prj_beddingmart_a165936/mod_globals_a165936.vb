Imports System.Text
Imports System.Data.OleDb

Module mod_globals_a165936
    Public username As String
    Public userid As String
    Public fail_sql As String
    Public filename_rand As String

    Public temp_id As String
    Public temp_name As String
    Public temp_quantity As Integer
    Public temp_price As Double
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB_BEDDINGMART_A165936.accdb; Persist Security Info = False"

    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Function run_sql_query(mysql As String) As DataTable

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try

            myreader.Fill(mydatatable)

        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return mydatatable

    End Function

    Public Sub run_sql_command(thissql As String)
        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub

    Public Sub generate_file_rand()
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 10
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i

        filename_rand = sb.ToString()
    End Sub

End Module
