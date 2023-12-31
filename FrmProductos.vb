Imports MySql.Data.MySqlClient

Public Class FrmProductos
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub BtnModificar_Click(sender As Object, e As EventArgs)
        FrmModificProducto.Show()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim table As New DataTable
        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos;")
        Dim Consulta As String = "Select * from Productos where IdProducto='" & TbIdProducto.Text & "'"
        Dim comando As New MySqlCommand(Consulta, conection)

        Try
                Dim drd As MySqlDataReader
                conection.Open()
            drd = comando.ExecuteReader


            If drd.Read() Then
                FrmModificarEliminarProduct.Show()
                FrmModificarEliminarProduct.TbIdProducto.Text = drd.Item("IdProducto").ToString
                FrmModificarEliminarProduct.TbProducto.Text = drd.Item("Producto").ToString
                FrmModificarEliminarProduct.TbExistencia.Text = drd.Item("Existencia").ToString
                FrmModificarEliminarProduct.TbPrecio.Text = drd.Item("Precio").ToString
                FrmModificarEliminarProduct.TbPrecioCompra.Text = drd.Item("PrecioCompra").ToString
                FrmModificarEliminarProduct.TbFecha.Text = drd.Item("Fecha").ToString

            Else
                If TbIdProducto.Text = "" Then
                    MsgBox("Debe agregar un ID a buscar")
                Else
                    MessageBox.Show("No se ha encontrado ningun Producto, por favor ingrese el Nuevo Producto")

                    FrmModificarEliminarProduct.TbProducto.Text = ""
                    FrmModificarEliminarProduct.TbProducto.Text = ""
                    FrmModificarEliminarProduct.TbExistencia.Text = ""
                    FrmModificarEliminarProduct.TbPrecio.Text = ""
                    FrmModificarEliminarProduct.TbPrecioCompra.Text = ""
                    FrmModificarEliminarProduct.TbFecha.Text = ""

                    FrmAgregarProducto.Show()
                    FrmAgregarProducto.TbIdProducto.Text = TbIdProducto.Text

                End If
            End If
            drd.Close()
            conection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TbIdProducto.Text = ""

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
        FrmMenu.Show()

    End Sub

    Private Sub TbIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProducto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbIdProducto_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        If TbIdProducto.CanFocus Then
            Me.TbIdProducto.Focus()
        Else
            Me.TbIdProducto.Select()
            Me.ActiveControl = TbIdProducto
        End If
    End Sub

    Private Sub TbIdProducto_TextChanged_1(sender As Object, e As EventArgs) Handles TbIdProducto.TextChanged

    End Sub
End Class
