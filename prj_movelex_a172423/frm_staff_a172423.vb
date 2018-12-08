Public Class frm_staff_a172423
    Private Sub frm_staff_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A172423"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_staff.DataSource = table
        Dim btn As New DataGridViewButtonColumn()
        grd_staff.Columns.Add(btn)
        btn.HeaderText = "Detail"
        btn.Text = "View"
        btn.Name = "btn_view"
        btn.UseColumnTextForButtonValue = True
        lbl_total.Text = "Total Staff : " & table.Rows.Count() & ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_mainmenu_a172423.Show()
        Me.Hide()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Me.Close()
        frm_createStaff_a172423.Show()
    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick
        Dim num As Integer = grd_staff.CurrentCell.RowIndex
        Dim value = grd_staff.Rows(num).Cells(0).Value.ToString
        product_id = value
        frm_viewStaff_a172423.Show()
        Me.Close()
    End Sub
End Class