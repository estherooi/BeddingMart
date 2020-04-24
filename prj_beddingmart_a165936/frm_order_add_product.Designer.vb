<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_add_product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_add_product))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_choose_cust = New System.Windows.Forms.Button()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.txt_selected = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_quantity = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(289, 39)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(201, 22)
        Me.txt_search.TabIndex = 1
        '
        'btn_choose_cust
        '
        Me.btn_choose_cust.BackColor = System.Drawing.Color.Lavender
        Me.btn_choose_cust.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_choose_cust.Location = New System.Drawing.Point(554, 31)
        Me.btn_choose_cust.Name = "btn_choose_cust"
        Me.btn_choose_cust.Size = New System.Drawing.Size(101, 34)
        Me.btn_choose_cust.TabIndex = 2
        Me.btn_choose_cust.Text = "Search"
        Me.btn_choose_cust.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.BackgroundColor = System.Drawing.Color.SeaShell
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(26, 88)
        Me.grd_product.MultiSelect = False
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(734, 214)
        Me.grd_product.TabIndex = 3
        '
        'txt_selected
        '
        Me.txt_selected.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_selected.Location = New System.Drawing.Point(54, 330)
        Me.txt_selected.Name = "txt_selected"
        Me.txt_selected.ReadOnly = True
        Me.txt_selected.Size = New System.Drawing.Size(671, 25)
        Me.txt_selected.TabIndex = 7
        Me.txt_selected.Text = "No product"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(51, 381)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(117, 23)
        Me.lbl_price.TabIndex = 8
        Me.lbl_price.Text = "Price : RM 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Quantity"
        '
        'cmb_quantity
        '
        Me.cmb_quantity.FormattingEnabled = True
        Me.cmb_quantity.Location = New System.Drawing.Point(152, 428)
        Me.cmb_quantity.Name = "cmb_quantity"
        Me.cmb_quantity.Size = New System.Drawing.Size(121, 24)
        Me.cmb_quantity.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 54)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "The quantity show available " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "item in store. 0 item in mean " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "there is no stock"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Lavender
        Me.btn_insert.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(617, 400)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(171, 64)
        Me.btn_insert.TabIndex = 12
        Me.btn_insert.Text = "SELECT PRODUCT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'frm_order_add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_quantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_selected)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.btn_choose_cust)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_order_add_product"
        Me.Text = "frm_order_add_product"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_choose_cust As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents txt_selected As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_quantity As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_insert As Button
End Class
