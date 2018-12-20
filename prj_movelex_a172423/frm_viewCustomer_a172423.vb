Public Class frm_viewCustomer_a172423
    Private Sub frm_viewCustomer_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A172423 WHERE FLD_CUSTOMER_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        txt_name.Text = table.Rows(0).Item(1)
        txt_id.Text = table.Rows(0).Item(0)
        txt_created_at.Text = table.Rows(0).Item(2)
        txt_updated_at.Text = table.Rows(0).Item(3)
    End Sub

    'cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_customer_a172423.Show()
    End Sub

    'delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A172423 WHERE FLD_CUSTOMER_ID='" & product_id & "'"
        Dim table As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(mysql, connection)
        reader.Fill(table)

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this product?", MsgBoxStyle.YesNoCancel)

        If delete_confirmation = MsgBoxResult.Yes Then

            Me.Hide()
            run_sql_command("DELETE FROM TBL_CUSTOMER_A172423 WHERE FLD_CUSTOMER_ID='" & product_id & "'")
            frm_customer_a172423.Show()
            Me.Close()
            MsgBox("Your customer has been deleted!")

        End If
    End Sub

    'update
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Me.Refresh()

        Dim checkInput As Boolean = True

        'name
        If String.IsNullOrEmpty(txt_name.Text) Then
            lbl_error_name.Visible = True
            lbl_error_name.Text = "Enter customer name!"
            checkInput = False
        Else
            lbl_error_name.Visible = False
        End If

        'name
        If String.IsNullOrEmpty(txt_address.Text) Then
            lbl_error_address.Visible = True
            lbl_error_address.Text = "Enter customer address!"
            checkInput = False
        Else
            lbl_error_address.Visible = False
        End If

        If checkInput = True Then
            Try
                'name
                run_sql_command("UPDATE TBL_CUSTOMER_A172423 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "' WHERE FLD_CUSTOMER_ID='" & product_id & "'")
                'id
                run_sql_command("UPDATE TBL_CUSTOMER_A172423 SET FLD_CUSTOMER_ID='" & txt_id.Text & "' WHERE FLD_CUSTOMER_ID='" & product_id & "'")
                'address
                run_sql_command("UPDATE TBL_CUSTOMER_A172423 SET FLD_CUSTOMER_ADDRESS='" & txt_address.Text & "' WHERE FLD_CUSTOMER_ID='" & product_id & "'")
                'updated_at
                run_sql_command("UPDATE TBL_CUSTOMER_A172423 SET FLD_UPDATED_AT='" & today & "' WHERE FLD_CUSTOMER_ID='" & product_id & "'")
                'created_at
                run_sql_command("UPDATE TBL_CUSTOMER_A172423 SET FLD_CREATED_AT='" & txt_created_at.Text & "' WHERE FLD_CUSTOMER_ID='" & product_id & "'")

                Dim reopen As New frm_viewCustomer_a172423
                Me.Close()
                reopen.Show()
                Beep()
                MsgBox("Your change has been save!")
            Catch ex As Exception
                Dim reopen As New frm_viewCustomer_a172423
                Me.Close()
                reopen.Show()

                MsgBox("Opps! this is so embarrassing, an error has occur. " & ex.Message)
            End Try
        End If
    End Sub
End Class