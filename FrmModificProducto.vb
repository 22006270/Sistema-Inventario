Imports MySql.Data.MySqlClient
Public Class FrmModificProducto
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 

    Private Sub FrmModificProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TbFecha.Text = Format$(Date.Now, ("dd/MM/yyyy"))
        Try
            conection.ConnectionString = "Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos"
            conection.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TbIdProducto.Text = ""
    End Sub
    Private Sub TbIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If TbProducto.Text = "" Or TbExistencia.Text = "" Or TbPrecio.Text = "" Or TbPrecioCompra.Text = "" Then
            MsgBox("Faltan Datos por agregar")

        Else


            comandos = New MySqlCommand("UPDATE productos SET Producto = @Producto, Existencia = @Existencia, Precio = @Precio, PrecioCompra = @PrecioCompra
        WHERE IdProducto = '" & TbIdProducto.Text & "'", conection)
            Dim Precio = Convert.ToDecimal(TbPrecio.Text)
            Dim PrecioCompra = Convert.ToDecimal(TbPrecioCompra.Text)


            If Precio > PrecioCompra Then

                comandos.Parameters.AddWithValue("@Producto", TbProducto.Text)
                comandos.Parameters.AddWithValue("@Existencia", TbExistencia.Text)
                comandos.Parameters.AddWithValue("@Precio", TbPrecio.Text)
                comandos.Parameters.AddWithValue("@PrecioCompra", TbPrecioCompra.Text)
                comandos.ExecuteNonQuery()
                MsgBox("Producto Modificado!")
                Me.Dispose()
            Else

                If Precio < PrecioCompra Then
                    MsgBox("El precio de compra no puede ser mayor al precio de venta!")
                    TbPrecioCompra.Text = ""
                    TbPrecio.Focus()

                Else
                    If Precio = PrecioCompra Then
                        If TbPrecio.CanFocus Then
                            MsgBox("El precio de Venta tiene que ser mayor al precio de Compra!")

                            TbPrecioCompra.Text = ""
                            Me.TbPrecio.Focus()

                        Else

                        End If
                    End If
                End If
            End If
        End If
        FrmModificarEliminarProduct.Dispose()
    End Sub

    Private Sub TbFecha_TextChanged(sender As Object, e As EventArgs) Handles TbFecha.TextChanged

    End Sub

    Private Sub TbProducto_TextChanged(sender As Object, e As EventArgs) Handles TbProducto.TextChanged

    End Sub

    Private Sub TbExistencia_TextChanged(sender As Object, e As EventArgs) Handles TbExistencia.TextChanged

    End Sub
End Class