Public Class frm_createProduct_a172423
    Private Sub frm_createProduct_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_browseImage_Click(sender As Object, e As EventArgs) Handles btn_browseImage.Click
        Dim picture As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = picture
        OpenFileDialog1.FileName =
        OpenFileDialog1.Filter = "JPG Files|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            lbl_error_image.Visible = False
            product_image.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            lbl_filename_image.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            If String.IsNullOrEmpty(lbl_filename_image.Text) Then
                lbl_error_image.Visible = True
                lbl_error_image.Text = "Please select a image!"
            Else
            End If
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_product_a172423.Show()
        Me.Close()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        Me.Refresh()

        Dim checkInput As Boolean = True

        'name
        If String.IsNullOrEmpty(txt_name.Text) Then
            lbl_error_name.Visible = True
            lbl_error_name.Text = "Enter product name!"
            checkInput = False
        Else
            lbl_error_name.Visible = False
        End If

        'id
        If String.IsNullOrEmpty(txt_id.Text) Then
            lbl_error_id.Visible = True
            lbl_error_id.Text = "Enter product id!"
            checkInput = False
        Else
            lbl_error_id.Visible = False
        End If

        'price
        If String.IsNullOrEmpty(txt_price.Text) Then
            lbl_error_price.Visible = True
            lbl_error_price.Text = "Enter product price!"
            checkInput = False
        ElseIf IsNumeric(txt_price.Text) = False Then
            lbl_error_price.Visible = True
            lbl_error_price.Text = "Number only!"
            checkInput = False
        Else
            lbl_error_price.Visible = False
        End If

        'quantity
        If String.IsNullOrEmpty(txt_quantity.Text) Then
            lbl_error_quantity.Visible = True
            lbl_error_quantity.Text = "Enter product quantity!"
            checkInput = False
        ElseIf IsNumeric(txt_quantity.Text) = False Then
            lbl_error_quantity.Visible = True
            lbl_error_quantity.Text = "Number only!"
            checkInput = False
        Else
            lbl_error_quantity.Visible = False
        End If

        'checked
        Dim product_type As String = ""
        If rb_clockRadio.Checked = True Then
            product_type = "Clock Radio"
            lbl_error_type.Visible = False
        ElseIf rb_radio.Checked = True Then
            product_type = "Radio"
            lbl_error_type.Visible = False
        ElseIf rb_desk_clock.Checked = True Then
            product_type = "Desk Clock"
            lbl_error_type.Visible = False
        Else
            lbl_error_type.Visible = True
            lbl_error_type.Text = "Select one of the type!"
            checkInput = False
        End If

        'material
        If String.IsNullOrEmpty(txt_material.Text) Then
            lbl_error_material.Visible = True
            lbl_error_material.Text = "Enter product material!"
            checkInput = False
        Else
            lbl_error_material.Visible = False
        End If

        'battery
        If String.IsNullOrEmpty(txt_battery.Text) Then
            lbl_error_battery.Visible = True
            lbl_error_battery.Text = "Enter product battery!"
            checkInput = False
        Else
            lbl_error_battery.Visible = False
        End If

        'image
        If String.IsNullOrEmpty(lbl_filename_image.Text) Then
            lbl_error_image.Visible = True
            lbl_error_image.Text = "Select product image!"
            checkInput = False
        Else
            lbl_error_image.Visible = False
        End If

        If checkInput = True Then
            'save query
            Try

                Dim mysql As String = "INSERT INTO TBL_PRODUCT_A172423 VALUES ('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_price.Text & "','" & txt_quantity.Text & "','" & product_type & "','" & txt_material.Text & "','" & txt_battery.Text & "','" & OpenFileDialog1.FileName & "','" & today & "','" & today & "' )"
                Dim save As New OleDb.OleDbCommand(mysql, myconnection2)

                'close again if error accour
                save.Connection.Close()
                save.Connection.Open()
                save.ExecuteNonQuery()
                save.Connection.Close()

                Me.Close()
                frm_product_a172423.Show()

            Catch ex As Exception

                Dim reopen As New frm_createProduct_a172423
                Me.Close()
                reopen.Show()

                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)

            End Try
        End If

    End Sub

End Class