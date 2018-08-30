Imports System.Data.OleDb

Namespace Modelo
    Public Class UsuariossAccessCRUD
        Implements IUsuariosCRUD

        Private cadena_conexion As String
        Public avisarEnModicacion As TipoDelAvisarEnModificacion

        Public ReadOnly Property Cantidad As Integer Implements IUsuariosCRUD.Cantidad
            Get
                Dim comando = ComandoConConexion(cadena_conexion, "SELECT  COUNT(*) FROM Usuario ")
                Cantidad = comando.ExecuteScalar()
                comando.Cerrar()
                Return Cantidad
            End Get
        End Property
        Public Sub Actualizar(usuario As Usuario, usuarioModif As Usuario) Implements IUsuariosCRUD.Actualizar
            If usuario.nombre = "" Then
                Throw New ArgumentException()
            End If
            Dim consultaSQL = "UPDATE usuario SET Nombre = @nombre, FechaDeNacimiento = @fechaDeNacimiento, Sexo = @sexo,  " _
                           & " Edad = @edad  " _
                           & " WHERE Nombre = @nombreABuscar ;"

            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", usuarioModif.nombre)
            comando.AñadirParametro("@fechaDeNacimiento", usuarioModif.fechaDeNacimiento)
            comando.AñadirParametro("@sexo", usuarioModif.sexo, , DbType.Int32)
            comando.AñadirParametro("@edad", usuarioModif.edad, , DbType.Single)

            comando.AñadirParametro("@nombreABuscar", usuarioModif.nombre)

            comando.ExecuteNonQuery()
            comando.Cerrar()

        End Sub
        Public Sub Crear(nuevoUsuario As Usuario) Implements IUsuariosCRUD.Crear

            Dim consultaSQL = "INSERT INTO usuario ( Nombre, FechaDeNacimiento, Sexo," _
                            & "Edad ) VALUES (@nombre, @fechaDeNacimiento, @sexo, @edad )"

            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", nuevoUsuario.nombre)
            comando.AñadirParametro("@fechaDeNacimiento", nuevoUsuario.fechaDeNacimiento)
            comando.AñadirParametro("@genero", nuevoUsuario.sexo, , DbType.Int32)
            comando.AñadirParametro("@retribucionFija", nuevoUsuario.edad, , DbType.Single)

            comando.ExecuteNonQuery()
            comando.Cerrar()
        End Sub

        Public Function BuscarUsuarios(nombre As String) As List(Of Usuario) Implements IUsuariosCRUD.BuscarUsuarios


            Dim consultaSQL = "SELECT Nombre, FechaDeNacimiento, Sexo, Edad " _
                    & " FROM Usuario "

            consultaSQL &= SqlWhereNombre(nombre)
            consultaSQL = consultaSQL + " ORDER BY Nombre ASC;"
            Console.WriteLine(consultaSQL)

            BuscarUsuarios = New List(Of Usuario)

            Dim comando = ComandoConConexion(cadena_conexion, consultaSQL)
            Try
                comando.AñadirParametro("@nombre", nombre)

                Dim dataReader As OleDbDataReader = comando.ExecuteReader()
                Do While dataReader.Read()
                    Dim nuevoUsuario As New Usuario()
                    nuevoUsuario.nombre = CType(dataReader(0), String)
                    nuevoUsuario.fechaDeNacimiento = dataReader.GetString(1)
                    nuevoUsuario.sexo = CType(dataReader(2), TipoGenero)
                    nuevoUsuario.edad = CType(dataReader(4), Single)

                    BuscarUsuarios.Add(nuevoUsuario)
                Loop
                dataReader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al buscar " & ex.Message)
            End Try
            comando.Cerrar()
        End Function
        Public Sub Eliminar(usuario As Usuario) Implements IUsuariosCRUD.Eliminar
            If usuario.nombre = "" Then
                Throw New ArgumentException()
            End If
            Dim consultaSQL = "DELETE FROM usuario   "
            consultaSQL &= SqlWhereNombre(usuario.nombre)
            Dim comando As OleDbCommand = ComandoConConexion(cadena_conexion, consultaSQL)

            comando.AñadirParametro("@nombre", usuario.nombre)

            comando.ExecuteNonQuery()
            comando.Cerrar()
            avisarEnModicacion(True)
        End Sub
        Sub Eliminar(usuarios As List(Of Usuario)) Implements IUsuariosCRUD.Eliminar
            For Each usuario In usuarios
                Eliminar(usuario)
            Next
            avisarEnModicacion(True)
        End Sub
        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IUsuariosCRUD.EstablecerAvisarEnModificacion
            avisarEnModicacion = funcionDelegada
        End Sub

    End Class
End Namespace
