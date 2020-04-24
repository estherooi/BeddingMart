Public Class frm_order_add_customer

    Dim mysql As String
    Dim current_code As String

    Private Sub frm_order_add_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysql = "SELECT * FROM TBL_CUSTOMER_A165936"
        refresh_grid()
        get_current_record()
    End Sub

    Private Sub refresh_grid()

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Phone"


    End Sub
    Private Sub get_current_record()


        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_code = grd_customer(0, current_row).Value

        txt_selected.Text = "[Customer ID : " & current_code & "] Customer Name : " & grd_customer(1, current_row).Value
        temp_id = current_code
        temp_name = grd_customer(1, current_row).Value


    End Sub

    Private Sub grd_customer_Click(sender As Object, e As EventArgs) Handles grd_customer.Click
        get_current_record()
    End Sub

    Private Sub btn_choose_cust_Click(sender As Object, e As EventArgs) Handles btn_choose_cust.Click
        If txt_search.Text <> "" Then
            mysql = "SELECT * FROM TBL_CUSTOMER_A165936 WHERE CUS_NAME like '%" & txt_search.Text & "%'"
        Else
            mysql = "SELECT * FROM TBL_CUSTOMER_A165936"
        End If
        refresh_grid()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Order_make_2.btn_assign_cust_Click(Nothing, Nothing)
        Me.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

End Class