Imports MySql.Data.MySqlClient
Public Class FrmAgregarProducto
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 
    Private Sub TbIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProducto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProducto.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con letras

    End Sub

    Private Sub TbExistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbExistencia.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros

    End Sub

    Private Sub TbPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPrecio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TbPrecio.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TbIdProducto_TextChanged(sender As Object, e As EventArgs) Handles TbIdProducto.TextChanged
    End Sub

    Private Sub FrmAgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbFecha.Text = Today
        Try
            conection.ConnectionString = "Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos;"
            conection.Open()
            'MsgBox("Inserta el nuevo Producto")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TbProducto.Text = "" Or TbExistencia.Text = "" Or TbPrecio.Text = "" Or TbPrecioCompra.Text = "" Then
            MsgBox("Faltan Datos por agregar")

        Else



            comandos = New MySqlCommand("INSERT INTO productos(IdProducto, Producto, Existencia, Precio, PrecioCompra, Fecha)" & Chr(13) & "VALUES (@IdProducto, @Producto, @Existencia, @Precio, @PrecioCompra, @Fecha)", conection)
            Dim Precio = Convert.ToDecimal(TbPrecio.Text)
            Dim PrecioCompra = Convert.ToDecimal(TbPrecioCompra.Text)

            If Precio > PrecioCompra Then

                comandos.Parameters.AddWithValue("@IdProducto", TbIdProducto.Text)
                comandos.Parameters.AddWithValue("@Producto", TbProducto.Text)
                comandos.Parameters.AddWithValue("@Existencia", TbExistencia.Text)
                comandos.Parameters.AddWithValue("@Precio", TbPrecio.Text)
                comandos.Parameters.AddWithValue("@PrecioCompra", TbPrecioCompra.Text)
                comandos.Parameters.AddWithValue("@Fecha", (TbFecha.Text))
                comandos.ExecuteNonQuery()

                MsgBox("Producto Guardado Exitosamente!")
                Me.Dispose()

            Else

                If Precio < PrecioCompra Then
                    MsgBox("El precio de compra no puede ser mayor al precio de venta!")
                    TbPrecio.Text = ""
                    TbPrecioCompra.Text = ""
                    TbPrecio.Focus()
                Else

                    If Precio = PrecioCompra Then
                        If TbPrecio.CanFocus Then
                            MsgBox("El precio de Venta tiene que ser mayor al precio de Compra!")
                            TbPrecio.Focus()





                        End If
                    End If
                End If
            End If

        End If



    End Sub



    Private Sub TbPrecioCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPrecioCompra.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not TbPrecioCompra.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


End Class