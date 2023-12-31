<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.TbIdProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPrecioVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBExistencia = New System.Windows.Forms.Label()
        Me.LBMensaje = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegresar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnRegresar.Location = New System.Drawing.Point(2, -3)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(114, 61)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'TbIdProducto
        '
        Me.TbIdProducto.Location = New System.Drawing.Point(140, 82)
        Me.TbIdProducto.Name = "TbIdProducto"
        Me.TbIdProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbIdProducto.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Fecha"
        '
        'TbFecha
        '
        Me.TbFecha.Enabled = False
        Me.TbFecha.Location = New System.Drawing.Point(140, 240)
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.ReadOnly = True
        Me.TbFecha.Size = New System.Drawing.Size(154, 22)
        Me.TbFecha.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Precio de Venta"
        '
        'TbPrecioVenta
        '
        Me.TbPrecioVenta.Enabled = False
        Me.TbPrecioVenta.Location = New System.Drawing.Point(140, 192)
        Me.TbPrecioVenta.Name = "TbPrecioVenta"
        Me.TbPrecioVenta.ReadOnly = True
        Me.TbPrecioVenta.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecioVenta.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Cantidad Vendida"
        '
        'TbCantidad
        '
        Me.TbCantidad.Location = New System.Drawing.Point(140, 155)
        Me.TbCantidad.Name = "TbCantidad"
        Me.TbCantidad.Size = New System.Drawing.Size(154, 22)
        Me.TbCantidad.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Producto"
        '
        'TbProducto
        '
        Me.TbProducto.Enabled = False
        Me.TbProducto.Location = New System.Drawing.Point(140, 117)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.ReadOnly = True
        Me.TbProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbProducto.TabIndex = 33
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(122, 288)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 60)
        Me.BtnGuardar.TabIndex = 103
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Buscar Id Producto"
        '
        'LBExistencia
        '
        Me.LBExistencia.AutoSize = True
        Me.LBExistencia.Font = New System.Drawing.Font("Century", 12.0!)
        Me.LBExistencia.Location = New System.Drawing.Point(210, 41)
        Me.LBExistencia.Name = "LBExistencia"
        Me.LBExistencia.Size = New System.Drawing.Size(0, 23)
        Me.LBExistencia.TabIndex = 105
        '
        'LBMensaje
        '
        Me.LBMensaje.AutoSize = True
        Me.LBMensaje.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMensaje.Location = New System.Drawing.Point(118, 9)
        Me.LBMensaje.Name = "LBMensaje"
        Me.LBMensaje.Size = New System.Drawing.Size(231, 23)
        Me.LBMensaje.TabIndex = 106
        Me.LBMensaje.Text = "Productos en Existencia"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(308, 72)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(117, 32)
        Me.BtnConsultar.TabIndex = 107
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(308, 143)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(117, 32)
        Me.BtnLimpiar.TabIndex = 108
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(437, 413)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.LBMensaje)
        Me.Controls.Add(Me.LBExistencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbPrecioVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbProducto)
        Me.Controls.Add(Me.TbIdProducto)
        Me.Controls.Add(Me.BtnRegresar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTAS DE VENTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents TbIdProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPrecioVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbProducto As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBExistencia As Label
    Friend WithEvents LBMensaje As Label
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnLimpiar As Button
End Class
