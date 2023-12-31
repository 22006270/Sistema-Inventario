Imports MySql.Data.MySqlClient
Public Class FrmModificProveedor
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 
    Private Sub TbIdProveedor_TextChanged(sender As Object, e As EventArgs) Handles TbIdProveedor.TextChanged

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        'Dim modificar As String
        If TbProveedor.Text = "" Or TbTelefono.Text = "" Then
            MsgBox("Faltan datos por agregar")
        Else
            Dim comandos As New MySqlCommand("UPDATE proveedores SET Proveedor = @Proveedor, Telefono = @Telefono
            WHERE IdProveedor= '" & TbIdProveedor.Text & "'", conection)
            comandos.Parameters.AddWithValue("@Proveedor", TbProveedor.Text)
            comandos.Parameters.AddWithValue("@Telefono", TbTelefono.Text)

            comandos.ExecuteNonQuery()
            MsgBox("Proveedor Modificado!")
            Me.Dispose()
            FrmModificarEliminarProveedor.Dispose()
        End If
    End Sub

    Private Sub FrmModificProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conection.ConnectionString = "Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos"
            conection.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub TbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProveedor.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con letras
    End Sub
    Private Sub TbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con letras
    End Sub
End Class