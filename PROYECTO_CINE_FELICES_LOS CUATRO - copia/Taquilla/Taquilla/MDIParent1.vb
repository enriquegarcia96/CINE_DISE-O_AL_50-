Imports System.Windows.Forms

Public Class MDIParent1
    Public Sub ShowNewForm(ByVal frm As Form)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.ControlBox = False
        frm.ShowIcon = False
        frm.ShowInTaskbar = False
        frm.MaximizeBox = False
        frm.MinimizeBox = False
        frm.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm1.ShowDialog()

        Button1.Location = New Point(20, 316)
        pro1.Hide()


    End Sub

    Private Sub SalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagRealizadosToolStripMenuItem.Click
        ShowNewForm(pagos)
    End Sub

    Private Sub SillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoletosToolStripMenuItem.Click
        ShowNewForm(boletos)
    End Sub

    Private Sub PeliculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservacionToolStripMenuItem.Click
        'ShowNewForm(reservacion)
    End Sub

    Private Sub PeliculasToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ShowNewForm(peliculas)
    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub


    'probando

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (pro1.Visible = True) Then
            pro1.Visible = False
        Else
            pro1.Visible = True

        End If

        Button1.Location = New Point(20, 316)
        pro1.Location = New Point(22, 351)

        If (pro1.Visible = False) Then
            Button1.Location = New Point(20, 316)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowNewForm(peliculas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowNewForm(formato)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ShowNewForm(sala)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ShowNewForm(sillas)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ShowNewForm(Cartelera)

    End Sub
End Class
