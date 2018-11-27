Public Class frm_createProduct_a172423
    Private Sub frm_createProduct_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_browseImage_Click(sender As Object, e As EventArgs) Handles btn_browseImage.Click
        Dim picture As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = picture
        OpenFileDialog1.FileName =
        OpenFileDialog1.Filter = "JPG files (*.jpg) |*.jpg"
        OpenFileDialog1.ShowDialog()

        product_image.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        lbl_test.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_product_a172423.Show()
        Me.Close()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        'check which type is checked
        Dim product_type As String
        If rb_clockRadio.Checked = True Then
            product_type = "Clock Radio"
        ElseIf rb_radio.Checked = True Then
            product_type = "Radio"
        Else
            product_type = "Desk Clock"
        End If

        'save query
        Dim mysql As String = "INSERT INTO TBL_PRODUCT_A172423 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_price.Text & "','" & txt_quantity.Text & "','" & product_type & "','" & txt_material.Text & "','" & txt_battery.Text & "','" & OpenFileDialog1.FileName & "','" & today & "','" & today & "' )"

        Dim save As New OleDb.OleDbCommand(mysql, myconnection2)

        save.Connection.Open()
        save.ExecuteNonQuery()
        save.Connection.Close()
    End Sub
End Class