Public Class Funciones
    Private id_temp As String

    Public Sub setId(ByVal id As String)
        id_temp = id
    End Sub

    Public Function getId()
        Return id_temp
    End Function

    Public Sub seleccionCb(ByRef cb As ComboBox, ByVal id As String)
        For i = 0 To cb.Items.Count - 1
            If cb.Items(i).Value = Int(id) Then
                cb.SelectedIndex = i
            End If
        Next
    End Sub

End Class
