Public Class PerformerSearch
    Private Sub PerformerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PerformerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PerformerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'ApinihanDataSet.Manager' table. You can move, or remove it, as needed.
    'Me.ManagerTableAdapter.Fill(Me.ApinihanDataSet.Manager)
    'TODO: This line of code loads data into the 'ApinihanDataSet.Performer' table. You can move, or remove it, as needed.


    'End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles radRate2.CheckedChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.PerformerTableAdapter.FillBy1(Me.ApinihanDataSet.Performer, CType(txtMinPerformerCost.Text, Integer), CType(txtMaxPerformerCost.Text, Integer), Me.EvaluateRadioGroup(Me.grpRate))
            CountMatches()
        Catch ex As Exception

        End Try

    End Sub
    Private Function EvaluateRadioGroup(ByVal grp As GroupBox) As Integer
        Dim rad As RadioButton
        For Each rad In grp.Controls
            If (rad.Checked) Then Return CType(rad.Tag, Integer)
        Next rad
        Return 0.0
    End Function

    Private Sub PerformerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PerformerDataGridView.CellContentClick

    End Sub
    Private Sub CountMatches()
        Dim sum As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.PerformerDataGridView.Rows
            sum += dgvr.Cells("PerformerCost").Value

        Next dgvr
        Dim n As Integer
        n = Me.PerformerDataGridView.Rows.Count - 1
        nMatchesLabel.Text = n.ToString

        Dim avg As Decimal
        If (n > 0) Then
            avg = sum / n
        Else
            avg = 0
        End If
        AvgPriceLabel.Text = avg.ToString("$ #,###.##")
    End Sub

    Private Sub PerformerDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PerformerDataGridView.CellDoubleClick
        If (e.ColumnIndex = 2) Then Return
        Dim frmBook As New BookForm
        BookForm.Show()

        Dim PerformerID As String
        PerformerID = Me.PerformerDataGridView.Rows(e.RowIndex).Cells("PerformerID").Value
        BookForm.LoadBook(PerformerID)
        If BookForm.BookDataGridView.Rows.Count - 1 = 0 Then
            MsgBox("This performer has not been booked yet")
        End If
    End Sub
End Class
