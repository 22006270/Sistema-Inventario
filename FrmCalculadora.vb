Public Class FrmCalculadora
    Dim operacion As String
    Dim Resultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim operador As Boolean
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "9"
    End Sub


    Private Sub BtnMenos_Click(sender As Object, e As EventArgs) Handles BtnMenos.Click
        EvaluarOperacion()
        operacion = "-"
    End Sub

    Private Sub BtnMas_Click(sender As Object, e As EventArgs) Handles BtnMas.Click
        EvaluarOperacion()
        operacion = "+"
    End Sub



    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Evaluarestriccionparaconcatenar()
        Tbresultado.Text &= "0"
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        Evaluarestriccionparaconcatenar()
        If InStr(Tbresultado.Text, ".", CompareMethod.Text) = 0 Then
            Tbresultado.Text &= "."
        End If
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        EvaluarOperacion()
        operacion = ""
    End Sub

    Public Sub EvaluarOperacion()
        operador = True
        Valor2 = Val(Tbresultado.Text)
        If Resultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    Resultado = Resultado + Valor2
                Case "-"
                    Resultado -= Valor2
                Case "*"
                    Resultado *= Valor2
                Case "/"
                    Resultado /= Valor2
            End Select
            Tbresultado.Text = Resultado
        Else
            Resultado = Valor2
        End If
    End Sub

    Private Sub BtnMultiplicar_Click(sender As Object, e As EventArgs) Handles BtnMultiplicar.Click
        EvaluarOperacion()
        operacion = "*"
    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles BtnDividir.Click
        EvaluarOperacion()
        operacion = "/"
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        Tbresultado.Text = "0"
        Valor2 = Nothing
        Resultado = Nothing
    End Sub

    Public Sub Evaluarestriccionparaconcatenar()
        If operador = True Then
            Tbresultado.Text = ""
            operador = False
        ElseIf Tbresultado.Text = "0" Then
            Tbresultado.Text = ""
        End If
    End Sub

    Private Sub FrmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TbResultado_TextChanged(sender As Object, e As EventArgs) Handles Tbresultado.TextChanged

    End Sub
End Class