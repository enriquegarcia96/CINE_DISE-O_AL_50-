Imports MySql.Data.MySqlClient

Public Class formato
    Public id As Integer

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub lvPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPeliculas.SelectedIndexChanged
        Try
            id = lvPeliculas.SelectedItems(0).Text
            misfunciones.setId(id)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub formato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub cargarLVHeaders()
        lvPeliculas.Columns.Add("ID").Width() = 40
        lvPeliculas.Columns.Add("Formato").Width() = 500
        lvPeliculas.Columns.Add("Precio").Width() = 200

    End Sub

    Private Sub cargarLV()
        lvPeliculas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.formato
        ORDER BY id_formato ASC"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPeliculas.Items.Add(registros("id_formato"))
                lvPeliculas.Items(i).SubItems.Add(registros("nombre_formato"))
                lvPeliculas.Items(i).SubItems.Add(registros("precio_formato"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        nuevo_formato.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        editar_formato.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        eliminar()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Public Sub eliminar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_peliculas As Integer = 0

        sql = "DELETE FROM cine.formato 
        WHERE id_formato = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class