Public Class Order_make_2
    Dim total_amt As Double
    Dim get_price As Double
    Dim order_fail As Boolean

    Private Sub Order_make_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = Date.Now
        txt_order_id.Text = generate_orderid()

        total_amt = 0

        grd_product.ColumnCount = 5

        grd_product.Columns(0).HeaderText = "Order ID"
        grd_product.Columns(1).HeaderText = "Product ID"
        grd_product.Columns(2).HeaderText = "Quantity"
        grd_product.Columns(3).HeaderText = "Price Per Unit (RM) "
        grd_product.Columns(4).HeaderText = "Total (RM)"
    End Sub

    Private Function generate_orderid() As String
        Dim lastorderid As String = run_sql_query("SELECT MAX(ORDER_ID) AS LASTORDER FROM TBL_ORDER_A165936").Rows(0).Item("LASTORDER")


        Dim neworderid As String = "R" & Mid(lastorderid, 2) + 1
        Return neworderid
    End Function

    Private Sub tmr_date_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_date.Tick
        lbl_date.Text = Date.Now
    End Sub

    Private Sub btn_add_product_Click(sender As Object, e As EventArgs) Handles btn_add_product.Click
        frm_order_add_product.Show()
    End Sub

    Private Sub btn_choose_cust_Click(sender As Object, e As EventArgs) Handles btn_choose_cust.Click
        frm_order_add_customer.Show()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        If check_textfield() = True Then
            record_order()
            If order_fail = False Then
                MsgBox("Order saved", vbInformation, "MyCookieStore")
                clear_textfield()
            End If
        Else
            MsgBox("Please complete the order form", vbExclamation, "MyCookieStore")
        End If
    End Sub


    Public Sub btn_add_product_to_grid_Click(sender As Object, e As EventArgs) Handles btn_add_product_to_grid.Click
        grd_product.RowCount = grd_product.RowCount + 1

        Dim newrow = grd_product.RowCount - 1

        grd_product(0, newrow).Value = temp_id
        grd_product(1, newrow).Value = temp_name
        grd_product(2, newrow).Value = temp_price
        grd_product(3, newrow).Value = temp_quantity
        grd_product(4, newrow).Value = temp_price * temp_quantity
        total_amt = total_amt + (temp_price * temp_quantity)
        txt_total.Text = "Total : RM " & total_amt
    End Sub

    Private Sub btn_delete_product_Click(sender As Object, e As EventArgs) Handles btn_delete_product.Click
        Dim confirm_deletion = MsgBoxResult.No
        Try
            confirm_deletion = MsgBox("Are you sure want to delete " & grd_product(1, grd_product.CurrentRow.Index).Value() & "?", MsgBoxStyle.YesNo + vbExclamation, "Bedding Mart")
            get_price = Double.Parse(grd_product(4, grd_product.CurrentRow.Index).Value())

        Catch ex As Exception
            'DO nothing
        End Try

        Try
            If confirm_deletion = MsgBoxResult.Yes Then
                grd_product.Rows.Remove(grd_product.CurrentRow)
                total_amt = total_amt - get_price
                txt_total.Text = "Total : RM " & total_amt
            End If
        Catch ex As Exception
            'do nothing
        End Try
    End Sub

    Public Sub btn_assign_cust_Click(sender As Object, e As EventArgs) Handles btn_assign_cust.Click
        txt_cust_id.Text = temp_id
        txt_cut_name.Text = "[" & temp_id & "] " & temp_name
    End Sub

    Private Sub grd_product_Click(sender As Object, e As EventArgs) Handles grd_product.Click

        get_price = Double.Parse(grd_product(4, grd_product.CurrentRow.Index).Value())
    End Sub

    Function check_textfield() As Boolean
        If Trim(txt_order_id.Text) <> "" And Trim(txt_cust_id.Text) <> "" And Trim(txt_staff_id.Text) <> "" And grd_product.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub clear_textfield()
        txt_order_id.Text = generate_orderid()
        txt_staff_id.Text = ""
        txt_seller.Text = ""
        txt_cust_id.Text = ""
        txt_cut_name.Text = ""
        txt_total.Text = "Total : RM 0"
        total_amt = 0
        grd_product.Rows.Clear()
    End Sub

    Private Sub record_order()
        Dim mytransaction As OleDb.OleDbTransaction
        Dim mysql As String
        order_fail = True



        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction

        Try
            mysql = "INSERT INTO TBL_ORDER_A165936 (ORDER_ID, STAFF_ID, CUS_ID, ORDER_DATE) VALUES ('" & txt_order_id.Text & "','" & txt_staff_id.Text & "','" & txt_cust_id.Text & "',#" & Date.Today.ToShortDateString & "#)"
            Dim mywriter2 As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
            mywriter2.ExecuteNonQuery()

            For i As Integer = 0 To grd_product.RowCount - 1

                Dim pid As String = grd_product(0, i).Value
                Dim pprice As String = grd_product(2, i).Value
                Dim pquantity As String = grd_product(3, i).Value


                mysql = "INSERT INTO TBL_ORDER_DETAILS_A165936 (ORDER_ID, PRODUCT_ID, QUANTITY, PRICE) VALUES ('" & txt_order_id.Text & "','" & pid & "'," & Double.Parse(pprice) & "," & Int32.Parse(pquantity) & ")"

                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

                mywriter.ExecuteNonQuery()

            Next

            mytransaction.Commit()

            myconnection2.Close()
            order_fail = False

            Beep()
        Catch ex As Exception
            myconnection2.Close()
            MsgBox("Order fail, please try again", vbExclamation, "MyCameraStore")
        End Try

    End Sub

    Private Sub btn_choose_staff_Click(sender As Object, e As EventArgs) Handles btn_choose_staff.Click
        frm_order_add_staff.Show()

    End Sub

    Public Sub btn_assign_staff_Click(sender As Object, e As EventArgs) Handles btn_assign_staff.Click
        txt_staff_id.Text = temp_id
        txt_seller.Text = "[" & temp_id & "] " & temp_name
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_makeorder.Show()
        Me.Hide()

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class