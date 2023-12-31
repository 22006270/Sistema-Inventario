<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultasVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultasVentas))
        Me.DgVenta = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.CBFecha = New System.Windows.Forms.ComboBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DgVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgVenta
        '
        Me.DgVenta.AllowUserToAddRows = False
        Me.DgVenta.AllowUserToDeleteRows = False
        Me.DgVenta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DgVenta.GridColor = System.Drawing.Color.Gainsboro
        Me.DgVenta.Location = New System.Drawing.Point(37, 82)
        Me.DgVenta.Name = "DgVenta"
        Me.DgVenta.ReadOnly = True
        Me.DgVenta.RowHeadersWidth = 51
        Me.DgVenta.RowTemplate.Height = 24
        Me.DgVenta.Size = New System.Drawing.Size(478, 279)
        Me.DgVenta.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(132, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(45, 22)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "Mes"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.White
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.Black
        Me.BtnConsultar.Location = New System.Drawing.Point(279, 14)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(94, 35)
        Me.BtnConsultar.TabIndex = 16
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnRegresar.Location = New System.Drawing.Point(12, -1)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(114, 61)
        Me.BtnRegresar.TabIndex = 21
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'CBFecha
        '
        Me.CBFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFecha.FormattingEnabled = True
        Me.CBFecha.Location = New System.Drawing.Point(183, 25)
        Me.CBFecha.MaxLength = 2
        Me.CBFecha.Name = "CBFecha"
        Me.CBFecha.Size = New System.Drawing.Size(90, 24)
        Me.CBFecha.TabIndex = 23
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiar.Location = New System.Drawing.Point(535, 305)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(72, 56)
        Me.BtnLimpiar.TabIndex = 26
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'FrmConsultasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(619, 375)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.CBFecha)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.DgVenta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultasVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTAS DE VENTAS"
        CType(Me.DgVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgVenta As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents CBFecha As ComboBox
    Friend WithEvents BtnLimpiar As Button
End Class
