Imports System.Data.OleDb

Public Class DBControl
    ' CREATE DB CONNECTION
    Public DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=HOTEL_DB.accdb;")

    'MAKE DB COMMAND
    Public DBCmd As OleDbCommand

    'DB DATA STORING AND HANDLING
    Public DBDA As OleDbDataAdapter
    Public DBDT As DataTable
    Public DS As DataSet
    'FOR MANAFGING QUERY DATA
    Public Params As New List(Of OleDbParameter)

    'QUERY STATISTICS
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        'First thing reset query stats
        RecordCount = 0
        Exception = ""

        Try
            'Open a connection
            DBCon.Open()

            'Create DB commnd
            DBCmd = New OleDbCommand(Query, DBCon)

            'Load Params INTO DB COMMND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            ' Clear params list
            Params.Clear()

            'Exec cmnd and fill data table
            DBDT = New DataTable
            DBDA = New OleDbDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        'CLOSE DB CONNECTION
        If DBCon.State = ConnectionState.Open Then DBCon.Close()

    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)

    End Sub
End Class
