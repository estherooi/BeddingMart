Public Class frm_material
    Private Sub frm_material_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB_BEDDINGMART_A165936.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_MATERIAL_A165936"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        DataGridView1.DataSource = mydatatable

        lbl_date.Text = Date.Now
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class