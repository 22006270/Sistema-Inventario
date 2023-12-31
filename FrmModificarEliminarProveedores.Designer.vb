<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarEliminarProveedor
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
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbProveedor = New System.Windows.Forms.TextBox()
        Me.TbIdProveedor = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbTelefono
        '
        Me.TbTelefono.Enabled = False
        Me.TbTelefono.Location = New System.Drawing.Point(191, 102)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.ReadOnly = True
        Me.TbTelefono.Size = New System.Drawing.Size(137, 22)
        Me.TbTelefono.TabIndex = 38
        '
        'TbProveedor
        '
        Me.TbProveedor.Enabled = False
        Me.TbProveedor.Location = New System.Drawing.Point(191, 60)
        Me.TbProveedor.Name = "TbProveedor"
        Me.TbProveedor.ReadOnly = True
        Me.TbProveedor.Size = New System.Drawing.Size(137, 22)
        Me.TbProveedor.TabIndex = 35
        '
        'TbIdProveedor
        '
        Me.TbIdProveedor.Enabled = False
        Me.TbIdProveedor.Location = New System.Drawing.Point(191, 20)
        Me.TbIdProveedor.Name = "TbIdProveedor"
        Me.TbIdProveedor.ReadOnly = True
        Me.TbIdProveedor.Size = New System.Drawing.Size(137, 22)
        Me.TbIdProveedor.TabIndex = 41
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(248, 166)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 37)
        Me.BtnModificar.TabIndex = 79
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(56, 166)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(94, 37)
        Me.BtnEliminar.TabIndex = 78
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "IdPorveedor"
        '
        'FrmModificarEliminarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(433, 225)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TbIdProveedor)
        Me.Controls.Add(Me.TbTelefono)
        Me.Controls.Add(Me.TbProveedor)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificarEliminarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar, Eliminar Proveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbProveedor As TextBox
    Friend WithEvents TbIdProveedor As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
