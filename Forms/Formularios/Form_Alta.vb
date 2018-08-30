Imports Modelo.Modelo


Public Class Form_Alta
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' TODO: Impedir duplicados
        ' TODO: Hacer las validaciones
        ' TOPO: Formulario por encima TopMost
        ' TODO: Métodos         CenterToScreen()        y        CenterToParent()
        ' TODO: Propiedades       ControlBox aximizeBox MinimizeBox, HelpButton, Propiedad         FormBorderStyle        .

        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            Return
        End If
        Try
            Dim nuevoUsuario As Usuario = New Usuario()

            ' Asignamos valores
            nuevoUsuario.nombre = txtNombre.Text
            nuevoUsuario.fechaDeNacimiento = txtFechaDeNacimiento.Text
            nuevoUsuario.sexo = CType(cmbSexo.SelectedIndex + 1, TipoGenero)
            nuevoUsuario.edad = edad.Value

            CType(Me.MdiParent, MDI_Principal).usuariosCRUD.Crear(nuevoUsuario)

            Me.Close()
            MessageBox.Show("Usuario creado: " & nuevoUsuario.ToString())
        Catch ex As Exception
            MessageBox.Show("Error al guardar " & ex.Message)
        End Try
    End Sub
    Private Sub texto_TextChanged(sender As Object, e As EventArgs) _
        Handles txtNombre.TextChanged, txtFechaDeNacimiento.TextChanged,
        cmbSexo.SelectedValueChanged,
        edad.ValueChanged

        btnGuardar.Enabled = txtNombre.Text <> "" _
            And txtFechaDeNacimiento.Text <> "" _
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
        Me.MdiParent.Text = "Alta usuario"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación usuarios"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class