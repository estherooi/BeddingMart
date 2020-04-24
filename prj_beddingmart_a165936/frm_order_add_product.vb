Public Class frm_order_add_product
    Dim mysql As String
    Dim current_code As String
    Dim i As Integer

    Private Sub refresh_grid()

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

        grd_product.Columns(0).HeaderText = "Product ID"
        grd_product.Columns(1).HeaderText = "Product Name"
        grd_product.Columns(2).HeaderText = "Brand"
        grd_product.Columns(3).HeaderText = "Material ID"
        grd_product.Columns(4).HeaderText = "Product Weight"
        grd_product.Columns(5).HeaderText = "Warranty length"
        grd_product.Columns(6).HeaderText = "Price"
    End Sub

    Private Sub get_current_record()


        Dim current_row As Integer = grd_product.CurrentRow.Index

        generate_file_rand()

        current_code = grd_product(0, current_row).Value

        txt_selected.Text = "[Product Code: " & current_code & "] Product Name: " & grd_product(1, current_row).Value
        lbl_price.Text = "Price : RM " & grd_product(6, current_row).Value

        temp_id = current_code
        temp_name = grd_product(1, current_row).Value
        temp_price = Double.Parse(grd_product(6, current_row).Value)

        cmb_quantity.Items.Clear()
        i = 0
        cmb_quantity.Items.Add("1")
        cmb_quantity.Items.Add("2")
        cmb_quantity.Items.Add("3")
        cmb_quantity.Items.Add("4")
        cmb_quantity.Items.Add("5")
        cmb_quantity.Items.Add("6")
        cmb_quantity.Items.Add("7")
        cmb_quantity.Items.Add("8")
        cmb_quantity.Items.Add("9")
        cmb_quantity.Items.Add("10")

        cmb_quantity.Text = "0"
    End Sub

    Private Sub grd_product_AutoSizeColumnModeChanged(sender As Object, e As DataGridViewAutoSizeColumnModeEventArgs) Handles grd_product.AutoSizeColumnModeChanged
        get_current_record()
    End Sub

    Private Sub grd_product_Click(sender As Object, e As EventArgs) Handles grd_product.Click
        get_current_record()
    End Sub


    Private Sub frm_order_add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mysql = "SELECT * FROM TBL_PRODUCTS_A165936"
        refresh_grid()
        get_current_record()
    End Sub

    Private Sub btn_choose_cust_Click(sender As Object, e As EventArgs) Handles btn_choose_cust.Click
        If txt_search.Text <> "" Then
            mysql = "SELECT * FROM TBL_PRODUCTS_A165786 WHERE FLD_PRODUCT_NAME like '%" & txt_search.Text & "%'"
        Else
            mysql = "SELECT * FROM TBL_PRODUCTS_A165786"
        End If
        refresh_grid()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If cmb_quantity.Text <> 0 Then
            temp_quantity = Int32.Parse(cmb_quantity.Text)
            Order_make_2.btn_add_product_to_grid_Click(Nothing, Nothing)
            Me.Close()
        Else
            MsgBox("Please select quantity or product currently out of stock", vbInformation, "MyCameraStore")
        End If
    End Sub
End Class