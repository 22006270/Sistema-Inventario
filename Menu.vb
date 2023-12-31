Public Class FrmMenu


    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmCompras.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        Me.Hide()
        FrmConsultasVentas.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Me.Hide()
        FrmConsultasCompras.Show()
    End Sub

    Private Sub ExistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaToolStripMenuItem.Click
        Me.Hide()
        FrmConsultasExsistencias.Show()
    End Sub

    Private Sub VentasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem2.Click
        Me.Hide()
        FrmReportesventas.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem2.Click
        Me.Hide()
        FrmReportesCompras.Show()
    End Sub

    Private Sub ExistenciaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExistenciaToolStripMenuItem1.Click
        Me.Hide()
        FrmReportesExistencias.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmCalculadora.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmProductos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FrmCompras.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        FrmVentas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FrmProveedores.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmCalculadora.Show()
    End Sub

 
End Class
