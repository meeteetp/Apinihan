Public Class IncomebyEventRpt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Event1' table. You can move, or remove it, as needed.
        Me.Event1TableAdapter.Fill(Me.ApinihanDataSet.Event1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class