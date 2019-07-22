Imports MySql.Data.MySqlClient
Public Class BD
    Dim cadenaconexion As MySqlConnectionStringBuilder

    Public db As MySqlConnection
    Public Property estado As Boolean

    Public Sub conectar()
        Try
            cadenaconexion = New MySqlConnectionStringBuilder
            cadenaconexion.Server = "127.0.0.1"
            cadenaconexion.UserID = "root"
            cadenaconexion.Port = "3306"
            cadenaconexion.Database = "cine"
            cadenaconexion.Password = "Dragon97"
            db = New MySqlConnection(cadenaconexion.ToString)

            db.Open()
            estado = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        End Try
    End Sub

    Public Sub sentencias(ByVal query As String)
        Dim micomando As MySqlCommand
        Try
            micomando = New MySqlCommand(query, db)
            micomando.ExecuteNonQuery()
            micomando.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function consulta(ByVal query As String)
        Dim micomando As MySqlCommand
        Dim misdatos As MySqlDataReader
        Try
            micomando = New MySqlCommand(query, db)
            misdatos = micomando.ExecuteReader

            Return misdatos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return -1
        End Try
    End Function

End Class
