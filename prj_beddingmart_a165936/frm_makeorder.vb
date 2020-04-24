Imports System.Data.OleDb
Public Class frm_makeorder
    Dim mysql As String
    Dim current_code As String
    Dim current_customer As String
    Dim current_staff As String
    Dim current_date As String
    Dim total_amt, price, quantity As Double

    Private Sub frm_makeorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = Date.Now
        refresh_grid()
        If grd_order.RowCount > 0 Then
            get_current_product_list()
        End If
        txt_totalprice.Text = "Total : RM 0"

    End Sub



    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A165936"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(1).HeaderText = "Staff ID"
        grd_order.Columns(2).HeaderText = "Customer ID"
        grd_order.Columns(3).HeaderText = "Order Date"


    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_order_invoice.Show()
        frm_order_invoice.txt_current_code.Text = current_code
        frm_order_invoice.lbl_invoice.Text = "Invoice Number : " & current_code
        frm_order_invoice.lbl_customer.Text = "[CUSTOMER ID] Billed To : " & current_customer
        frm_order_invoice.lbl_date.Text = "Purchasing Date : " & current_date
        frm_order_invoice.lbl_seller.Text = "[STAFF ID] Sales Person : " & current_staff
        frm_order_invoice.btn_execute_Click(Nothing, Nothing)
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        Order_make_2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_order.Show()
        Me.Hide()
    End Sub

    Private Sub get_current_product_list()

        grd_product_order.Rows.Clear()
        total_amt = 0
        Dim current_row As Integer = grd_order.CurrentRow.Index
        Dim newrow As Integer
        current_code = grd_order(0, current_row).Value
        current_staff = grd_order(1, current_row).Value
        current_customer = grd_order(2, current_row).Value
        current_date = grd_order(3, current_row).Value

        grd_product_order.ColumnCount = 5

        grd_product_order.Columns(0).HeaderText = "Order ID"
        grd_product_order.Columns(1).HeaderText = "Product ID"
        grd_product_order.Columns(2).HeaderText = "Quantity"
        grd_product_order.Columns(3).HeaderText = "Price per unit (RM)"
        grd_product_order.Columns(4).HeaderText = "Total (RM)"



        mysql = "SELECT TBL_ORDER_DETAILS_A165936.ORDER_ID AS product_id, TBL_ORDER_DETAILS_A165936.PRICE AS price, " &
            "TBL_ORDER_DETAILS_A165936.QUANTITY AS quantity, TBL_ORDER_DETAILS_A165936.PRODUCT_ID AS prod_name " &
            "FROM TBL_ORDER_DETAILS_A165936, TBL_PRODUCTS_A165936 " &
            "WHERE TBL_ORDER_DETAILS_A165936.PRODUCT_ID = TBL_PRODUCTS_A165936.PRODUCT_ID AND " &
            "TBL_ORDER_DETAILS_A165936.ORDER_ID = '" & current_code & "'"

        Dim reader As OleDbDataReader
        Dim con As OleDb.OleDbConnection = Nothing
        Dim cmd As OleDb.OleDbCommand = Nothing
        con = New OleDb.OleDbConnection()
        con.ConnectionString = myconnection
        con.Open()
        cmd = New OleDb.OleDbCommand(mysql, con)
        reader = cmd.ExecuteReader()
        While (reader.Read())
            grd_product_order.RowCount = grd_product_order.RowCount + 1

            newrow = grd_product_order.RowCount - 1

            grd_product_order(0, newrow).Value = reader.Item(0)
            grd_product_order(1, newrow).Value = reader.Item(3)
            grd_product_order(2, newrow).Value = reader.Item(1)
            grd_product_order(3, newrow).Value = reader.Item(2)

            price = Double.Parse(reader.Item(1))
            quantity = Int32.Parse(reader.Item(2))

            grd_product_order(4, newrow).Value = price * quantity
            total_amt = total_amt + (price * quantity)
            txt_totalprice.Text = "Total : RM " & total_amt
        End While
        reader.Close()
        cmd.Dispose()
        con.Close()



    End Sub

    Private Sub grd_order_Click(sender As Object, e As EventArgs) Handles grd_order.Click
        get_current_product_list()

    End Sub
End Class