Imports MySql.Data.MySqlClient
Public Class FrmProveedores
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim table As New DataTable
        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos ")
        Dim Consulta As String = "Select * from Proveedores where IdProveedor='" & TbIdProveedor.Text & "'"
        Dim comando As New MySqlCommand(Consulta, conection)


        Try
            Dim drd As MySqlDataReader
            conection.Open()
            drd = comando.ExecuteReader
            If drd.Read() Then
                FrmModificarEliminarProveedor.Show()
                FrmModificarEliminarProveedor.TbIdProveedor.Text = drd.Item("IdProveedor").ToString
                FrmModificarEliminarProveedor.TbProveedor.Text = drd.Item("Proveedor").ToString
                FrmModificarEliminarProveedor.TbTelefono.Text = drd.Item("Telefono").ToString

            Else
                If TbIdProveedor.Text = "" Then
                    MsgBox("Debe agregar un ID a buscar")
                Else
                    MessageBox.Show("No se ha encontrado ningun Proveedor, por favor ingrese el Nuevo Proveedor")
                    FrmModificarEliminarProveedor.TbIdProveedor.Text = ""
                    FrmModificarEliminarProveedor.TbProveedor.Text = ""
                    FrmModificarEliminarProveedor.TbTelefono.Text = ""

                    FrmAgregarProveedores.Show()
                    FrmAgregarProveedores.TbIdProveedor.Text = TbIdProveedor.Text

                End If
            End If
            drd.Close()
            conection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TbIdProveedor.Text = ""
    End Sub

    Private Sub BtnAgregarProveedor_Click(sender As Object, e As EventArgs)
        FrmModificarEliminarProveedor.Show()
    End Sub

    Private Sub TbIdProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbIdProveedor.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub TbIdProveedor_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        If TbIdProveedor.CanFocus Then
            Me.TbIdProveedor.Focus()
        Else
            Me.TbIdProveedor.Select()
            Me.ActiveControl = TbIdProveedor
        End If
    End Sub
End Class