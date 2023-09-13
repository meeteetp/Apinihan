Public Class SalariesPayableRpt
    Private Sub SalariesPayableRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment1' table. You can move, or remove it, as needed.
        Me.Assignment1TableAdapter.Fill(Me.ApinihanDataSet.Assignment1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class