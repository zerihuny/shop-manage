Module mod_global_a172423
    'database connection (read only)
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_MOVELEX_A172423.accdb;
        Persist Security Info=False;"

    'database connection (read & write)
    Public myconnection2 As New OleDb.OleDbConnection(connection)

    'search product
    Public product_id As String = ""

    'date today
    Public today As Date = Date.Now()
End Module
