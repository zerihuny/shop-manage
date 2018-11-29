Public Class frm_product_a172423

    Private Sub frm_product_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A172423"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_product.DataSource = table
        Dim btn As New DataGridViewButtonColumn()
        grd_product.Columns.Add(btn)
        btn.HeaderText = "Detail"
        btn.Text = "View"
        btn.Name = "btn_view"
        btn.UseColumnTextForButtonValue = True
        lbl_total.Text = "Total Product : " & table.Rows.Count() & ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_mainmenu_a172423.Show()
        Me.Hide()
    End Sub

    Private Sub grd_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellContentClick
        Dim num As Integer = grd_product.CurrentCell.RowIndex
        Dim value = grd_product.Rows(num).Cells(0).Value.ToString
        product_id = value
        frm_viewProduct_a172423.Show()
        Me.Close()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        frm_createProduct_a172423.Show()
        Me.Close()
    End Sub
End Class