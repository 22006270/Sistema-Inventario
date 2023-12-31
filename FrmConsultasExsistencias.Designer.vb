<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasExsistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultasExsistencias))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DgExistencia = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnRegresar.TabIndex = 6
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'DgExistencia
        '
        Me.DgExistencia.AllowUserToAddRows = False
        Me.DgExistencia.AllowUserToDeleteRows = False
        Me.DgExistencia.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgExistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgExistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgExistencia.GridColor = System.Drawing.Color.Gainsboro
        Me.DgExistencia.Location = New System.Drawing.Point(12, 91)
        Me.DgExistencia.Name = "DgExistencia"
        Me.DgExistencia.ReadOnly = True
        Me.DgExistencia.RowHeadersWidth = 51
        Me.DgExistencia.RowTemplate.Height = 24
        Me.DgExistencia.Size = New System.Drawing.Size(643, 279)
        Me.DgExistencia.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Consulta General de La Existencia De Productos"
        '
        'FrmConsultasExsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(694, 384)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgExistencia)
        Me.Controls.Add(Me.BtnRegresar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultasExsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTAS DE EXISTENCIAS"
        CType(Me.DgExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents DgExistencia As DataGridView
    Friend WithEvents Label1 As Label
End Class
