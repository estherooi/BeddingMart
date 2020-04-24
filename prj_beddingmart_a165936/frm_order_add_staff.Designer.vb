<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_add_staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_order_add_staff))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_choose_cust = New System.Windows.Forms.Button()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.txt_selected = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Name"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(206, 48)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(268, 25)
        Me.txt_search.TabIndex = 2
        '
        'btn_choose_cust
        '
        Me.btn_choose_cust.BackColor = System.Drawing.Color.Lavender
        Me.btn_choose_cust.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_choose_cust.Location = New System.Drawing.Point(527, 43)
        Me.btn_choose_cust.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_choose_cust.Name = "btn_choose_cust"
        Me.btn_choose_cust.Size = New System.Drawing.Size(94, 40)
        Me.btn_choose_cust.TabIndex = 4
        Me.btn_choose_cust.Text = "Search"
        Me.btn_choose_cust.UseVisualStyleBackColor = False
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        Me.grd_customer.BackgroundColor = System.Drawing.Color.SeaShell
        Me.grd_customer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grd_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(49, 104)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grd_customer.MultiSelect = False
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(583, 188)
        Me.grd_customer.TabIndex = 5
        '
        'txt_selected
        '
        Me.txt_selected.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_selected.Location = New System.Drawing.Point(49, 329)
        Me.txt_selected.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_selected.Name = "txt_selected"
        Me.txt_selected.ReadOnly = True
        Me.txt_selected.Size = New System.Drawing.Size(583, 25)
        Me.txt_selected.TabIndex = 6
        Me.txt_selected.Text = "No staff"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.Lavender
        Me.btn_insert.Location = New System.Drawing.Point(235, 386)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(199, 45)
        Me.btn_insert.TabIndex = 7
        Me.btn_insert.Text = "SELECT STAFF"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'frm_order_add_staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 478)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_selected)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.btn_choose_cust)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_order_add_staff"
        Me.Text = "frm_order_add_staff"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_choose_cust As Button
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents txt_selected As TextBox
    Friend WithEvents btn_insert As Button
End Class
