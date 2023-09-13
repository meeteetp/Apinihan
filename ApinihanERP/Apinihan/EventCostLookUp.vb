Public Class EventCostLookUp
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EventCostLookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.vw_EventVarCost' table. You can move, or remove it, as needed.
        'Me.Vw_EventVarCostTableAdapter.Fill(Me.ApinihanDataSet.vw_EventVarCost)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            Me.Vw_EventVarCostTableAdapter.FillBy(Me.ApinihanDataSet.vw_EventVarCost, CType(Me.txtMinPerformer.Text, Integer), CType(Me.txtMaxPerformer.Text, Integer), CType(Me.DateTimePickerFrom.Text, DateTime), CType(Me.DateTimePickerTo.Text, DateTime))
            CountMatches()
        Catch ex As Exception
            MsgBox(ex.Message,, "Error in the Query")
        End Try

    End Sub

    Private Sub CountMatches()
        Dim sumPerformerCost As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.Vw_EventVarCostDataGridView.Rows
            sumPerformerCost += dgvr.Cells("PerformerCost").Value
        Next
        lblTotalPerformerCost.Text = sumPerformerCost.ToString("$ #,##0.##")

        Dim n As Integer
        n = Me.Vw_EventVarCostDataGridView.Rows.Count - 1
        nMatchesLabel.Text = n.ToString

        Dim avgPerformerCost As Decimal
        If (n > 0) Then
            avgPerformerCost = sumPerformerCost / n
        Else
            avgPerformerCost = 0
        End If
        lblAvgPerformerCost.Text = avgPerformerCost.ToString("$ #,##0.##")
    End Sub

End Class