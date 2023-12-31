<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarProveedores
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbProveedor = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbIdProveedor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(142, 171)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(170, 62)
        Me.BtnGuardar.TabIndex = 36
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "IdProveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Telefono"
        '
        'TbProveedor
        '
        Me.TbProveedor.Location = New System.Drawing.Point(150, 72)
        Me.TbProveedor.Name = "TbProveedor"
        Me.TbProveedor.Size = New System.Drawing.Size(164, 22)
        Me.TbProveedor.TabIndex = 41
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(150, 118)
        Me.TbTelefono.MaxLength = 10
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(164, 22)
        Me.TbTelefono.TabIndex = 42
        '
        'TbIdProveedor
        '
        Me.TbIdProveedor.Enabled = False
        Me.TbIdProveedor.Location = New System.Drawing.Point(150, 28)
        Me.TbIdProveedor.Name = "TbIdProveedor"
        Me.TbIdProveedor.ReadOnly = True
        Me.TbIdProveedor.Size = New System.Drawing.Size(164, 22)
        Me.TbIdProveedor.TabIndex = 43
        '
        'FrmAgregarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(429, 262)
        Me.Controls.Add(Me.TbIdProveedor)
        Me.Controls.Add(Me.TbTelefono)
        Me.Controls.Add(Me.TbProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAgregarProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarvProveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbProveedor As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbIdProveedor As TextBox
End Class
