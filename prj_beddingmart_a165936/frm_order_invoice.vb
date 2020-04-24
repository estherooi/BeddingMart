Imports System.Data.OleDb

Public Class frm_order_invoice
    Private Sub frm_order_invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub get_current_product_list()
        Dim total_amt As Double
        Dim mysql As String

        grd_product_order.Rows.Clear()
        total_amt = 0
        Dim newrow As Integer


        grd_product_order.ColumnCount = 5

        grd_product_order.Columns(0).HeaderText = "Order ID"
        grd_product_order.Columns(1).HeaderText = "Product ID"
        grd_product_order.Columns(2).HeaderText = "Price (RM)"
        grd_product_order.Columns(3).HeaderText = "Quantity"
        grd_product_order.Columns(4).HeaderText = "Total (RM)"

        grd_product_order.Columns(0).Width = "50"
        grd_product_order.Columns(1).Width = "350"
        grd_product_order.Columns(2).Width = "50"
        grd_product_order.Columns(3).Width = "50"
        grd_product_order.Columns(4).Width = "50"

        grd_product_order.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grd_product_order.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grd_product_order.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grd_product_order.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        mysql = "SELECT TBL_ORDER_DETAILS_A165936.ORDER_ID AS product_id, TBL_ORDER_DETAILS_A165936.PRICE AS price, " &
            "TBL_ORDER_DETAILS_A165936.QUANTITY AS quantity, TBL_ORDER_DETAILS_A165936.PRODUCT_ID AS prod_name " &
            "FROM TBL_ORDER_DETAILS_A165936, TBL_PRODUCTS_A165936 " &
            "WHERE TBL_ORDER_DETAILS_A165936.PRODUCT_ID = TBL_PRODUCTS_A165936.PRODUCT_ID AND " &
            "TBL_ORDER_DETAILS_A165936.ORDER_ID = '" & txt_current_code.Text & "'"

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

            grd_product_order(4, newrow).Value = Double.Parse(reader.Item(1)) * Int32.Parse(reader.Item(2))
            total_amt = total_amt + (Double.Parse(reader.Item(1)) * Int32.Parse(reader.Item(2)))
        End While

        lbl_total.Text = "RM " & total_amt

        reader.Close()
        cmd.Dispose()
        con.Close()


    End Sub

    Public Sub btn_execute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_execute.Click
        get_current_product_list()
    End Sub


End Class