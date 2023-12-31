<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportesventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportesventas))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.CBFecha = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.DgVenta = New System.Windows.Forms.DataGridView()
        CType(Me.DgVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnRegresar.Location = New System.Drawing.Point(5, 6)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(114, 61)
        Me.BtnRegresar.TabIndex = 28
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnLimpiar.Location = New System.Drawing.Point(562, 207)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(72, 56)
        Me.BtnLimpiar.TabIndex = 27
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnImprimir.BackgroundImage = CType(resources.GetObject("BtnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnImprimir.Location = New System.Drawing.Point(562, 86)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(72, 56)
        Me.BtnImprimir.TabIndex = 29
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'CBFecha
        '
        Me.CBFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFecha.FormattingEnabled = True
        Me.CBFecha.Location = New System.Drawing.Point(204, 17)
        Me.CBFecha.MaxLength = 2
        Me.CBFecha.Name = "CBFecha"
        Me.CBFecha.Size = New System.Drawing.Size(90, 24)
        Me.CBFecha.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(153, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(45, 22)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.Text = "Mes"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.White
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ForeColor = System.Drawing.Color.Black
        Me.BtnConsultar.Location = New System.Drawing.Point(300, 6)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(94, 35)
        Me.BtnConsultar.TabIndex = 30
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'DgVenta
        '
        Me.DgVenta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVenta.GridColor = System.Drawing.Color.Gainsboro
        Me.DgVenta.Location = New System.Drawing.Point(42, 118)
        Me.DgVenta.Name = "DgVenta"
        Me.DgVenta.RowHeadersWidth = 51
        Me.DgVenta.RowTemplate.Height = 24
        Me.DgVenta.Size = New System.Drawing.Size(495, 294)
        Me.DgVenta.TabIndex = 33
        '
        'FrmReportesventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(649, 455)
        Me.Controls.Add(Me.DgVenta)
        Me.Controls.Add(Me.CBFecha)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportesventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTES DE VENTAS"
        CType(Me.DgVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents CBFecha As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents DgVenta As DataGridView
End Class
