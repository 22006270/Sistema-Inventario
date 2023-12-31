Imports MySql.Data.MySqlClient
Public Class FrmAgregarProveedores
    Dim conection As New MySqlConnection
    Dim comandos As New MySqlCommand
    Dim datos As New DataSet 'donde guardaremos los datos de la conexion
    Dim adaptador As New MySqlDataAdapter 'podremos manejar los datos 

    Private Sub FrmAgregarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conection.ConnectionString = "Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos"
            conection.Open()
            'MsgBox("Inserta el nuevo Proveedor")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TbIdProveedor_TextChanged(sender As Object, e As EventArgs)
        Dim posactual As Integer
        posactual = TbIdProveedor.SelectionStart
    End Sub

    Private Sub TbIdProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProveedor.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbProveedor.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con letras
    End Sub
    Private Sub TbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TbIdProveedor.Text = "" Or TbProveedor.Text = "" Or TbTelefono.Text = "" Then
            MsgBox("Faltan Datos Por Agregar")

        Else
            Try
                comandos = New MySqlCommand("INSERT INTO proveedores(IdProveedor, Proveedor, Telefono)" & Chr(13) & "VALUES (@IdProveedor, @Proveedor, @Telefono)", conection)
                comandos.Parameters.AddWithValue("@IdProveedor", TbIdProveedor.Text)
                comandos.Parameters.AddWithValue("@Proveedor", TbProveedor.Text)
                comandos.Parameters.AddWithValue("@Telefono", TbTelefono.Text)
                comandos.ExecuteNonQuery()
                MsgBox("Proveedor Guardado Exitosamente!")
                TbIdProveedor.Text = ""
                TbProveedor.Text = ""
                TbTelefono.Text = ""
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub TbProveedor_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        If TbProveedor.CanFocus Then
            Me.TbProveedor.Focus()
        Else
            Me.TbProveedor.Select()
            Me.ActiveControl = TbProveedor
        End If
    End Sub
End Class