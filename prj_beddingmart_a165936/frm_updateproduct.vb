Public Class frm_updateproduct

    Dim current_code As String


    Private Sub frm_updateproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A165936")
        get_current_code()

        grd_product.Columns(0).HeaderText = "PRODUCT ID"
        grd_product.Columns(1).HeaderText = "PRODUCT NAME"
        grd_product.Columns(2).HeaderText = "PRODUCT BRAND"
        grd_product.Columns(3).HeaderText = "PRODUCT MATERIAL"
        grd_product.Columns(4).HeaderText = "PRODUCT WEIGHT"
        grd_product.Columns(5).HeaderText = "PRODUCT WARRANTY LENGTH"
        grd_product.Columns(6).HeaderText = "PRODUCT PRICE"

        lbl_date.Text = Date.Now

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_brand.Text = ""
        txt_material.Text = ""
        txt_weight.Text = ""
        txt_warranty.Text = ""
        txt_price.Text = ""

    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_product.CurrentRow.Index
        current_code = grd_product(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_product(1, current_row).Value
        txt_brand.Text = grd_product(2, current_row).Value
        txt_material.Text = grd_product(3, current_row).Value
        txt_weight.Text = grd_product(4, current_row).Value
        txt_warranty.Text = grd_product(5, current_row).Value
        txt_price.Text = grd_product(6, current_row).Value


    End Sub


    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        get_current_code()



    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_PRODUCTS_A165936 SET PRODUCT_NAME='" & txt_name.Text & "'WHERE PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A165936 SET PRODUCT_BRAND='" & txt_brand.Text & "'WHERE PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A165936 SET PRODUCT_MATERIAL_ID='" & txt_material.Text & "'WHERE PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A165936 SET PRODUCT_WEIGHT='" & txt_weight.Text & "'WHERE PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A165936 SET PRODUCT_WARRANTYLENGTH='" & txt_warranty.Text & "'WHERE PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A165936 SET PRICE='" & txt_price.Text & "'WHERE PRODUCT_ID='" & current_code & "'")


        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")


        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A165936")

        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product""" & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A165936 WHERE PRODUCT_ID='" & current_code & "'")
            My.Computer.FileSystem.DeleteFile("pictures\" & txt_id.Text & ".jpg")
            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")

            grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A165936")
            clear_fields()
            get_current_code()

        End If

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A165936")
        clear_fields()
        get_current_code()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        frm_productdetails.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct.Show()
        Me.Hide()
    End Sub

End Class