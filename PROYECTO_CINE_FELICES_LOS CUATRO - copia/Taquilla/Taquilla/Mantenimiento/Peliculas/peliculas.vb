Imports MySql.Data.MySqlClient

Public Class peliculas
    Public id As Integer

    Private Sub peliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV()

    End Sub

    Private Sub cargarLVHeaders()
        lvPeliculas.Columns.Add("ID").Width() = 40
        lvPeliculas.Columns.Add("Nombre de Pelicula").Width() = 200
        lvPeliculas.Columns.Add("Descripcion").Width() = 500
        lvPeliculas.Columns.Add("Duracion").Width() = 200
        lvPeliculas.Columns.Add("Estado").Width() = 200

    End Sub

    Private Sub cargarLV()
        lvPeliculas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.peliculas
                ORDER BY id_peliculas ASC"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPeliculas.Items.Add(registros("id_peliculas"))
                lvPeliculas.Items(i).SubItems.Add(registros("nombre_pelicula"))
                lvPeliculas.Items(i).SubItems.Add(registros("descripcion"))
                lvPeliculas.Items(i).SubItems.Add(registros("duracion_pelicula"))
                lvPeliculas.Items(i).SubItems.Add(registros("estado"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        NuevaPelicula.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        EditarPelicula.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'EliminarPelicula.ShowDialog()
        eliminar()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub lvPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPeliculas.SelectedIndexChanged

        Try
            id = lvPeliculas.SelectedItems(0).Text
            misfunciones.setId(id)
        Catch ex As Exception

        End Try


    End Sub

    Public Sub eliminar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_peliculas As Integer = 0

        sql = "DELETE FROM cine.peliculas 
        WHERE id_peliculas = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class