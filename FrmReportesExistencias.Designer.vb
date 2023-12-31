<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesExistencias
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportesExistencias))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.DgExistencia = New System.Windows.Forms.DataGridView()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.BtnRegresar.Location = New System.Drawing.Point(22, 12)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(114, 61)
        Me.BtnRegresar.TabIndex = 27
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnImprimir.BackgroundImage = CType(resources.GetObject("BtnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnImprimir.Location = New System.Drawing.Point(670, 104)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(72, 56)
        Me.BtnImprimir.TabIndex = 34
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'DgExistencia
        '
        Me.DgExistencia.AllowUserToAddRows = False
        Me.DgExistencia.AllowUserToDeleteRows = False
        Me.DgExistencia.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgExistencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgExistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgExistencia.GridColor = System.Drawing.Color.Gainsboro
        Me.DgExistencia.Location = New System.Drawing.Point(21, 104)
        Me.DgExistencia.Name = "DgExistencia"
        Me.DgExistencia.ReadOnly = True
        Me.DgExistencia.RowHeadersWidth = 51
        Me.DgExistencia.RowTemplate.Height = 24
        Me.DgExistencia.Size = New System.Drawing.Size(643, 279)
        Me.DgExistencia.TabIndex = 35
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Reporte General de Existencia De Productos"
        '
        'FrmReportesExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(766, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgExistencia)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnRegresar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportesExistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTES DE EXISTENCIA"
        CType(Me.DgExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents DgExistencia As DataGridView
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label2 As Label
End Class
