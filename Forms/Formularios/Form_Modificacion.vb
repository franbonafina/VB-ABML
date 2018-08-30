Imports Modelo.Modelo

Public Class Form_Modificacion
    Private _usuario, _usuarioModif As Usuario

    Public Property Usuario As Usuario
        Get
            Return _usuario
        End Get
        Set(value As Usuario)
            _usuario = value
        End Set
    End Property
    Public Property UsuarioModif As Usuario
        Get
            Return _usuarioModif
        End Get
        Set(value As Usuario)
            _usuarioModif = value
        End Set
    End Property

    Private Property _nuevoModif As Modelo.Modelo.Usuario

    Private Sub Form_Modificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = Usuario.nombre
        txtFechaDeNacimiento.Text = Usuario.fechaDeNacimiento
        cmbSexo.SelectedIndex = Usuario.sexo - 1
        edad.Value = CType(Usuario.edad, Decimal)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            Return
        End If
        Try
            _usuarioModif = New Usuario()
            ' Asignamos valores
            _usuarioModif.nombre = txtNombre.Text
            _usuarioModif.fechaDeNacimiento = txtFechaDeNacimiento.Text
            _usuarioModif.sexo = CType(cmbSexo.SelectedIndex + 1, TipoGenero)
            _usuarioModif.edad = edad.Value

            CType(Me.MdiParent, MDI_Principal).usuariosCRUD.Actualizar(Usuario, UsuarioModif)

            Me.Close()
            MessageBox.Show("Usuario modificado: " & Usuario.ToString())
        Catch ex As Exception
            MessageBox.Show("Error al guardar")
        End Try
    End Sub

    Private Sub texto_TextChanged(sender As Object, e As EventArgs) _
        Handles txtNombre.TextChanged, txtApellidos.TextChanged,
        cmbGenero.SelectedValueChanged,
        numRetribucion.ValueChanged

        btnGuardar.Enabled = txtNombre.Text <> "" _
            And txtApellidos.Text <> "" _
            And cmbSexo.SelectedIndex >= 0 _
            And edad.Value > 0

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtFechaDeNacimiento.Clear()
        txtNombre.Clear()
        cmbSexo.SelectedIndex = -1
        edad.Value = 0
    End Sub

    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated
        Me.MdiParent.Text = "Modificacion usuario"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación usuarios"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Function txtFechaDeNacimiento() As Object
        Throw New NotImplementedException
    End Function

    Private Function cmbSexo() As Object
        Throw New NotImplementedException
    End Function

    Private Function edad() As Object
        Throw New NotImplementedException
    End Function

End Class