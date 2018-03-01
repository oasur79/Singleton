Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Dim acerca As New acercaDe
        'acerca.Show()

        'Cuarto paso: utlizamos la instancia con su metodo de acceso que creamos
        acercaDe.getInstance.Show()
        acercaDe.getInstance.BringToFront()



    End Sub
End Class
