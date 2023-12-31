Imports MySql.Data.MySqlClient
Public Class FrmModificarEliminarProveedor
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 

    Private Sub TbIdProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProveedor.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProveedor.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con letras
    End Sub

    Private Sub TbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim eliminar As String
        Dim si As Byte
        si = MsgBox("Desea Eliminar el Proveedor?", vbYesNo, "Eliminar")

        If si = 6 Then
            eliminar = "DELETE FROM Proveedores WHERE IdProveedor = '" & TbIdProveedor.Text & "'"
            comandos = New MySqlCommand(eliminar, conection)
            comandos.ExecuteNonQuery()
            MsgBox("Proveedor Eliminado!")
            Me.Dispose()
            TbIdProveedor.Text = ""
        End If
    End Sub

    Private Sub FrmModificarEliminarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conection.ConnectionString = "Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos"
            conection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FrmModificProveedor.Show()
        FrmModificProveedor.TbIdProveedor.Text = TbIdProveedor.Text
        FrmModificProveedor.TbProveedor.Text = TbProveedor.Text
        FrmModificProveedor.TbTelefono.Text = TbTelefono.Text
    End Sub
End Class