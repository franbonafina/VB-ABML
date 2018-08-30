<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Modificacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numRetribucion = New System.Windows.Forms.NumericUpDown()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.numRetribucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Location = New System.Drawing.Point(44, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 40)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Edad"
        '
        'numRetribucion
        '
        Me.numRetribucion.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numRetribucion.Location = New System.Drawing.Point(254, 292)
        Me.numRetribucion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numRetribucion.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numRetribucion.Name = "numRetribucion"
        Me.numRetribucion.Size = New System.Drawing.Size(372, 26)
        Me.numRetribucion.TabIndex = 22
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(254, 357)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(170, 55)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(450, 357)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(176, 55)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cmbGenero
        '
        Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"Varón", "Mujer", "Hermafrodita"})
        Me.cmbGenero.Location = New System.Drawing.Point(254, 205)
        Me.cmbGenero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(370, 28)
        Me.cmbGenero.TabIndex = 18
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(254, 121)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(370, 26)
        Me.txtApellidos.TabIndex = 17
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(254, 45)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(370, 26)
        Me.txtNombre.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(44, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 46)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(34, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 60)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fecha de Nacimiento (DD/MM/YYYY) "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(44, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 46)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'Form_Modificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 428)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numRetribucion)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Modificacion"
        Me.Text = "Form_Modificacion"
        CType(Me.numRetribucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents numRetribucion As NumericUpDown
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
