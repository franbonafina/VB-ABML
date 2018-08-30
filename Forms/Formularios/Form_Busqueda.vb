Imports Modelo.Modelo

Public Class Form_Busqueda
    Public listaUsuarios As List(Of Usuario)

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        BuscarUsuario()
    End Sub
    Private Sub cmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNombre.SelectedIndexChanged
        BuscarUsuario()
    End Sub
    Private Sub cmbNombre_TextChanged(sender As Object, e As EventArgs) _
        Handles cmbNombre.TextChanged
        BuscarUsuario()
    End Sub
    Private Sub BuscarUsuario()
        lstListaUsuario.Items.Clear()
        listaUsuarios = CType(Me.MdiParent, MDI_Principal).usuariosCRUD.BuscarUsuarios(cmbNombre.Text)

        For Each usuario As Usuario In listaUsuarios
            lstListaUsuario.Items.Add(usuario.nombre)
        Next
        txtCantidadEncontrados.Text = lstListaUsuario.Items.Count.ToString()
        txtCantidadTotal.Text = CType(Me.MdiParent, MDI_Principal).usuariosCRUD.Cantidad
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim mdiPrincipal As MDI_Principal
        mdiPrincipal = CType(Me.MdiParent, MDI_Principal)
        mdiPrincipal.AbrirAlta()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Dim listaElminar As New List(Of Usuario)
        For i = 0 To lstListaUsuario.SelectedIndices.Count - 1
            Dim indexUsuario = lstListaUsuario.SelectedIndices(i)
            Dim usuario As Usuario
            usuario = listaUsuarios(indexUsuario)
            listaElminar.Add(usuario)

        Next
        While lstListaUsuario.SelectedItems.Count > 0
            lstListaUsuario.Items.Remove(lstListaUsuario.SelectedItems(0))
        End While
        CType(Me.MdiParent, MDI_Principal).usuariosCRUD.Eliminar(listaElminar)
    End Sub
    Private Sub btnModificacion_Click(sender As Object, e As EventArgs) Handles btnModificacion.Click
        Dim listaModificar As New List(Of Usuario)
        For i = 0 To lstListaUsuario.SelectedIndices.Count - 1
            Dim indexUsuario = lstListaUsuario.SelectedIndices(i)
            Dim frmModificar = New Form_Modificacion()
            frmModificar.MdiParent = Me.MdiParent
            frmModificar.Usuario = listaUsuarios(indexUsuario)
            frmModificar.Show()
        Next
    End Sub

    Private Sub txtCantidadTotal_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadTotal.TextChanged

    End Sub

    Private Function lstListaUsuarios() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lstListaUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListaUsuario.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class