<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEliminarProduct
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbExistencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdProducto = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbFecha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPrecioCompra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(68, 311)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(117, 37)
        Me.BtnEliminar.TabIndex = 52
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Precio De Venta"
        '
        'TbPrecio
        '
        Me.TbPrecio.Enabled = False
        Me.TbPrecio.Location = New System.Drawing.Point(184, 141)
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.ReadOnly = True
        Me.TbPrecio.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecio.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Existencia"
        '
        'TbExistencia
        '
        Me.TbExistencia.Enabled = False
        Me.TbExistencia.Location = New System.Drawing.Point(185, 102)
        Me.TbExistencia.Name = "TbExistencia"
        Me.TbExistencia.ReadOnly = True
        Me.TbExistencia.Size = New System.Drawing.Size(154, 22)
        Me.TbExistencia.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Producto"
        '
        'TbProducto
        '
        Me.TbProducto.Enabled = False
        Me.TbProducto.Location = New System.Drawing.Point(185, 64)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.ReadOnly = True
        Me.TbProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbProducto.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "IdProducto"
        '
        'TbIdProducto
        '
        Me.TbIdProducto.Enabled = False
        Me.TbIdProducto.Location = New System.Drawing.Point(185, 25)
        Me.TbIdProducto.Name = "TbIdProducto"
        Me.TbIdProducto.ReadOnly = True
        Me.TbIdProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbIdProducto.TabIndex = 75
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(292, 311)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(117, 37)
        Me.BtnModificar.TabIndex = 77
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Fecha"
        '
        'TbFecha
        '
        Me.TbFecha.Enabled = False
        Me.TbFecha.Location = New System.Drawing.Point(185, 223)
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.ReadOnly = True
        Me.TbFecha.Size = New System.Drawing.Size(153, 22)
        Me.TbFecha.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 17)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Precio De Compra"
        '
        'TbPrecioCompra
        '
        Me.TbPrecioCompra.Enabled = False
        Me.TbPrecioCompra.Location = New System.Drawing.Point(185, 179)
        Me.TbPrecioCompra.Name = "TbPrecioCompra"
        Me.TbPrecioCompra.ReadOnly = True
        Me.TbPrecioCompra.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecioCompra.TabIndex = 69
        '
        'FrmModificarEliminarProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(447, 430)
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
        Me.Controls.Add(Me.BtnEliminar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificarEliminarProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar, Eliminar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbExistencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdProducto As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbFecha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPrecioCompra As TextBox
End Class
