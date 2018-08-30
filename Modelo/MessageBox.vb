Namespace Modelo
    Public Module MessageBox
        Public Delegate Sub TipoMostrarMensaje(mensaje As String)
        Public MostrarMensaje As TipoMostrarMensaje

        Public Sub Show(mensaje As String)
            MostrarMensaje("Modelo DLL: " + mensaje)
        End Sub
    End Module
End Namespace
