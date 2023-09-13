Public Class EventCity
    Private Sub EventCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Event2' table. You can move, or remove it, as needed.
        Me.Event2TableAdapter.Fill(Me.ApinihanDataSet.Event2)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PieChart.Show()
    End Sub
End Class