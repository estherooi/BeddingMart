Public Class frm_insertproduct
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_id.Text = generate_productid()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        lbl_date.Text = Date.Now
        refresh_grid()

    End Sub

    Private Sub refresh_grid()


        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A165936"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_products.DataSource = mydatatable

        grd_products.Columns(0).HeaderText = "PRODUCT ID"
        grd_products.Columns(1).HeaderText = "PRODUCT NAME"
        grd_products.Columns(2).HeaderText = "PRODUCT BRAND"
        grd_products.Columns(3).HeaderText = "PRODUCT MATERIAL"
        grd_products.Columns(4).HeaderText = "PRODUCT WEIGHT"
        grd_products.Columns(5).HeaderText = "PRODUCT WARRANTY LENGTH"
        grd_products.Columns(6).HeaderText = "PRODUCT PRICE"



    End Sub

    Private Function generate_productid() As String
        Dim lastproductid As String = run_sql_query("SELECT MAX(PRODUCT_ID) AS LASTPRODUCT FROM TBL_PRODUCTS_A165936").Rows(0).Item("LASTPRODUCT")

        Dim newproductid As String = "A" & Mid(lastproductid, 2) + 1
        Return newproductid
    End Function


    Private Sub clear_fields()

        txt_id.Text = ""
        txt_brand.Text = ""
        txt_name.Text = ""
        txt_material.Text = ""
        txt_warranty.Text = ""
        txt_weight.Text = ""
        txt_price.Text = ""
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A165936 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_brand.Text & "', '" & txt_material.Text & "',  '" & txt_weight.Text & "', " & txt_warranty.Text & ", '" & txt_price.Text & "' )"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A165936")

            txt_id.Text = generate_productid()
            txt_name.Text = ""
            txt_brand.Text = ""
            txt_material.Text = ""
            txt_price.Text = ""
            txt_warranty.Text = ""
            txt_weight.Text = ""

            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

            Beep()
            MsgBox("Your new product has been recorded successfully!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG file (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName


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

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        frm_productdetails.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproduct.Show()
        Me.Hide()
    End Sub

End Class