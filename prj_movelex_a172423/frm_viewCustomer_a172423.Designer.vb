<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_viewCustomer_a172423
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
        Me.lbl_error_name = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_updated_at = New System.Windows.Forms.TextBox()
        Me.txt_created_at = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_error_name
        '
        Me.lbl_error_name.AutoSize = True
        Me.lbl_error_name.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_name.Location = New System.Drawing.Point(135, 155)
        Me.lbl_error_name.Name = "lbl_error_name"
        Me.lbl_error_name.Size = New System.Drawing.Size(39, 13)
        Me.lbl_error_name.TabIndex = 21
        Me.lbl_error_name.Text = "Label7"
        Me.lbl_error_name.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(246, 264)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(378, 264)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 18
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(135, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(317, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(320, 132)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 14
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(138, 132)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 56)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Customer Profile"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(317, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Updated At"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(135, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Created At"
        '
        'txt_updated_at
        '
        Me.txt_updated_at.Location = New System.Drawing.Point(320, 204)
        Me.txt_updated_at.Name = "txt_updated_at"
        Me.txt_updated_at.ReadOnly = True
        Me.txt_updated_at.Size = New System.Drawing.Size(100, 20)
        Me.txt_updated_at.TabIndex = 24
        '
        'txt_created_at
        '
        Me.txt_created_at.Location = New System.Drawing.Point(138, 204)
        Me.txt_created_at.Name = "txt_created_at"
        Me.txt_created_at.ReadOnly = True
        Me.txt_created_at.Size = New System.Drawing.Size(100, 20)
        Me.txt_created_at.TabIndex = 25
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Yellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(112, 264)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 26
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'frm_viewCustomer_a172423
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(577, 320)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_created_at)
        Me.Controls.Add(Me.txt_updated_at)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_error_name)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_viewCustomer_a172423"
        Me.Text = "frm_viewCustomer_a172423"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_error_name As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_updated_at As TextBox
    Friend WithEvents txt_created_at As TextBox
    Friend WithEvents btn_cancel As Button
End Class
