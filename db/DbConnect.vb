
Imports MySql.Data.MySqlClient
Public Class DbConnect
    Private Shared _connection As MySqlConnection
    Private Shared ReadOnly url As String = "Server=localhost;Database=im_pos_fr;User Id=root;Password=;"

    Public Shared Function GetConnection() As MySqlConnection
        If _connection Is Nothing Then
            _connection = New MySqlConnection(url)
            _connection.Open()
        End If
        Return _connection
    End Function
End Class
