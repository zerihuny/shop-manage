﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_createProduct_a172423
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.rb_desk_clock = New System.Windows.Forms.RadioButton()
        Me.rb_radio = New System.Windows.Forms.RadioButton()
        Me.rb_clockRadio = New System.Windows.Forms.RadioButton()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.lbl_battery = New System.Windows.Forms.Label()
        Me.txt_battery = New System.Windows.Forms.TextBox()
        Me.btn_browseImage = New System.Windows.Forms.Button()
        Me.lbl_image = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.product_image = New System.Windows.Forms.PictureBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.lbl_error_name = New System.Windows.Forms.Label()
        Me.lbl_error_id = New System.Windows.Forms.Label()
        Me.lbl_error_price = New System.Windows.Forms.Label()
        Me.lbl_error_quantity = New System.Windows.Forms.Label()
        Me.lbl_error_type = New System.Windows.Forms.Label()
        Me.lbl_error_material = New System.Windows.Forms.Label()
        Me.lbl_error_battery = New System.Windows.Forms.Label()
        CType(Me.product_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(329, 38)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Create New Product"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(16, 97)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Name"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(19, 123)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 2
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(238, 97)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "Product ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(241, 123)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 4
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(439, 97)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(31, 13)
        Me.lbl_price.TabIndex = 5
        Me.lbl_price.Text = "Price"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(442, 123)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(629, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Quantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(632, 123)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantity.TabIndex = 8
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(16, 203)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_type.TabIndex = 9
        Me.lbl_type.Text = "Type"
        '
        'rb_desk_clock
        '
        Me.rb_desk_clock.AutoSize = True
        Me.rb_desk_clock.Location = New System.Drawing.Point(19, 231)
        Me.rb_desk_clock.Name = "rb_desk_clock"
        Me.rb_desk_clock.Size = New System.Drawing.Size(80, 17)
        Me.rb_desk_clock.TabIndex = 10
        Me.rb_desk_clock.TabStop = True
        Me.rb_desk_clock.Text = "Desk Clock"
        Me.rb_desk_clock.UseVisualStyleBackColor = True
        '
        'rb_radio
        '
        Me.rb_radio.AutoSize = True
        Me.rb_radio.Location = New System.Drawing.Point(19, 254)
        Me.rb_radio.Name = "rb_radio"
        Me.rb_radio.Size = New System.Drawing.Size(53, 17)
        Me.rb_radio.TabIndex = 11
        Me.rb_radio.TabStop = True
        Me.rb_radio.Text = "Radio"
        Me.rb_radio.UseVisualStyleBackColor = True
        '
        'rb_clockRadio
        '
        Me.rb_clockRadio.AutoSize = True
        Me.rb_clockRadio.Location = New System.Drawing.Point(19, 277)
        Me.rb_clockRadio.Name = "rb_clockRadio"
        Me.rb_clockRadio.Size = New System.Drawing.Size(83, 17)
        Me.rb_clockRadio.TabIndex = 12
        Me.rb_clockRadio.TabStop = True
        Me.rb_clockRadio.Text = "Clock Radio"
        Me.rb_clockRadio.UseVisualStyleBackColor = True
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Location = New System.Drawing.Point(238, 203)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(44, 13)
        Me.lbl_material.TabIndex = 13
        Me.lbl_material.Text = "Material"
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(241, 231)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(100, 20)
        Me.txt_material.TabIndex = 14
        '
        'lbl_battery
        '
        Me.lbl_battery.AutoSize = True
        Me.lbl_battery.Location = New System.Drawing.Point(439, 203)
        Me.lbl_battery.Name = "lbl_battery"
        Me.lbl_battery.Size = New System.Drawing.Size(236, 13)
        Me.lbl_battery.TabIndex = 15
        Me.lbl_battery.Text = "Power Source (Battery, Socket, USB Chargered)"
        '
        'txt_battery
        '
        Me.txt_battery.Location = New System.Drawing.Point(442, 230)
        Me.txt_battery.Name = "txt_battery"
        Me.txt_battery.Size = New System.Drawing.Size(100, 20)
        Me.txt_battery.TabIndex = 16
        '
        'btn_browseImage
        '
        Me.btn_browseImage.Location = New System.Drawing.Point(19, 381)
        Me.btn_browseImage.Name = "btn_browseImage"
        Me.btn_browseImage.Size = New System.Drawing.Size(75, 23)
        Me.btn_browseImage.TabIndex = 17
        Me.btn_browseImage.Text = "Browse"
        Me.btn_browseImage.UseVisualStyleBackColor = True
        '
        'lbl_image
        '
        Me.lbl_image.AutoSize = True
        Me.lbl_image.Location = New System.Drawing.Point(16, 351)
        Me.lbl_image.Name = "lbl_image"
        Me.lbl_image.Size = New System.Drawing.Size(36, 13)
        Me.lbl_image.TabIndex = 18
        Me.lbl_image.Text = "Image"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'product_image
        '
        Me.product_image.Location = New System.Drawing.Point(146, 341)
        Me.product_image.Name = "product_image"
        Me.product_image.Size = New System.Drawing.Size(117, 97)
        Me.product_image.TabIndex = 19
        Me.product_image.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(554, 397)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Location = New System.Drawing.Point(679, 397)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 21
        Me.btn_create.Text = "CREATE"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'lbl_error_name
        '
        Me.lbl_error_name.AutoSize = True
        Me.lbl_error_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_name.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_name.Location = New System.Drawing.Point(16, 146)
        Me.lbl_error_name.Name = "lbl_error_name"
        Me.lbl_error_name.Size = New System.Drawing.Size(98, 16)
        Me.lbl_error_name.TabIndex = 22
        Me.lbl_error_name.Text = "lbl_error_name"
        Me.lbl_error_name.Visible = False
        '
        'lbl_error_id
        '
        Me.lbl_error_id.AutoSize = True
        Me.lbl_error_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_id.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_id.Location = New System.Drawing.Point(238, 148)
        Me.lbl_error_id.Name = "lbl_error_id"
        Me.lbl_error_id.Size = New System.Drawing.Size(75, 16)
        Me.lbl_error_id.TabIndex = 23
        Me.lbl_error_id.Text = "lbl_error_id"
        Me.lbl_error_id.Visible = False
        '
        'lbl_error_price
        '
        Me.lbl_error_price.AutoSize = True
        Me.lbl_error_price.BackColor = System.Drawing.Color.BlueViolet
        Me.lbl_error_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_price.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_price.Location = New System.Drawing.Point(442, 150)
        Me.lbl_error_price.Name = "lbl_error_price"
        Me.lbl_error_price.Size = New System.Drawing.Size(94, 16)
        Me.lbl_error_price.TabIndex = 24
        Me.lbl_error_price.Text = "lbl_error_price"
        Me.lbl_error_price.Visible = False
        '
        'lbl_error_quantity
        '
        Me.lbl_error_quantity.AutoSize = True
        Me.lbl_error_quantity.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_quantity.Location = New System.Drawing.Point(632, 150)
        Me.lbl_error_quantity.Name = "lbl_error_quantity"
        Me.lbl_error_quantity.Size = New System.Drawing.Size(87, 13)
        Me.lbl_error_quantity.TabIndex = 25
        Me.lbl_error_quantity.Text = "lbl_error_quantity"
        Me.lbl_error_quantity.Visible = False
        '
        'lbl_error_type
        '
        Me.lbl_error_type.AutoSize = True
        Me.lbl_error_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_type.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_type.Location = New System.Drawing.Point(19, 301)
        Me.lbl_error_type.Name = "lbl_error_type"
        Me.lbl_error_type.Size = New System.Drawing.Size(90, 16)
        Me.lbl_error_type.TabIndex = 26
        Me.lbl_error_type.Text = "lbl_error_type"
        Me.lbl_error_type.Visible = False
        '
        'lbl_error_material
        '
        Me.lbl_error_material.AutoSize = True
        Me.lbl_error_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_material.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_material.Location = New System.Drawing.Point(241, 258)
        Me.lbl_error_material.Name = "lbl_error_material"
        Me.lbl_error_material.Size = New System.Drawing.Size(112, 16)
        Me.lbl_error_material.TabIndex = 27
        Me.lbl_error_material.Text = "lbl_error_material"
        Me.lbl_error_material.Visible = False
        '
        'lbl_error_battery
        '
        Me.lbl_error_battery.AutoSize = True
        Me.lbl_error_battery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_battery.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_error_battery.Location = New System.Drawing.Point(442, 257)
        Me.lbl_error_battery.Name = "lbl_error_battery"
        Me.lbl_error_battery.Size = New System.Drawing.Size(105, 16)
        Me.lbl_error_battery.TabIndex = 28
        Me.lbl_error_battery.Text = "lbl_error_battery"
        Me.lbl_error_battery.Visible = False
        '
        'frm_createProduct_a172423
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_error_battery)
        Me.Controls.Add(Me.lbl_error_material)
        Me.Controls.Add(Me.lbl_error_type)
        Me.Controls.Add(Me.lbl_error_quantity)
        Me.Controls.Add(Me.lbl_error_price)
        Me.Controls.Add(Me.lbl_error_id)
        Me.Controls.Add(Me.lbl_error_name)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.product_image)
        Me.Controls.Add(Me.lbl_image)
        Me.Controls.Add(Me.btn_browseImage)
        Me.Controls.Add(Me.txt_battery)
        Me.Controls.Add(Me.lbl_battery)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.rb_clockRadio)
        Me.Controls.Add(Me.rb_radio)
        Me.Controls.Add(Me.rb_desk_clock)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_createProduct_a172423"
        Me.Text = "frm_createProduct_a172423"
        CType(Me.product_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_type As Label
    Friend WithEvents rb_desk_clock As RadioButton
    Friend WithEvents rb_radio As RadioButton
    Friend WithEvents rb_clockRadio As RadioButton
    Friend WithEvents lbl_material As Label
    Friend WithEvents txt_material As TextBox
    Friend WithEvents lbl_battery As Label
    Friend WithEvents txt_battery As TextBox
    Friend WithEvents btn_browseImage As Button
    Friend WithEvents lbl_image As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents product_image As PictureBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents lbl_test As Label
    Friend WithEvents lbl_error_name As Label
    Friend WithEvents lbl_error_id As Label
    Friend WithEvents lbl_error_price As Label
    Friend WithEvents lbl_error_quantity As Label
    Friend WithEvents lbl_error_type As Label
    Friend WithEvents lbl_error_material As Label
    Friend WithEvents lbl_error_battery As Label
End Class