
Imports MySql.Data.MySqlClient
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class FrmReportesExistencias
    Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Dispose()
        FrmMenu.Show()
    End Sub

    Private Sub FrmReportesExistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CBFecha.Items.Add("Mes")
        'CBFecha.Items.Add("01")
        'CBFecha.Items.Add("02")
        ' CBFecha.Items.Add("03")
        'CBFecha.Items.Add("04")
        'CBFecha.Items.Add("05")
        'CBFecha.Items.Add("06")
        ' CBFecha.Items.Add("07")
        'CBFecha.Items.Add("08")
        'CBFecha.Items.Add("09")
        'CBFecha.Items.Add("10")
        ' CBFecha.Items.Add("11")
        'CBFecha.Items.Add("12")

        'Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        'Dim table As New DataTable()
        'Dim adaptador As New MySqlDataAdapter("SELECT  Idproducto, Producto,Existencia, Fecha FROM productos", conection)
        'adaptador.Fill(table)
        'DgExistencia.DataSource = table

        Try
            conection.Open()
            Dim cmd As New MySqlCommand("Select Idproducto, Producto,Existencia, Fecha FROM productos", conection)
            Dim drd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
            Dim bs As New BindingSource
            bs.DataSource = drd
            DgExistencia.DataSource = bs
            drd.Close()
            conection.Close()


        Catch ex As Exception
            'SSI EL INTENTO ES FALLIDO MOSTRAR EL MENSAJE
            MessageBox.Show("No se pudo conectar con la bd.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try

        With DgExistencia
            .Refresh()
        End With


    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs)
        ' Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        ' Dim table As New DataTable()
        ' Dim adaptador As New MySqlDataAdapter("SELECT Idproducto, Producto,Existencia, Fecha FROM productos", conection)
        'adaptador.Fill(table)
        'DgExistencia.DataSource = table
        'With DgExistencia
        '.Refresh()
        'End With
        'CBFecha.Text = " "
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs)
        ' Dim conection As New MySqlConnection("Server=127.0.0.1;User=root;Password=18112004;Port=3306;database=existenciaproductos")
        ' Dim table As New DataTable()
        'Dim adaptador As New MySqlDataAdapter("Select Idproducto, Producto,Existencia, Fecha FROM productos where Fecha like '_%" & CBFecha.Text & "%__'", conection)
        'adaptador.Fill(table)
        'DgExistencia.DataSource = table
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        'OPCION 1
        'FrmImprimir.Show()
        'FrmImprimir.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        ' FrmImprimir.PrintForm1.Print()

        'OPCION 2
        'PrintDialog1.Document = PrintDocument1
        'PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        'PrintDialog1.AllowSomePages = True

        ' If PrintDialog1.ShowDialog = DialogResult.OK Then
        'PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        ' PrintDocument1.Print()
        ' End If


        Try
            'IMTENTARA GENERAR EL DOC
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'path guarda el reporte en el escritorio
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Existencia de productos.pdf"
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
        Dim datatable As New PdfPTable(DgExistencia.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(DgExistencia)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'SE CREA EL ENCABEZADO

        Dim encabezado As New Paragraph("Reporte de Existencia", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        'SE CREA EL TEXTO ABAJO DEL ENCABEZADO
        Dim texto As New Phrase("Reporte de Existencias realizadas en el mes: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        For i As Integer = 0 To DgExistencia.ColumnCount - 1
            datatable.AddCell(DgExistencia.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'SE GENERA LAS COLUMNAS DEL DATAGRID
        For i As Integer = 0 To DgExistencia.RowCount - 1
            For j As Integer = 0 To DgExistencia.ColumnCount - 1
                datatable.AddCell(DgExistencia(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        'SE AGREGA EL PDFTABLE AL DOCUMENTO
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub CBFecha_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class