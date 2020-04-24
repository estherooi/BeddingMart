Public Class frm_order_add_staff
    Dim mysql As String
    Dim current_code As String

    Private Sub frm_order_add_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysql = "SELECT * FROM TBL_STAFF_A165936"
        refresh_grid()
        get_current_record()
    End Sub

    Private Sub refresh_grid()

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "Staff ID"
        grd_customer.Columns(1).HeaderText = "Staff Name"


    End Sub

    Private Sub get_current_record()


        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_code = grd_customer(0, current_row).Value

        txt_selected.Text = "[Staff ID : " & current_code & "] Staff Name : " & grd_customer(1, current_row).Value
        temp_id = current_code
        temp_name = grd_customer(1, current_row).Value


    End Sub


    Private Sub grd_customer_Click(sender As Object, e As EventArgs) Handles grd_customer.Click
        get_current_record()
    End Sub

    Private Sub btn_choose_cust_Click(sender As Object, e As EventArgs) Handles btn_choose_cust.Click
        If txt_search.Text <> "" Then
            mysql = "SELECT * FROM TBL_STAFF_A165936 WHERE STAFF_NAME like '%" & txt_search.Text & "%'"
        Else
            mysql = "SELECT * FROM TBL_STAFF_A165936"
        End If
        refresh_grid()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Order_make_2.btn_assign_staff_Click(Nothing, Nothing)
        Me.Close()
    End Sub



End Class