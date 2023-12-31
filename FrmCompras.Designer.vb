<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCompras))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbIdProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPrecioCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbFecha = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBMensaje = New System.Windows.Forms.Label()
        Me.LBExistencia = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(-1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TbIdProducto
        '
        Me.TbIdProducto.Location = New System.Drawing.Point(153, 72)
        Me.TbIdProducto.Name = "TbIdProducto"
        Me.TbIdProducto.Size = New System.Drawing.Size(153, 22)
        Me.TbIdProducto.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Precio de Compra"
        '
        'TbPrecioCompra
        '
        Me.TbPrecioCompra.Enabled = False
        Me.TbPrecioCompra.Location = New System.Drawing.Point(153, 187)
        Me.TbPrecioCompra.Name = "TbPrecioCompra"
        Me.TbPrecioCompra.ReadOnly = True
        Me.TbPrecioCompra.Size = New System.Drawing.Size(154, 22)
        Me.TbPrecioCompra.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cantidad"
        '
        'TbCantidad
        '
        Me.TbCantidad.Location = New System.Drawing.Point(153, 145)
        Me.TbCantidad.Name = "TbCantidad"
        Me.TbCantidad.Size = New System.Drawing.Size(154, 22)
        Me.TbCantidad.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Producto"
        '
        'TbProducto
        '
        Me.TbProducto.Enabled = False
        Me.TbProducto.Location = New System.Drawing.Point(153, 107)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.ReadOnly = True
        Me.TbProducto.Size = New System.Drawing.Size(154, 22)
        Me.TbProducto.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Fecha"
        '
        'TbFecha
        '
        Me.TbFecha.Enabled = False
        Me.TbFecha.Location = New System.Drawing.Point(153, 230)
        Me.TbFecha.Name = "TbFecha"
        Me.TbFecha.Size = New System.Drawing.Size(154, 22)
        Me.TbFecha.TabIndex = 29
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(153, 275)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 60)
        Me.BtnGuardar.TabIndex = 102
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Buscar Id Producto"
        '
        'LBMensaje
        '
        Me.LBMensaje.AutoSize = True
        Me.LBMensaje.Location = New System.Drawing.Point(134, 2)
        Me.LBMensaje.Name = "LBMensaje"
        Me.LBMensaje.Size = New System.Drawing.Size(159, 17)
        Me.LBMensaje.TabIndex = 108
        Me.LBMensaje.Text = "Productos en Existencia"
        '
        'LBExistencia
        '
        Me.LBExistencia.AutoSize = True
        Me.LBExistencia.Location = New System.Drawing.Point(207, 34)
        Me.LBExistencia.Name = "LBExistencia"
        Me.LBExistencia.Size = New System.Drawing.Size(0, 17)
        Me.LBExistencia.TabIndex = 107
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(324, 138)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(117, 32)
        Me.BtnLimpiar.TabIndex = 110
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(324, 67)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(117, 32)
        Me.BtnConsultar.TabIndex = 109
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(453, 391)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.LBMensaje)
        Me.Controls.Add(Me.LBExistencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbPrecioCompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbProducto)
        Me.Controls.Add(Me.TbIdProducto)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPRAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TbIdProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbPrecioCompra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbFecha As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBMensaje As Label
    Friend WithEvents LBExistencia As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnConsultar As Button
End Class
