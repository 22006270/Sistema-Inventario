<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculadora
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
        Me.BtnPunto = New System.Windows.Forms.Button()
        Me.BtnIgual = New System.Windows.Forms.Button()
        Me.BtnMas = New System.Windows.Forms.Button()
        Me.BtnMenos = New System.Windows.Forms.Button()
        Me.BtnMultiplicar = New System.Windows.Forms.Button()
        Me.BtnDividir = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Tbresultado = New System.Windows.Forms.TextBox()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPunto
        '
        Me.BtnPunto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPunto.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPunto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnPunto.Location = New System.Drawing.Point(184, 311)
        Me.BtnPunto.Name = "BtnPunto"
        Me.BtnPunto.Size = New System.Drawing.Size(66, 52)
        Me.BtnPunto.TabIndex = 62
        Me.BtnPunto.Text = "."
        Me.BtnPunto.UseVisualStyleBackColor = False
        '
        'BtnIgual
        '
        Me.BtnIgual.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIgual.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIgual.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnIgual.Location = New System.Drawing.Point(269, 226)
        Me.BtnIgual.Name = "BtnIgual"
        Me.BtnIgual.Size = New System.Drawing.Size(66, 111)
        Me.BtnIgual.TabIndex = 61
        Me.BtnIgual.Text = "="
        Me.BtnIgual.UseVisualStyleBackColor = False
        '
        'BtnMas
        '
        Me.BtnMas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMas.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnMas.Location = New System.Drawing.Point(269, 109)
        Me.BtnMas.Name = "BtnMas"
        Me.BtnMas.Size = New System.Drawing.Size(66, 111)
        Me.BtnMas.TabIndex = 60
        Me.BtnMas.Text = "+"
        Me.BtnMas.UseVisualStyleBackColor = False
        '
        'BtnMenos
        '
        Me.BtnMenos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMenos.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnMenos.Location = New System.Drawing.Point(269, 51)
        Me.BtnMenos.Name = "BtnMenos"
        Me.BtnMenos.Size = New System.Drawing.Size(66, 52)
        Me.BtnMenos.TabIndex = 59
        Me.BtnMenos.Text = "-"
        Me.BtnMenos.UseVisualStyleBackColor = False
        '
        'BtnMultiplicar
        '
        Me.BtnMultiplicar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMultiplicar.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiplicar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnMultiplicar.Location = New System.Drawing.Point(184, 51)
        Me.BtnMultiplicar.Name = "BtnMultiplicar"
        Me.BtnMultiplicar.Size = New System.Drawing.Size(66, 52)
        Me.BtnMultiplicar.TabIndex = 58
        Me.BtnMultiplicar.Text = "*"
        Me.BtnMultiplicar.UseVisualStyleBackColor = False
        '
        'BtnDividir
        '
        Me.BtnDividir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDividir.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDividir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnDividir.Location = New System.Drawing.Point(105, 51)
        Me.BtnDividir.Name = "BtnDividir"
        Me.BtnDividir.Size = New System.Drawing.Size(66, 52)
        Me.BtnDividir.TabIndex = 57
        Me.BtnDividir.Text = "/"
        Me.BtnDividir.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn0.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn0.Location = New System.Drawing.Point(21, 311)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(150, 59)
        Me.Btn0.TabIndex = 56
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn9.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn9.Location = New System.Drawing.Point(184, 109)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(66, 52)
        Me.Btn9.TabIndex = 55
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn8.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn8.Location = New System.Drawing.Point(105, 109)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(66, 52)
        Me.Btn8.TabIndex = 54
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn7.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn7.Location = New System.Drawing.Point(21, 109)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(66, 52)
        Me.Btn7.TabIndex = 53
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn6.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn6.Location = New System.Drawing.Point(184, 178)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(66, 52)
        Me.Btn6.TabIndex = 52
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn5.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn5.Location = New System.Drawing.Point(105, 178)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(66, 52)
        Me.Btn5.TabIndex = 51
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn4.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn4.Location = New System.Drawing.Point(21, 178)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(66, 52)
        Me.Btn4.TabIndex = 50
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn3.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn3.Location = New System.Drawing.Point(184, 246)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(66, 52)
        Me.Btn3.TabIndex = 49
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn2.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn2.Location = New System.Drawing.Point(105, 246)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(66, 52)
        Me.Btn2.TabIndex = 48
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn1.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Btn1.Location = New System.Drawing.Point(21, 246)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(66, 52)
        Me.Btn1.TabIndex = 47
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Tbresultado
        '
        Me.Tbresultado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Tbresultado.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbresultado.ForeColor = System.Drawing.Color.Black
        Me.Tbresultado.Location = New System.Drawing.Point(21, 12)
        Me.Tbresultado.Name = "Tbresultado"
        Me.Tbresultado.Size = New System.Drawing.Size(314, 25)
        Me.Tbresultado.TabIndex = 64
        '
        'BtnC
        '
        Me.BtnC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnC.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnC.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BtnC.Location = New System.Drawing.Point(21, 51)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(66, 52)
        Me.BtnC.TabIndex = 65
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = False
        '
        'FrmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(364, 382)
        Me.Controls.Add(Me.BtnC)
        Me.Controls.Add(Me.Tbresultado)
        Me.Controls.Add(Me.BtnPunto)
        Me.Controls.Add(Me.BtnIgual)
        Me.Controls.Add(Me.BtnMas)
        Me.Controls.Add(Me.BtnMenos)
        Me.Controls.Add(Me.BtnMultiplicar)
        Me.Controls.Add(Me.BtnDividir)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPunto As Button
    Friend WithEvents BtnMas As Button
    Friend WithEvents BtnMenos As Button
    Friend WithEvents BtnMultiplicar As Button
    Friend WithEvents BtnDividir As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents BtnIgual As Button
    Friend WithEvents Tbresultado As TextBox
    Friend WithEvents BtnC As Button
End Class
