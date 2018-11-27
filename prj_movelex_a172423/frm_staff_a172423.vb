Public Class frm_staff_a172423
    Private Sub frm_staff_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A172423"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        grd_staff.DataSource = table
        lbl_total.Text = "Total Staff : " & table.Rows.Count() & ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_mainmenu_a172423.Show()
        Me.Hide()
    End Sub
End Class