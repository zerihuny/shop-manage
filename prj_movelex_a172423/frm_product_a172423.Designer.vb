<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_product_a172423
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.tt_create = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(20, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(284, 56)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product List"
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Location = New System.Drawing.Point(726, 42)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 23)
        Me.btn_home.TabIndex = 2
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'grd_product
        '
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(60, 85)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.Size = New System.Drawing.Size(792, 287)
        Me.grd_product.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_total.Location = New System.Drawing.Point(57, 375)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(49, 16)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Label1"
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.Location = New System.Drawing.Point(807, 42)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 5
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'frm_product_a172423
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(909, 429)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_product_a172423"
        Me.Text = "Products"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents tt_create As ToolTip
End Class
