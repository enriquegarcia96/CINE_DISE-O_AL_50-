Imports MySql.Data.MySqlClient

Public Class sillas
    Public id As Integer

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub sillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub cargarLVHeaders()
        lvSillas.Columns.Add("ID").Width() = 40
        lvSillas.Columns.Add("Sala").Width() = 200
        lvSillas.Columns.Add("Nombre de la silla").Width() = 500

    End Sub

    Private Sub cargarLV()
        lvSillas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.sillas
        INNER JOIN sala ON sala.id_sala = sillas.id_sala
        ORDER BY id_silla ASC"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvSillas.Items.Add(registros("id_silla"))
                lvSillas.Items(i).SubItems.Add(registros("id_sala"))
                lvSillas.Items(i).SubItems.Add(registros("nombre_silla"))
                i += 1
            End While
        End If
        registros.Close()
    End Sub

    Private Sub lvSillas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSillas.SelectedIndexChanged

        Try
            id = lvSillas.SelectedItems(0).Text
            misfunciones.setId(id)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Nueva_silla.ShowDialog()
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Editar_silla.ShowDialog()
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

        sql = "DELETE FROM cine.sillas 
        WHERE id_silla = '" & misfunciones.getId & "';"

        mibd.sentencias(sql)

        MessageBox.Show("Se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class