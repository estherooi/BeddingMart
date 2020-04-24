Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim mysql As String = "SELECT COUNT (*) AS NUM_MATCHES FROM TBL_USERS_A165936 WHERE USERNAME = '" & txt_username.Text & "' and PASSWORD='" & txt_password.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Dim num_matches As String = mydatatable.Rows(0).Item("NUM_MATCHES")

        If num_matches = 1 Then
            Form1.Show()
            Me.Hide()

        Else
            txt_username.Text = ""
            txt_password.Text = ""
            MsgBox("Incorrect Username or Password")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class