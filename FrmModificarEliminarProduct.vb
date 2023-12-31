Imports MySql.Data.MySqlClient
Public Class FrmModificarEliminarProduct
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 

    Private Sub FrmModificarEliminarProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub TbExistencia_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub
    Private Sub TbPrecioCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPrecioCompra.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbProducto_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con letras
    End Sub



    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim eliminar As String
        Dim si As Byte
        si = MsgBox("Desea Eliminar el Producto?", vbYesNo, "Eliminar")

        If si = 6 Then
            eliminar = "DELETE FROM Productos WHERE IdProducto = '" & TbIdProducto.Text & "'"
            comandos = New MySqlCommand(eliminar, conection)
            comandos.ExecuteNonQuery()
            MsgBox("Producto Eliminado!")
            Me.Dispose()

        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmModificProducto.Show()
        FrmModificProducto.TbIdProducto.Text = TbIdProducto.Text
        FrmModificProducto.TbProducto.Text = TbProducto.Text
        FrmModificProducto.TbExistencia.Text = TbExistencia.Text
        FrmModificProducto.TbPrecio.Text = TbPrecio.Text
        FrmModificProducto.TbPrecioCompra.Text = TbPrecioCompra.Text
        FrmModificProducto.TbFecha.Text = TbFecha.Text

    End Sub


    Private Sub TbExistencia_TextChanged(sender As Object, e As EventArgs) Handles TbExistencia.TextChanged

        If TbExistencia.Text <= 2 Then
            MsgBox("La Existencia de los productos se esta agotando")
        End If




    End Sub
End Class