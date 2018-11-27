Public Class frm_viewProduct_a172423

    Private Sub frm_viewProduct_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A172423 WHERE FLD_PRODUCT_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)
        txt_name.Text = table.Rows(0).Item(1)
        txt_price.Text = table.Rows(0).Item(2)
        txt_quantity.Text = table.Rows(0).Item(3)
        txt_type.Text = table.Rows(0).Item(4)
        txt_material.Text = table.Rows(0).Item(5)
        txt_battery.Text = table.Rows(0).Item(6)
        txt_createdAt.Text = table.Rows(0).Item(8)
        txt_updatedAt.Text = table.Rows(0).Item(9)
        pic_product.ImageLocation = "pictures/" + table.Rows(0).Item(7)
        pic_product.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Text = today
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        product_id = ""
        frm_product_a172423.Show()
        Me.Close()
    End Sub
End Class