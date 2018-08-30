Namespace Modelo
    Public Structure Usuario
        Public nombre As String
        Public fechaDeNacimiento As String
        Public sexo As TipoGenero
        Public edad As Single

        ' Constructor
        Public Sub New(nuevoNombre As String, nuevoFechaDeNac As String, nuevoSexo As TipoGenero, nuevaEdad As Single)
            nombre = nuevoNombre
            fechaDeNacimiento = nuevoFechaDeNac
            sexo = nuevoSexo
            edad = nuevaEdad
            Console.Write("Se ha creado el nuevo usuario " + nombre)
        End Sub

        Function RellenarConRegistro(ByVal textoRegistro As String) As Boolean

            Dim arrayCampos() As String = textoRegistro.Split(CType(",", Char))

            If arrayCampos.Length = 5 Then
                nombre = arrayCampos(0)
                fechaDeNacimiento = arrayCampos(1)
                sexo = CType(Integer.Parse(arrayCampos(2)), TipoGenero)
                edad = Single.Parse(arrayCampos(2))
                Console.WriteLine(ToString())
                Return True
            Else
                Console.WriteLine("Error al leer usuario " & textoRegistro)
                Return False
            End If
        End Function
        Overrides Function ToString() As String
            Return nombre.ToString() + " " & sexo.ToString() & " " & edad.ToString()
        End Function
    End Structure
End Namespace