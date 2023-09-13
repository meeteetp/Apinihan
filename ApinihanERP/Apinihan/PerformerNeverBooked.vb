Public Class PerformerNeverBooked
    Private Sub PerformerNeverBooked_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Performer1' table. You can move, or remove it, as needed.
        Me.Performer1TableAdapter.Fill(Me.ApinihanDataSet.Performer1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class