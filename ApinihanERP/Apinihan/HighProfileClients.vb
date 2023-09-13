Public Class HighProfileClients
    Private Sub HighProfileClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Customer1' table. You can move, or remove it, as needed.
        Me.Customer1TableAdapter.Fill(Me.ApinihanDataSet.Customer1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class