Module Inicio
    Public mibd As BD
    Public misfunciones As Funciones

    Public Sub main()
        mibd = New BD
        misfunciones = New Funciones
        Try
            mibd.conectar()
            Application.Run(MDIParent1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
