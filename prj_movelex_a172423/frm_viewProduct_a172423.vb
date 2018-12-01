Public Class frm_viewProduct_a172423

    Private Sub frm_viewProduct_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A172423 WHERE FLD_PRODUCT_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        txt_name.Text = table.Rows(0).Item(1)
        txt_price.Text = table.Rows(0).Item(2)
        txt_quantity.Text = table.Rows(0).Item(3)
        If table.Rows(0).Item(4) = "Desk Clock" Then
            cmb_type.Items.Add("Desk Clock")
            cmb_type.Items.Add("Clock Radio")
            cmb_type.Items.Add("Radio")
        ElseIf table.Rows(0).Item(4) = "Clock Radio" Then
            cmb_type.Items.Add("Clock Radio")
            cmb_type.Items.Add("Desk Clock")
            cmb_type.Items.Add("Radio")
        Else
            cmb_type.Items.Add("Radio")
            cmb_type.Items.Add("Desk Clock")
            cmb_type.Items.Add("Clock Radio")
        End If
        txt_material.Text = table.Rows(0).Item(5)
        txt_battery.Text = table.Rows(0).Item(6)
        txt_created_at.Text = table.Rows(0).Item(8)
        txt_updated_at.Text = table.Rows(0).Item(9)
        pic_product.ImageLocation = "pictures/" + table.Rows(0).Item(7)
        pic_product.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Text = today

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        product_id = ""
        frm_product_a172423.Show()
        Me.Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this product?", MsgBoxStyle.YesNoCancel)

        If delete_confirmation = MsgBoxResult.Yes Then

            Me.Hide()
            run_sql_command("DELETE FROM TBL_PRODUCT_A172423 WHERE FLD_PRODUCT_ID='" & product_id & "'")
            frm_product_a172423.Show()
            Me.Close()
            MsgBox("Your product has been deleted!")

        End If

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

    End Sub
End Class