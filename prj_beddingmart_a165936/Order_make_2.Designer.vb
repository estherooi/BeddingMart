<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order_make_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_make_2))
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.btn_delete_product = New System.Windows.Forms.Button()
        Me.btn_add_product = New System.Windows.Forms.Button()
        Me.btn_add_product_to_grid = New System.Windows.Forms.Button()
        Me.btn_assign_cust = New System.Windows.Forms.Button()
        Me.btn_assign_staff = New System.Windows.Forms.Button()
        Me.btn_choose_cust = New System.Windows.Forms.Button()
        Me.btn_choose_staff = New System.Windows.Forms.Button()
        Me.txt_cut_name = New System.Windows.Forms.TextBox()
        Me.txt_seller = New System.Windows.Forms.TextBox()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.txt_cust_id = New System.Windows.Forms.TextBox()
        Me.txt_order_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.tmr_date = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Hobo Std", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_date.Location = New System.Drawing.Point(693, 12)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(56, 24)
        Me.lbl_date.TabIndex = 1
        Me.lbl_date.Text = "DATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txt_total)
        Me.Panel1.Controls.Add(Me.btn_insert)
        Me.Panel1.Controls.Add(Me.grd_product)
        Me.Panel1.Controls.Add(Me.btn_delete_product)
        Me.Panel1.Controls.Add(Me.btn_add_product)
        Me.Panel1.Controls.Add(Me.btn_add_product_to_grid)
        Me.Panel1.Controls.Add(Me.btn_assign_cust)
        Me.Panel1.Controls.Add(Me.btn_assign_staff)
        Me.Panel1.Controls.Add(Me.btn_choose_cust)
        Me.Panel1.Controls.Add(Me.btn_choose_staff)
        Me.Panel1.Controls.Add(Me.txt_cut_name)
        Me.Panel1.Controls.Add(Me.txt_seller)
        Me.Panel1.Controls.Add(Me.txt_staff_id)
        Me.Panel1.Controls.Add(Me.txt_cust_id)
        Me.Panel1.Controls.Add(Me.txt_order_id)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(243, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 490)
        Me.Panel1.TabIndex = 3
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(452, 458)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(190, 29)
        Me.txt_total.TabIndex = 19
        Me.txt_total.Text = "Total : RM"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Thistle
        Me.btn_insert.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(256, 417)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(152, 49)
        Me.btn_insert.TabIndex = 18
        Me.btn_insert.Text = "MAKE ORDER"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.AllowUserToOrderColumns = True
        Me.grd_product.BackgroundColor = System.Drawing.Color.SeaShell
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(31, 250)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(611, 150)
        Me.grd_product.TabIndex = 17
        '
        'btn_delete_product
        '
        Me.btn_delete_product.BackColor = System.Drawing.Color.LavenderBlush
        Me.btn_delete_product.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_product.Location = New System.Drawing.Point(547, 198)
        Me.btn_delete_product.Name = "btn_delete_product"
        Me.btn_delete_product.Size = New System.Drawing.Size(95, 38)
        Me.btn_delete_product.TabIndex = 16
        Me.btn_delete_product.Text = "DELETE"
        Me.btn_delete_product.UseVisualStyleBackColor = False
        '
        'btn_add_product
        '
        Me.btn_add_product.BackColor = System.Drawing.Color.Pink
        Me.btn_add_product.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_product.Location = New System.Drawing.Point(466, 198)
        Me.btn_add_product.Name = "btn_add_product"
        Me.btn_add_product.Size = New System.Drawing.Size(75, 38)
        Me.btn_add_product.TabIndex = 15
        Me.btn_add_product.Text = "ADD"
        Me.btn_add_product.UseVisualStyleBackColor = False
        '
        'btn_add_product_to_grid
        '
        Me.btn_add_product_to_grid.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_add_product_to_grid.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_product_to_grid.Location = New System.Drawing.Point(298, 198)
        Me.btn_add_product_to_grid.Name = "btn_add_product_to_grid"
        Me.btn_add_product_to_grid.Size = New System.Drawing.Size(139, 38)
        Me.btn_add_product_to_grid.TabIndex = 14
        Me.btn_add_product_to_grid.Text = "ADD PRODUCT"
        Me.btn_add_product_to_grid.UseVisualStyleBackColor = False
        Me.btn_add_product_to_grid.Visible = False
        '
        'btn_assign_cust
        '
        Me.btn_assign_cust.BackColor = System.Drawing.Color.LightCoral
        Me.btn_assign_cust.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assign_cust.Location = New System.Drawing.Point(479, 141)
        Me.btn_assign_cust.Name = "btn_assign_cust"
        Me.btn_assign_cust.Size = New System.Drawing.Size(115, 38)
        Me.btn_assign_cust.TabIndex = 13
        Me.btn_assign_cust.Text = "ADD CUS"
        Me.btn_assign_cust.UseVisualStyleBackColor = False
        Me.btn_assign_cust.Visible = False
        '
        'btn_assign_staff
        '
        Me.btn_assign_staff.BackColor = System.Drawing.Color.LightCoral
        Me.btn_assign_staff.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assign_staff.Location = New System.Drawing.Point(479, 85)
        Me.btn_assign_staff.Name = "btn_assign_staff"
        Me.btn_assign_staff.Size = New System.Drawing.Size(115, 37)
        Me.btn_assign_staff.TabIndex = 12
        Me.btn_assign_staff.Text = "ADD STAFF"
        Me.btn_assign_staff.UseVisualStyleBackColor = False
        Me.btn_assign_staff.Visible = False
        '
        'btn_choose_cust
        '
        Me.btn_choose_cust.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_choose_cust.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_choose_cust.Location = New System.Drawing.Point(348, 141)
        Me.btn_choose_cust.Name = "btn_choose_cust"
        Me.btn_choose_cust.Size = New System.Drawing.Size(99, 38)
        Me.btn_choose_cust.TabIndex = 11
        Me.btn_choose_cust.Text = "SELECT"
        Me.btn_choose_cust.UseVisualStyleBackColor = False
        '
        'btn_choose_staff
        '
        Me.btn_choose_staff.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_choose_staff.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_choose_staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_choose_staff.Location = New System.Drawing.Point(348, 85)
        Me.btn_choose_staff.Name = "btn_choose_staff"
        Me.btn_choose_staff.Size = New System.Drawing.Size(99, 37)
        Me.btn_choose_staff.TabIndex = 10
        Me.btn_choose_staff.Text = "SELECT"
        Me.btn_choose_staff.UseVisualStyleBackColor = False
        '
        'txt_cut_name
        '
        Me.txt_cut_name.Location = New System.Drawing.Point(130, 151)
        Me.txt_cut_name.Name = "txt_cut_name"
        Me.txt_cut_name.Size = New System.Drawing.Size(189, 22)
        Me.txt_cut_name.TabIndex = 9
        '
        'txt_seller
        '
        Me.txt_seller.Location = New System.Drawing.Point(130, 93)
        Me.txt_seller.Name = "txt_seller"
        Me.txt_seller.Size = New System.Drawing.Size(189, 22)
        Me.txt_seller.TabIndex = 8
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Location = New System.Drawing.Point(367, 30)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.Size = New System.Drawing.Size(70, 22)
        Me.txt_staff_id.TabIndex = 7
        Me.txt_staff_id.Visible = False
        '
        'txt_cust_id
        '
        Me.txt_cust_id.Location = New System.Drawing.Point(280, 30)
        Me.txt_cust_id.Name = "txt_cust_id"
        Me.txt_cust_id.Size = New System.Drawing.Size(71, 22)
        Me.txt_cust_id.TabIndex = 6
        Me.txt_cust_id.Visible = False
        '
        'txt_order_id
        '
        Me.txt_order_id.Location = New System.Drawing.Point(130, 30)
        Me.txt_order_id.Name = "txt_order_id"
        Me.txt_order_id.Size = New System.Drawing.Size(100, 22)
        Me.txt_order_id.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Staff"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Cornsilk
        Me.btn_back.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_back.Location = New System.Drawing.Point(12, 279)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(215, 56)
        Me.btn_back.TabIndex = 4
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Lavender
        Me.btn_home.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(12, 354)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(215, 61)
        Me.btn_home.TabIndex = 15
        Me.btn_home.Text = "HOME"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'tmr_date
        '
        Me.tmr_date.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(-2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(941, 49)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCoral
        Me.Panel3.Controls.Add(Me.btn_exit)
        Me.Panel3.Location = New System.Drawing.Point(-2, 569)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(941, 49)
        Me.Panel3.TabIndex = 17
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(809, 4)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 41)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 113)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Order_make_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(934, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Order_make_2"
        Me.Text = "Order_make_2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_date As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_delete_product As Button
    Friend WithEvents btn_add_product As Button
    Friend WithEvents btn_add_product_to_grid As Button
    Friend WithEvents btn_assign_cust As Button
    Friend WithEvents btn_assign_staff As Button
    Friend WithEvents btn_choose_cust As Button
    Friend WithEvents btn_choose_staff As Button
    Friend WithEvents txt_cut_name As TextBox
    Friend WithEvents txt_seller As TextBox
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents txt_cust_id As TextBox
    Friend WithEvents txt_order_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents tmr_date As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_exit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
