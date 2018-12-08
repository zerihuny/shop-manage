<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staff_a172423
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
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff"
        '
        'grd_staff
        '
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_staff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(22, 82)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.Size = New System.Drawing.Size(728, 144)
        Me.grd_staff.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_total.Location = New System.Drawing.Point(19, 229)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(49, 16)
        Me.lbl_total.TabIndex = 4
        Me.lbl_total.Text = "Label2"
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.Lime
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_create.Location = New System.Drawing.Point(675, 40)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 5
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.Yellow
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.Black
        Me.btn_home.Location = New System.Drawing.Point(594, 40)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(75, 23)
        Me.btn_home.TabIndex = 1
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'frm_staff_a172423
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(770, 283)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_staff_a172423"
        Me.Text = "Staff"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_home As Button
End Class
