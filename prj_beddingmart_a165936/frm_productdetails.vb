Public Class frm_productdetails
    Private Sub frm_productdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT PRODUCT_ID FROM TBL_PRODUCTS_A165936"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        Product_ID.DataSource = mydatatable
        Product_ID.DisplayMember = "PRODUCT_ID"

        refresh_text(Product_ID.Text)
        lbl_date.Text = Date.Now

    End Sub

    Private Sub refresh_text(product_id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A165936 WHERE PRODUCT_ID ='" & product_id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("PRODUCT_NAME")
        txt_material.Text = mydatatable.Rows(0).Item("PRODUCT_MATERIAL_ID")
        txt_brand.Text = mydatatable.Rows(0).Item("PRODUCT_BRAND")
        txt_warranty.Text = mydatatable.Rows(0).Item("PRODUCT_WARRANTYLENGTH")
        txt_weight.Text = mydatatable.Rows(0).Item("PRODUCT_WEIGHT")
        txt_price.Text = mydatatable.Rows(0).Item("PRICE")



        PictureBox1.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

    End Sub



    Private Sub Product_ID_MouseClick(sender As Object, e As MouseEventArgs) Handles Product_ID.MouseClick
        refresh_text(Product_ID.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_product.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproduct.Show()
        Me.Hide()
    End Sub


End Class