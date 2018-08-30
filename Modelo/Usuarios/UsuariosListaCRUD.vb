Imports System.Linq

Namespace Modelo

    ' CRUD: Create, Read, Update, Delete
    ' Crear, Leer, Actualizar, Eliminar
    Public Class UsuariosListaCRUD
        Implements IUsuariosCRUD

        Private listaUsuarios As List(Of Usuario)
        Public avisarEnModicacion As TipoDelAvisarEnModificacion

        Private ReadOnly Property Cantidad As Integer Implements IUsuariosCRUD.Cantidad
            Get
                Return listaUsuarios.Count
            End Get
        End Property
        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IUsuariosCRUD.EstablecerAvisarEnModificacion
            avisarEnModicacion = funcionDelegada
        End Sub
        Sub Crear(nuevoUsuario As Usuario) Implements IUsuariosCRUD.Crear
            ' Asignamos nuevo usuario
            listaUsuarios.Add(nuevoUsuario)
            avisarEnModicacion(True)
        End Sub
        Function BuscarUsuarios(nombre As String) As List(Of Usuario) Implements IUsuariosCRUD.BuscarUsuarios
            nombre = nombre.ToUpper()

            Dim consultaLINQ = From usuario In listaUsuarios.ToArray()
                               Where usuario.nombre.ToUpper().Contains(nombre)
                               Order By usuario.nombre
                               Select usuario

            BuscarUsuarios = consultaLINQ.ToList()
        End Function
        Function BuscarUsuariosConFor(nombre As String) As List(Of Usuario)

            nombre = nombre.ToUpper()
            BuscarUsuariosConFor = New List(Of Usuario)()

            For index = 0 To listaUsuarios.Count - 1
                Dim encontradoNombre As Boolean = False
                If nombre = "" Or
                    (nombre <> "" And listaUsuarios(index).nombre.ToUpper().Contains(nombre)) Then
                    encontradoNombre = True
                End If
                If encontradoNombre Then
                    BuscarUsuariosConFor.Add(listaUsuarios(index))
                End If
            Next
        End Function
        Sub Actualizar(indice As Integer, usuario As Usuario)
            listaUsuarios(indice) = usuario
            avisarEnModicacion(True)
        End Sub
        Sub Actualizar(usuario As Usuario, usuarioModif As Usuario) Implements IUsuariosCRUD.Actualizar
            Dim i = listaUsuarios.IndexOf(usuario)
            Actualizar(i, usuarioModif)
        End Sub
        '' Para eliminar
        '' 1 2 3 4 5 6 7 8 9 10
        '' posicion:
        '' 0 1 2 3 4
        Sub Eliminar(indice As Integer)
            listaUsuarios.RemoveAt(indice)
            avisarEnModicacion(True)
        End Sub
        Sub Eliminar(usuario As Usuario) Implements IUsuariosCRUD.Eliminar
            listaUsuarios.Remove(usuario)
            avisarEnModicacion(True)
        End Sub
        Sub Eliminar(usuarios As List(Of Usuario)) Implements IUsuariosCRUD.Eliminar
            For Each usuario In usuarios
                Eliminar(usuario)
            Next
            avisarEnModicacion(True)
        End Sub


    End Class
End Namespace