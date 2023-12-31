Imports MySql.Data.MySqlClient
Public Class FrmConsultasVentas


    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
        FrmMenu.Show()

    End Sub



    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        Dim table As New DataTable()
        Dim adaptador As New MySqlDataAdapter("Select IdProducto, Cantidad, Fecha from venta where Fecha like '_%" & CBFecha.Text & "%__'", conection)
        adaptador.Fill(table)
        DgVenta.DataSource = table

    End Sub
    Private Sub FrmConsultasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBFecha.Items.Add("Mes")
        CBFecha.Items.Add("01")
        CBFecha.Items.Add("02")
        CBFecha.Items.Add("03")
        CBFecha.Items.Add("04")
        CBFecha.Items.Add("05")
        CBFecha.Items.Add("06")
        CBFecha.Items.Add("07")
        CBFecha.Items.Add("08")
        CBFecha.Items.Add("09")
        CBFecha.Items.Add("10")
        CBFecha.Items.Add("11")
        CBFecha.Items.Add("12")

        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        Dim table As New DataTable()
        Dim adaptador As New MySqlDataAdapter("SELECT Idproducto, Cantidad, Fecha FROM venta", conection)
        adaptador.Fill(table)
        DgVenta.DataSource = table
        With DgVenta
            .Refresh()
        End With


    End Sub



    Private Sub TbFecha_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub Numeric_ValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub CBFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBFecha.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) 'Codigo para validar solo campos con numeros
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        Dim table As New DataTable()
        Dim adaptador As New MySqlDataAdapter("SELECT Idproducto, Cantidad, Fecha FROM venta", conection)
        adaptador.Fill(table)
        DgVenta.DataSource = table
        With DgVenta
            .Refresh()
        End With
        CBFecha.Text = " "
    End Sub
End Class