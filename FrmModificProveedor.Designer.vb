<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificProveedor
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
        Me.TbIdProveedor = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbProveedor = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbIdProveedor
        '
        Me.TbIdProveedor.Enabled = False
        Me.TbIdProveedor.Location = New System.Drawing.Point(133, 33)
        Me.TbIdProveedor.Name = "TbIdProveedor"
        Me.TbIdProveedor.ReadOnly = True
        Me.TbIdProveedor.Size = New System.Drawing.Size(137, 22)
        Me.TbIdProveedor.TabIndex = 50
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(133, 115)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(137, 22)
        Me.TbTelefono.TabIndex = 47
        '
        'TbProveedor
        '
        Me.TbProveedor.Location = New System.Drawing.Point(133, 73)
        Me.TbProveedor.Name = "TbProveedor"
        Me.TbProveedor.Size = New System.Drawing.Size(137, 22)
        Me.TbProveedor.TabIndex = 44
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(94, 170)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(102, 37)
        Me.BtnModificar.TabIndex = 80
        Me.BtnModificar.Text = "Guardar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "IdPorveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Telefono"
        '
        'FrmModificProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(305, 262)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TbIdProveedor)
        Me.Controls.Add(Me.TbTelefono)
        Me.Controls.Add(Me.TbProveedor)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbIdProveedor As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbProveedor As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
