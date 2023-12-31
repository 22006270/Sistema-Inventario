Imports MySql.Data.MySqlClient

Public Class FrmCompras
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TbFecha.Text = Today
        Try
            conection.ConnectionString = "Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos"
            conection.Open()
            'MsgBox("Inserta el nuevo Proveedor")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TbIdProducto.Text = ""
        TbProducto.Text = ""
        TbCantidad.Text = ""
        TbPrecioCompra.Text = ""
        TbFecha.Text = ""
        LBExistencia.Text = ""
        TbFecha.Text = ""
        Me.Hide()
        FrmMenu.Show()
    End Sub

    Private Sub TbCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProducto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TbIdProducto_TextChanged(sender As Object, e As EventArgs) Handles TbIdProducto.TextChanged





    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim Consulta As String = "Select * from compras where IdProducto='" & TbIdProducto.Text & "'"
        Dim comando As New MySqlCommand(Consulta, conection)
        ' Dim comandos As New MySqlCommand("Select * from compras where IdProducto='" & TbIdProducto.Text & "'")


        If TbIdProducto.Text = "" Or TbCantidad.Text = "" Then
            MsgBox("Faltan datos por agregar")

        Else

            comandos = New MySqlCommand("INSERT INTO compras(IdProducto,Cantidad, Fecha)" & Chr(13) & "VALUES (@IdProducto,@Cantidad, @Fecha)", conection)
            comandos.Parameters.AddWithValue("@IdProducto", TbIdProducto.Text).ToString()
            comandos.Parameters.AddWithValue("@Cantidad", TbCantidad.Text).ToString()
            comandos.Parameters.AddWithValue("@Fecha", TbFecha.Text).ToString()
            comandos.ExecuteNonQuery().ToString()

            MsgBox("Compra Realizada Exitosamente!")

            comandos = New MySqlCommand("UPDATE productos JOIN compras on productos.IdProducto = compras.IdProducto set productos.Existencia =  productos.Existencia +'" & TbCantidad.Text & "'", conection)
            comandos.ExecuteNonQuery().ToString()



            TbIdProducto.Text = ""
            TbProducto.Text = ""
            TbPrecioCompra.Text = ""
            TbCantidad.Text = ""
            TbFecha.Text = ""
            LBExistencia.Text = ""


        End If

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click

        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos;")
        Dim Consulta As String = "Select * from productos where IdProducto='" & TbIdProducto.Text & "'"
        Dim comando As New MySqlCommand(Consulta, conection)
        TbFecha.Text = Today


        Dim drd As MySqlDataReader
        conection.Open()
        drd = comando.ExecuteReader
        If drd.Read() Then

            Me.TbIdProducto.Text = drd.Item("IdProducto").ToString
            Me.TbProducto.Text = drd.Item("Producto").ToString
            Me.TbPrecioCompra.Text = drd.Item("PrecioCompra").ToString
            Me.LBExistencia.Text = drd.Item("Existencia").ToString

        Else
            If TbIdProducto.Text = "" Then

                Me.TbProducto.Text = ""
                Me.TbCantidad.Text = ""
                Me.TbPrecioCompra.Text = ""
                Me.TbFecha.Text = ""
                Me.LBExistencia.Text = ""
            Else
                Dim Answer = MsgBox("No se ha encontrado el producto en la base de datos, ¿Desea darlo de alta?", vbYesNo)
                If Answer = vbYes Then

                    FrmAgregarProducto.Show()
                    FrmAgregarProducto.TbIdProducto.Text = TbIdProducto.Text
                    TbIdProducto.Text = ""
                Else
                    Me.TbIdProducto.Text = ""
                    Me.TbProducto.Text = ""
                    Me.TbCantidad.Text = ""
                    Me.TbPrecioCompra.Text = ""
                    Me.TbFecha.Text = ""
                    Me.LBExistencia.Text = ""
                End If

            End If
        End If
        drd.Close()
        conection.Close()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TbIdProducto.Text = ""
        TbProducto.Text = ""
        TbCantidad.Text = ""
        TbPrecioCompra.Text = ""
        TbFecha.Text = ""
        LBExistencia.Text = ""
        TbFecha.Text = ""
    End Sub
End Class