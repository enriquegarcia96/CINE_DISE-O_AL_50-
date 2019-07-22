Imports MySql.Data.MySqlClient
Public Class pagos
    Public id As Integer

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLVHeaders()
        cargarLV()
    End Sub

    Private Sub cargarLVHeaders()
        lvSillas.Columns.Add("ID").Width() = 40
        lvSillas.Columns.Add("Reservacion").Width() = 200
        lvSillas.Columns.Add("Monto").Width() = 500

    End Sub

    Private Sub cargarLV()
        lvSillas.Items.Clear()

        Dim registros As MySqlDataReader
        Dim query As String = "SELECT * FROM cine.historico_pagos
        INNER JOIN formato ON formato.id_formato = historico_pagos.id_formato
        ORDER BY id_pago ASC"
        Dim i As Integer = 0

        registros = mibd.consulta(query)

        If registros.HasRows Then
            While registros.Read
                lvSillas.Items.Add(registros("id_pago"))
                lvSillas.Items(i).SubItems.Add(registros("id_reservacion"))
                lvSillas.Items(i).SubItems.Add(registros("precio_formato"))
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