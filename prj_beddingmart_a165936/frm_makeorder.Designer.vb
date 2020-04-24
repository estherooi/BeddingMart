<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder))
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.grd_product_order = New System.Windows.Forms.DataGridView()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.txt_totalprice = New System.Windows.Forms.TextBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_product_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Hobo Std", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_date.Location = New System.Drawing.Point(674, 12)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(56, 24)
        Me.lbl_date.TabIndex = 0
        Me.lbl_date.Text = "DATE"
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.AllowUserToOrderColumns = True
        Me.grd_order.BackgroundColor = System.Drawing.Color.SeaShell
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(21, 17)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(691, 213)
        Me.grd_order.TabIndex = 1
        '
        'grd_product_order
        '
        Me.grd_product_order.AllowUserToAddRows = False
        Me.grd_product_order.AllowUserToDeleteRows = False
        Me.grd_product_order.AllowUserToOrderColumns = True
        Me.grd_product_order.BackgroundColor = System.Drawing.Color.SeaShell
        Me.grd_product_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product_order.Location = New System.Drawing.Point(21, 290)
        Me.grd_product_order.Name = "grd_product_order"
        Me.grd_product_order.ReadOnly = True
        Me.grd_product_order.RowTemplate.Height = 24
        Me.grd_product_order.Size = New System.Drawing.Size(691, 141)
        Me.grd_product_order.TabIndex = 3
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Font = New System.Drawing.Font("Cooper Black", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product.Location = New System.Drawing.Point(26, 254)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(88, 21)
        Me.lbl_product.TabIndex = 5
        Me.lbl_product.Text = "Product"
        '
        'btn_makeorder
        '
        Me.btn_makeorder.BackColor = System.Drawing.Color.Thistle
        Me.btn_makeorder.Font = New System.Drawing.Font("Cooper Black", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.Location = New System.Drawing.Point(12, 229)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(184, 57)
        Me.btn_makeorder.TabIndex = 6
        Me.btn_makeorder.Text = "MAKE ORDER"
        Me.btn_makeorder.UseVisualStyleBackColor = False
        '
        'btn_invoice
        '
        Me.btn_invoice.BackColor = System.Drawing.Color.PowderBlue
        Me.btn_invoice.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.Location = New System.Drawing.Point(12, 319)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(184, 57)
        Me.btn_invoice.TabIndex = 7
        Me.btn_invoice.Text = "INVOICE"
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'txt_totalprice
        '
        Me.txt_totalprice.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalprice.Location = New System.Drawing.Point(516, 452)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.Size = New System.Drawing.Size(196, 29)
        Me.txt_totalprice.TabIndex = 8
        Me.txt_totalprice.Text = "Total : RM "
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btn_home.Font = New System.Drawing.Font("Cooper Black", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Location = New System.Drawing.Point(12, 410)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(184, 54)
        Me.btn_home.TabIndex = 16
        Me.btn_home.Text = "HOME"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(969, 49)
        Me.Panel2.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 113)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkRed
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btn_exit)
        Me.Panel3.Location = New System.Drawing.Point(3, 555)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 49)
        Me.Panel3.TabIndex = 20
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(845, 4)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 41)
        Me.btn_exit.TabIndex = 5
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.grd_order)
        Me.Panel1.Controls.Add(Me.grd_product_order)
        Me.Panel1.Controls.Add(Me.lbl_product)
        Me.Panel1.Controls.Add(Me.txt_totalprice)
        Me.Panel1.Location = New System.Drawing.Point(220, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 484)
        Me.Panel1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(27, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 40)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = " BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_makeorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(972, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Name = "frm_makeorder"
        Me.Text = "frm_makeorder"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_product_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_date As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents grd_product_order As DataGridView
    Friend WithEvents lbl_product As Label
    Friend WithEvents btn_makeorder As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents txt_totalprice As TextBox
    Friend WithEvents btn_home As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_exit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
