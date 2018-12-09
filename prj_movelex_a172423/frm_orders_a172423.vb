Public Class frm_orders_a172423
    Private Sub frm_orders_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDERS_A172423"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_order.DataSource = table
        lbl_total.Text = "Total Order : " & table.Rows.Count() & ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_mainmenu_a172423.Show()
        Me.Hide()
    End Sub
End Class