Public Class frm_product
    Private Sub frm_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB_BEDDINGMART_A165936.accdb;Persist Security Info=False;"

        ComboBox1.Items.Add("M01")
        ComboBox1.Items.Add("M02")
        ComboBox1.Items.Add("M03")

        refresh_grid(ComboBox1.Text)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A165936"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        DataGridView1.DataSource = mydatatable

        DataGridView1.Columns(0).HeaderText = "PRODUCT ID"
        DataGridView1.Columns(1).HeaderText = "PRODUCT NAME"
        DataGridView1.Columns(2).HeaderText = "PRODUCT BRAND"
        DataGridView1.Columns(3).HeaderText = "PRODUCT MATERIAL"
        DataGridView1.Columns(4).HeaderText = "PRODUCT WEIGHT"
        DataGridView1.Columns(5).HeaderText = "PRODUCT WARRANTY LENGTH"
        DataGridView1.Columns(6).HeaderText = "PRODUCT PRICE"

        lbl_date.Text = Date.Now

    End Sub

    Private Sub refresh_grid(material_id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A165936 WHERE PRODUCT_MATERIAL_ID ='" & material_id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        DataGridView1.DataSource = mydatatable

        DataGridView1.Columns(0).HeaderText = "PRODUCT ID"
        DataGridView1.Columns(1).HeaderText = "PRODUCT NAME"
        DataGridView1.Columns(2).HeaderText = "PRODUCT BRAND"
        DataGridView1.Columns(3).HeaderText = "PRODUCT MATERIAL"
        DataGridView1.Columns(4).HeaderText = "PRODUCT WEIGHT"
        DataGridView1.Columns(5).HeaderText = "PRODUCT WARRANTY LENGTH"
        DataGridView1.Columns(6).HeaderText = "PRODUCT PRICE"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct.Show()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproduct.Show()
        Me.Hide()
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        frm_productdetails.Show()
        Me.Hide()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        refresh_grid(ComboBox1.Text)
    End Sub



    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class