Imports MySql.Data.MySqlClient
Public Class boletos
    Public id As Integer

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub boletos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub cargarLVHeaders()
        lvSillas.Columns.Add("ID").Width() = 40
        lvSillas.Columns.Add("Hora").Width() = 200
        lvSillas.Columns.Add("Sala").Width() = 300
        lvSillas.Columns.Add("Silla").Width() = 300
        lvSillas.Columns.Add("Pelicula").Width() = 300
        lvSillas.Columns.Add("Fecha").Width() = 300

    End Sub

    Private Sub cargarLV()
        lvSillas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.reservacion_boleto
            INNER JOIN reservacion ON reservacion_boleto.id_reservacion = reservacion.id_reservacion
            INNER JOIN peliculas ON peliculas.id_peliculas = reservacion.id_pelicula
            INNER JOIN boleto ON reservacion_boleto.id_boleto = boleto.idboleto
            INNER JOIN cartelera ON cartelera.id_cartelera = boleto.id_cartelera
                ORDER BY id_boleto ASC;;"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvSillas.Items.Add(registros("reservacion_boleto"))
                lvSillas.Items(i).SubItems.Add(registros("hora_inicio"))
                lvSillas.Items(i).SubItems.Add(registros("id_Sala"))
                lvSillas.Items(i).SubItems.Add(registros("id_Silla"))
                lvSillas.Items(i).SubItems.Add(registros("nombre_pelicula"))
                lvSillas.Items(i).SubItems.Add(registros("fecha_compra"))
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


End Class