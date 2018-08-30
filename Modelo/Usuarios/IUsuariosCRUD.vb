Namespace Modelo

    Public Delegate Sub TipoDelAvisarEnModificacion(estado As Boolean)

    Public Interface IUsuariosCRUD
        ReadOnly Property Cantidad As Integer
        Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion)
        Sub Crear(nuevoUsuario As Usuario)
        Function BuscarUsuarios(nombre As String) As List(Of Usuario)
        Sub Actualizar(usuario As Usuario, usuarioModif As Usuario)
        Sub Eliminar(usuario As Usuario)
        Sub Eliminar(usuarios As List(Of Usuario))
    End Interface
End Namespace
