<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_createStaff_a172423
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbt_male = New System.Windows.Forms.RadioButton()
        Me.rbt_female = New System.Windows.Forms.RadioButton()
        Me.lbl_error_gender = New System.Windows.Forms.Label()
        Me.lbl_error_id = New System.Windows.Forms.Label()
        Me.lbl_error_name = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(28, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(412, 56)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Create New Staff"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(17, 134)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(47, 16)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Text = "Name"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(216, 134)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 16)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "ID"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.Color.White
        Me.lbl_gender.Location = New System.Drawing.Point(389, 134)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(57, 16)
        Me.lbl_gender.TabIndex = 4
        Me.lbl_gender.Text = "Gender"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(261, 153)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(49, 20)
        Me.txt_id.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(20, 153)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(216, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "STAFF"
        '
        'rbt_male
        '
        Me.rbt_male.AutoSize = True
        Me.rbt_male.ForeColor = System.Drawing.Color.White
        Me.rbt_male.Location = New System.Drawing.Point(392, 156)
        Me.rbt_male.Name = "rbt_male"
        Me.rbt_male.Size = New System.Drawing.Size(48, 17)
        Me.rbt_male.TabIndex = 8
        Me.rbt_male.TabStop = True
        Me.rbt_male.Text = "Male"
        Me.rbt_male.UseVisualStyleBackColor = True
        '
        'rbt_female
        '
        Me.rbt_female.AutoSize = True
        Me.rbt_female.ForeColor = System.Drawing.Color.White
        Me.rbt_female.Location = New System.Drawing.Point(392, 179)
        Me.rbt_female.Name = "rbt_female"
        Me.rbt_female.Size = New System.Drawing.Size(59, 17)
        Me.rbt_female.TabIndex = 9
        Me.rbt_female.TabStop = True
        Me.rbt_female.Text = "Female"
        Me.rbt_female.UseVisualStyleBackColor = True
        '
        'lbl_error_gender
        '
        Me.lbl_error_gender.AutoSize = True
        Me.lbl_error_gender.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_gender.Location = New System.Drawing.Point(389, 199)
        Me.lbl_error_gender.Name = "lbl_error_gender"
        Me.lbl_error_gender.Size = New System.Drawing.Size(64, 13)
        Me.lbl_error_gender.TabIndex = 10
        Me.lbl_error_gender.Text = "error gender"
        Me.lbl_error_gender.Visible = False
        '
        'lbl_error_id
        '
        Me.lbl_error_id.AutoSize = True
        Me.lbl_error_id.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_id.Location = New System.Drawing.Point(216, 176)
        Me.lbl_error_id.Name = "lbl_error_id"
        Me.lbl_error_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_error_id.TabIndex = 11
        Me.lbl_error_id.Text = "error id"
        Me.lbl_error_id.Visible = False
        '
        'lbl_error_name
        '
        Me.lbl_error_name.AutoSize = True
        Me.lbl_error_name.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_name.Location = New System.Drawing.Point(17, 176)
        Me.lbl_error_name.Name = "lbl_error_name"
        Me.lbl_error_name.Size = New System.Drawing.Size(57, 13)
        Me.lbl_error_name.TabIndex = 12
        Me.lbl_error_name.Text = "name error"
        Me.lbl_error_name.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Yellow
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(109, 274)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.Lime
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.Location = New System.Drawing.Point(275, 274)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 14
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'frm_createStaff_a172423
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(483, 359)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_error_name)
        Me.Controls.Add(Me.lbl_error_id)
        Me.Controls.Add(Me.lbl_error_gender)
        Me.Controls.Add(Me.rbt_female)
        Me.Controls.Add(Me.rbt_male)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_createStaff_a172423"
        Me.Text = "frm_createStaff_a172423"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbt_male As RadioButton
    Friend WithEvents rbt_female As RadioButton
    Friend WithEvents lbl_error_gender As Label
    Friend WithEvents lbl_error_id As Label
    Friend WithEvents lbl_error_name As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_create As Button
End Class
