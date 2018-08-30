<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Busqueda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstListaUsuario = New System.Windows.Forms.ListBox()
        Me.cmbNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnModificacion = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidadTotal = New System.Windows.Forms.TextBox()
        Me.txtCantidadEncontrados = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstListaUsuario
        '
        Me.lstListaUsuario.FormattingEnabled = True
        Me.lstListaUsuario.ItemHeight = 20
        Me.lstListaUsuario.Location = New System.Drawing.Point(43, 204)
        Me.lstListaUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstListaUsuario.Name = "lstListaUsuario"
        Me.lstListaUsuario.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstListaUsuario.Size = New System.Drawing.Size(357, 184)
        Me.lstListaUsuario.TabIndex = 0
        '
        'cmbNombre
        '
        Me.cmbNombre.FormattingEnabled = True
        Me.cmbNombre.Location = New System.Drawing.Point(175, 48)
        Me.cmbNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbNombre.Name = "cmbNombre"
        Me.cmbNombre.Size = New System.Drawing.Size(225, 28)
        Me.cmbNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introduzca el usuario a buscar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuarios encontrados:"
        '
        'btnBaja
        '
        Me.btnBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaja.ForeColor = System.Drawing.Color.Red
        Me.btnBaja.Location = New System.Drawing.Point(259, 396)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(70, 39)
        Me.btnBaja.TabIndex = 7
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(43, 396)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(93, 39)
        Me.btnAlta.TabIndex = 8
        Me.btnAlta.Text = "Alta..."
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnModificacion
        '
        Me.btnModificacion.Location = New System.Drawing.Point(142, 397)
        Me.btnModificacion.Name = "btnModificacion"
        Me.btnModificacion.Size = New System.Drawing.Size(100, 37)
        Me.btnModificacion.TabIndex = 9
        Me.btnModificacion.Text = "Modificar..."
        Me.btnModificacion.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(335, 397)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(65, 38)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Usuarios totales:"
        '
        'txtCantidadTotal
        '
        Me.txtCantidadTotal.Location = New System.Drawing.Point(296, 129)
        Me.txtCantidadTotal.Name = "txtCantidadTotal"
        Me.txtCantidadTotal.ReadOnly = True
        Me.txtCantidadTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidadTotal.TabIndex = 12
        '
        'txtCantidadEncontrados
        '
        Me.txtCantidadEncontrados.Location = New System.Drawing.Point(296, 160)
        Me.txtCantidadEncontrados.Name = "txtCantidadEncontrados"
        Me.txtCantidadEncontrados.ReadOnly = True
        Me.txtCantidadEncontrados.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidadEncontrados.TabIndex = 13
        '
        'Form_Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 445)
        Me.Controls.Add(Me.txtCantidadEncontrados)
        Me.Controls.Add(Me.txtCantidadTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnModificacion)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbNombre)
        Me.Controls.Add(Me.lstListaUsuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Busqueda"
        Me.Text = "Listar usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstListaUsuario As ListBox
    Friend WithEvents cmbNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnModificacion As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidadTotal As TextBox
    Friend WithEvents txtCantidadEncontrados As TextBox
End Class
