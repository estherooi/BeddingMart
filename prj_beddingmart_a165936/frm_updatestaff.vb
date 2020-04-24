Public Class frm_updatestaff
    Dim current_code As String

    Private Sub frm_updatestaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A165936")
        get_current_code()

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "STAFF NAME"

        lbl_date.Text = Date.Now
    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value

    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A165936 SET STAFF_NAME='" & txt_name.Text & "'WHERE STAFF_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")


        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A165936")

        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A165936 WHERE STAFF_ID='" & current_code & "'")

            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A165936")
            clear_fields()
            get_current_code()

        End If

        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A165936")

        clear_fields()
        get_current_code()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_staff.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub


End Class