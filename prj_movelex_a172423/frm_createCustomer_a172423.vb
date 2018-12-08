Public Class frm_createCustomer_a172423
    Private Sub frm_createCustomer_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_customer_a172423.Show()
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
            lbl_error_id.Text = "Enter customer id!"
            checkInput = False
        ElseIf IsNumeric(txt_id.Text) = False Then
            lbl_error_id.Visible = True
            lbl_error_id.Text = "Number only!"
            checkInput = False
        Else
            lbl_error_id.Visible = False
        End If

        If checkInput = True Then
            Try
                Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A172423 VALUES ('" & "CUST" + txt_id.Text & "','" & txt_name.Text & "','" & today & "','" & today & "' )"
                Dim save As New OleDb.OleDbCommand(mysql, myconnection2)

                'close again if error accour
                save.Connection.Close()
                save.Connection.Open()
                save.ExecuteNonQuery()
                save.Connection.Close()

                Me.Close()
                frm_customer_a172423.Show()

                Beep()
                MsgBox("Your new customer has been created!")
            Catch ex As Exception
                Dim reopen As New frm_createCustomer_a172423
                Me.Close()
                reopen.Show()

                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            End Try
        End If
    End Sub
End Class