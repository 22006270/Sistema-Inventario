<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarProducto
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TbFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPrecioCompra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "IdProducto"
        '
        'TbIdProducto
        '
        Me.TbIdProducto.Enabled = False
        Me.TbIdProducto.Location = New System.Drawing.Point(133, 17)
        Me.TbIdProducto.Name = "TbIdProducto"
        Me.TbIdProducto.ReadOnly = True
        Me.TbIdProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbIdProducto.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Precio Venta"
        '
        'TbPrecio
        '
        Me.TbPrecio.Location = New System.Drawing.Point(133, 139)
        Me.TbPrecio.MaxLength = 5
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecio.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Existencia"
        '
        'TbExistencia
        '
        Me.TbExistencia.Location = New System.Drawing.Point(133, 94)
        Me.TbExistencia.Name = "TbExistencia"
        Me.TbExistencia.Size = New System.Drawing.Size(154, 22)
        Me.TbExistencia.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Producto"
        '
        'TbProducto
        '
        Me.TbProducto.Location = New System.Drawing.Point(133, 58)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbProducto.TabIndex = 77
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(80, 267)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 60)
        Me.BtnGuardar.TabIndex = 89
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TbFecha
        '
        Me.TbFecha.Enabled = False
        Me.TbFecha.Location = New System.Drawing.Point(135, 215)
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.ReadOnly = True
        Me.TbFecha.Size = New System.Drawing.Size(101, 22)
        Me.TbFecha.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Precio Compra"
        '
        'TbPrecioCompra
        '
        Me.TbPrecioCompra.Location = New System.Drawing.Point(133, 177)
        Me.TbPrecioCompra.MaxLength = 5
        Me.TbPrecioCompra.Name = "TbPrecioCompra"
        Me.TbPrecioCompra.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecioCompra.TabIndex = 94
        '
        'FrmAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(335, 364)
        Me.Controls.Add(Me.TbPrecioCompra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbFecha)
        Me.Controls.Add(Me.BtnGuardar)
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
        Me.Name = "FrmAgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
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
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TbFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPrecioCompra As TextBox
End Class
