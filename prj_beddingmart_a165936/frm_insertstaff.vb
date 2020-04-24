Public Class frm_insertstaff
    Private Sub frm_insertstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_id.Text = generate_staff_id()
        lbl_date.Text = Date.Now

    End Sub

    Private Sub refresh_grid()


        Dim mysql As String = "SELECT * FROM TBL_STAFF_A165936"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable



    End Sub

    Private Function generate_staff_id() As String
        Dim laststaffid As String = run_sql_query("SELECT MAX(STAFF_ID) AS LASTSTAFF FROM TBL_STAFF_A165936").Rows(0).Item("LASTSTAFF")

        Dim newstaffid As String = "S" & Mid(laststaffid, 2) + 1
        Return newstaffid
    End Function


    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A165936 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

            Beep()
            MsgBox("Your new staff has been recorded successfully!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updatestaff.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class