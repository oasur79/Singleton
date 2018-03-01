Public Class acercaDe
    'Primer paso: dejar privado el constructor
    Private Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    'Segundo paso: demeos tener un atributo del tipo dela clase que sea compartido
    Private Shared _instancia As acercaDe = Nothing

    'Tercer paso: el metodo de acceso a esta clase para que devuelva nla instacia esto es publico
    Public Shared Function getInstance() As acercaDe
        If _instancia Is Nothing OrElse _instancia.IsDisposed Then 'si no existe la instancia la creamos
            _instancia = New acercaDe
        End If
        Return _instancia
    End Function





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class