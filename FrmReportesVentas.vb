Imports MySql.Data.MySqlClient
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class FrmReportesventas
    Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub

    Private Sub FrmReportesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ' Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        'Dim table As New DataTable()
        ' Dim adaptador As New MySqlDataAdapter("SELECT Idproducto, Cantidad, Fecha FROM compras", conection)
        'adaptador.Fill(table)
        ' DgVenta.DataSource = table


        Try
            conection.Open()
            Dim cmd As New MySqlCommand("Select Idproducto, Cantidad, Fecha FROM venta", conection)
            Dim drd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd
            DgVenta.DataSource = bs
            drd.Close()
            conection.Close()


        Catch ex As Exception
            'SSI EL INTENTO ES FALLIDO MOSTRAR EL MENSAJE
            MessageBox.Show("No se pudo conectar con la bd.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try

        With DgVenta
            .Refresh()
        End With
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        Dim table As New DataTable()
        Dim adaptador As New MySqlDataAdapter("Select Idproducto, Cantidad, Fecha from venta where Fecha like '_%" & CBFecha.Text & "%__'", conection)
        adaptador.Fill(table)
        DgVenta.DataSource = table
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

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            'IMTENTARA GENERAR EL DOC
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'path guarda el reporte en el escritorio
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de ventas de productos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)

        Catch ex As Exception
            'SI EL INTENTO FALLA
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try '
    End Sub

    Public Function GetColumnasSize(ByRef dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values

    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(DgVenta.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DgVenta)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'SE CREA EL ENCABEZADO

        Dim encabezado As New Paragraph("Reporte de ventas", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        'SE CREA EL TEXTO ABAJO DEL ENCABEZADO
        Dim texto As New Phrase("Reporte de ventas realizadas en el mes: " + CBFecha.Text(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        For i As Integer = 0 To DgVenta.ColumnCount - 1
            datatable.AddCell(DgVenta.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'SE GENERA LAS COLUMNAS DEL DATAGRID
        For a As Integer = 0 To DgVenta.RowCount - 2
            For j As Integer = 0 To DgVenta.ColumnCount - 1
                datatable.AddCell(DgVenta(j, a).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'SE AGREGA EL PDFTABLE AL DOCUMENTO
        document.Add(encabezado)
            document.Add(texto)
        document.Add(datatable)
    End Sub
End Class