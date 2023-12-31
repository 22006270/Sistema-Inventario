<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificProducto
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbExistencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TbFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPrecioCompra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "IdProducto"
        '
        'TbIdProducto
        '
        Me.TbIdProducto.Enabled = False
        Me.TbIdProducto.Location = New System.Drawing.Point(135, 22)
        Me.TbIdProducto.Name = "TbIdProducto"
        Me.TbIdProducto.ReadOnly = True
        Me.TbIdProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbIdProducto.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Precio Venta "
        '
        'TbPrecio
        '
        Me.TbPrecio.Location = New System.Drawing.Point(135, 136)
        Me.TbPrecio.MaxLength = 7
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecio.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Existencia"
        '
        'TbExistencia
        '
        Me.TbExistencia.Enabled = False
        Me.TbExistencia.Location = New System.Drawing.Point(135, 99)
        Me.TbExistencia.Name = "TbExistencia"
        Me.TbExistencia.ReadOnly = True
        Me.TbExistencia.Size = New System.Drawing.Size(154, 22)
        Me.TbExistencia.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Producto"
        '
        'TbProducto
        '
        Me.TbProducto.Location = New System.Drawing.Point(135, 61)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbProducto.TabIndex = 89
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(84, 277)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(156, 60)
        Me.BtnModificar.TabIndex = 101
        Me.BtnModificar.Text = "Guardar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'TbFecha
        '
        Me.TbFecha.Enabled = False
        Me.TbFecha.Location = New System.Drawing.Point(135, 219)
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.ReadOnly = True
        Me.TbFecha.Size = New System.Drawing.Size(105, 22)
        Me.TbFecha.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Precio Compra "
        '
        'TbPrecioCompra
        '
        Me.TbPrecioCompra.Location = New System.Drawing.Point(135, 179)
        Me.TbPrecioCompra.MaxLength = 7
        Me.TbPrecioCompra.Name = "TbPrecioCompra"
        Me.TbPrecioCompra.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecioCompra.TabIndex = 104
        '
        'FrmModificProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(361, 359)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbPrecioCompra)
        Me.Controls.Add(Me.TbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbIdProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbPrecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbExistencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbProducto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbExistencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbProducto As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents TbFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPrecioCompra As TextBox
End Class
