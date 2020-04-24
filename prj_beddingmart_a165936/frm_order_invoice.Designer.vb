<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_invoice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_invoice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_seller = New System.Windows.Forms.Label()
        Me.grd_product_order = New System.Windows.Forms.DataGridView()
        Me.txt_current_code = New System.Windows.Forms.TextBox()
        Me.btn_execute = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_product_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_invoice)
        Me.Panel1.Font = New System.Drawing.Font("Constantia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(500, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 100)
        Me.Panel1.TabIndex = 0
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(22, 62)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(67, 23)
        Me.lbl_date.TabIndex = 1
        Me.lbl_date.Text = "Date : "
        '
        'lbl_invoice
        '
        Me.lbl_invoice.AutoSize = True
        Me.lbl_invoice.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoice.Location = New System.Drawing.Point(22, 20)
        Me.lbl_invoice.Name = "lbl_invoice"
        Me.lbl_invoice.Size = New System.Drawing.Size(169, 23)
        Me.lbl_invoice.TabIndex = 0
        Me.lbl_invoice.Text = "Invoice Number : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(548, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INVOICE"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer.Location = New System.Drawing.Point(57, 164)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(115, 24)
        Me.lbl_customer.TabIndex = 2
        Me.lbl_customer.Text = "Billed To :  "
        '
        'lbl_seller
        '
        Me.lbl_seller.AutoSize = True
        Me.lbl_seller.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seller.Location = New System.Drawing.Point(57, 206)
        Me.lbl_seller.Name = "lbl_seller"
        Me.lbl_seller.Size = New System.Drawing.Size(81, 24)
        Me.lbl_seller.TabIndex = 3
        Me.lbl_seller.Text = "Seller : "
        '
        'grd_product_order
        '
        Me.grd_product_order.AllowUserToAddRows = False
        Me.grd_product_order.AllowUserToDeleteRows = False
        Me.grd_product_order.AllowUserToResizeColumns = False
        Me.grd_product_order.AllowUserToResizeRows = False
        Me.grd_product_order.BackgroundColor = System.Drawing.Color.White
        Me.grd_product_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product_order.Location = New System.Drawing.Point(54, 266)
        Me.grd_product_order.Name = "grd_product_order"
        Me.grd_product_order.ReadOnly = True
        Me.grd_product_order.RowTemplate.Height = 24
        Me.grd_product_order.Size = New System.Drawing.Size(838, 267)
        Me.grd_product_order.TabIndex = 4
        '
        'txt_current_code
        '
        Me.txt_current_code.Location = New System.Drawing.Point(54, 25)
        Me.txt_current_code.Name = "txt_current_code"
        Me.txt_current_code.Size = New System.Drawing.Size(79, 22)
        Me.txt_current_code.TabIndex = 5
        Me.txt_current_code.Visible = False
        '
        'btn_execute
        '
        Me.btn_execute.Location = New System.Drawing.Point(154, 24)
        Me.btn_execute.Name = "btn_execute"
        Me.btn_execute.Size = New System.Drawing.Size(44, 23)
        Me.btn_execute.TabIndex = 6
        Me.btn_execute.Text = "E"
        Me.btn_execute.UseVisualStyleBackColor = True
        Me.btn_execute.Visible = False
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.White
        Me.lbl_total.Location = New System.Drawing.Point(206, 5)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(56, 23)
        Me.lbl_total.TabIndex = 7
        Me.lbl_total.Text = "RM 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Invoice Total :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(628, 650)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 207)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(1, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 29)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Location = New System.Drawing.Point(798, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(133, 29)
        Me.Panel3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minion Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 572)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Thank you. Please come again. "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lbl_total)
        Me.Panel4.Location = New System.Drawing.Point(588, 566)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(311, 40)
        Me.Panel4.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Minion Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Terms and Condition : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Minion Pro Cond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(422, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "1. All goods return for replacement must be in stable condition."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Minion Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "2. We are not responsible for any transit damage or loss."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Minion Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(414, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "3. Payment should be made by cheque or money transfer."
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(45, 617)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(478, 121)
        Me.Panel5.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Maroon
        Me.Panel6.Location = New System.Drawing.Point(1, 885)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(947, 10)
        Me.Panel6.TabIndex = 27
        '
        'frm_order_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(926, 916)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_execute)
        Me.Controls.Add(Me.txt_current_code)
        Me.Controls.Add(Me.grd_product_order)
        Me.Controls.Add(Me.lbl_seller)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "frm_order_invoice"
        Me.Text = "frm_order_invoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_product_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_invoice As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lbl_seller As Label
    Friend WithEvents grd_product_order As DataGridView
    Friend WithEvents txt_current_code As TextBox
    Friend WithEvents btn_execute As Button
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
