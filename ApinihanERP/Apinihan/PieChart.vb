Public Class PieChart
    Private Sub PieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Event2' table. You can move, or remove it, as needed.
        Me.Event2TableAdapter.Fill(Me.ApinihanDataSet.Event2)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class