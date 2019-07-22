Imports MySql.Data.MySqlClient

Public Class sala
    Public id As Integer

    Private Sub cargarLVHeaders()
        lvPeliculas.Columns.Add("ID").Width() = 40
        lvPeliculas.Columns.Add("Capacidad").Width() = 200

    End Sub

    Private Sub cargarLV()
        lvPeliculas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.sala
        ORDER BY id_sala ASC"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPeliculas.Items.Add(registros("id_sala"))
                lvPeliculas.Items(i).SubItems.Add(registros("capacidad"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub
    Private Sub sala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV()
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        nueva_sala.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        editar_sala.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        eliminar()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Public Sub eliminar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_sala As Integer = 0

        sql = "DELETE FROM cine.sala 
        WHERE id_sala = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lvPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPeliculas.SelectedIndexChanged
        Try
            id = lvPeliculas.SelectedItems(0).Text
            misfunciones.setId(id)
        Catch ex As Exception

        End Try

    End Sub


End Class