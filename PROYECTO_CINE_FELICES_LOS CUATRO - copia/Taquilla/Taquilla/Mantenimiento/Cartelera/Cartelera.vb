Imports MySql.Data.MySqlClient

Public Class Cartelera
    Public id As Integer

    Private Sub Cartelera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV1()
    End Sub

    Private Sub cargarLVHeaders()
        lvPeliculas.Columns.Add("ID").Width() = 40
        lvPeliculas.Columns.Add("Sala").Width() = 500
        lvPeliculas.Columns.Add("Hora de nicio").Width() = 100
        lvPeliculas.Columns.Add("Fin de funcion ").Width() = 100
        lvPeliculas.Columns.Add("Estado").Width() = 100

    End Sub

    Private Sub cargarLV1()
        lvPeliculas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.cartelera
       
        ORDER BY id_cartelera ASC"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvPeliculas.Items.Add(registros("id_cartelera"))
                lvPeliculas.Items(i).SubItems.Add(registros("id_sala"))
                lvPeliculas.Items(i).SubItems.Add(registros("hora_inicio"))
                lvPeliculas.Items(i).SubItems.Add(registros("hora_final"))
                lvPeliculas.Items(i).SubItems.Add(registros("estado"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        nueva_cartelera.ShowDialog()
        cargarLVHeaders()
        cargarLV1()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        editar_cartelera.ShowDialog()
        cargarLVHeaders()
        cargarLV1()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        eliminar()
        cargarLVHeaders()
        cargarLV1()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub

    Public Sub eliminar()
        Dim sql As String = "", registros As MySqlDataReader = Nothing, id_cartelera As Integer = 0

        sql = "DELETE FROM cine.cartelera
        WHERE id_cartelera = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lvPeliculas_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvPeliculas.SelectedIndexChanged
        Try
            id = lvPeliculas.SelectedItems(0).Text
            misfunciones.setId(id)
        Catch ex As Exception

        End Try
    End Sub
End Class