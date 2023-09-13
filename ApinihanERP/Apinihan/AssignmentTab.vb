Public Class AssignmentTab
    Private Sub AssignmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AssignmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub Assignment1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet1.Worker' table. You can move, or remove it, as needed.
        Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet1.Worker)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment' table. You can move, or remove it, as needed.
        Me.AssignmentTableAdapter.Fill(Me.ApinihanDataSet.Assignment)
        'TODO: This line of code loads data into the 'ApinihanDataSet1.Manager' table. You can move, or remove it, as needed.
        Me.ManagerTableAdapter.Fill(Me.ApinihanDataSet1.Manager)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Worker' table. You can move, or remove it, as needed.
        Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet.Worker)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment' table. You can move, or remove it, as needed.
        Me.AssignmentTableAdapter.Fill(Me.ApinihanDataSet.Assignment)

    End Sub



    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.AssignmentTableAdapter.FillBy(Me.ApinihanDataSet.Assignment, WorkerIDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TabWorker_Enter(sender As Object, e As EventArgs) Handles TabWorker.Enter
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        dgvr = Me.AssignmentDataGridView.CurrentRow
        If (dgvr Is Nothing) Then Return

        Dim WorkerIDCurrent As String
        WorkerIDCurrent = dgvr.Cells("WorkerID").Value
        Me.WorkerTableAdapter.FillBy(Me.ApinihanDataSet.Worker, WorkerIDCurrent)

    End Sub

    Private Sub AssignmentDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles AssignmentDataGridView.CellDoubleClick
        If e.ColumnIndex = 1 Then Me.Tab1.SelectTab(1)
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Me.AssignmentTableAdapter.FillBy2(Me.ApinihanDataSet.Assignment, CType(Me.DateTimePickerFrom.Text, DateTime), CType(Me.DateTimePickerTo.Text, DateTime))
        Catch ex As Exception
            MsgBox(ex.Message,, "Error in the Query")
        End Try
    End Sub

    Private Sub txtFilePath_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath.TextChanged

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.OpenFileDialog1.Title = "Get Employee Photo"
        Me.OpenFileDialog1.ShowDialog()
        MsgBox("Don't forget to click upload and save!")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtFilePath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If (txtFilePath.Text.Trim() <> "") Then WorkerPhotoPictureBox.Image = Image.FromFile(txtFilePath.Text)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        WorkerPhotoPictureBox.Image = Nothing
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.WorkerTableAdapter.FillBy1(Me.ApinihanDataSet.Worker)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.WorkerBindingSource.EndEdit()
        Me.WorkerTableAdapter.Update(Me.ApinihanDataSet.Worker)
    End Sub

    Private Sub btnSave2_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WorkerBindingSource.EndEdit()
        Me.WorkerTableAdapter.Update(Me.ApinihanDataSet.Worker)
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        'TODO: This line of code loads data into the 'ApinihanDataSet1.Worker' table. You can move, or remove it, as needed.
        Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet1.Worker)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment' table. You can move, or remove it, as needed.
        Me.AssignmentTableAdapter.Fill(Me.ApinihanDataSet.Assignment)
        'TODO: This line of code loads data into the 'ApinihanDataSet1.Manager' table. You can move, or remove it, as needed.
        Me.ManagerTableAdapter.Fill(Me.ApinihanDataSet1.Manager)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Worker' table. You can move, or remove it, as needed.
        Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet.Worker)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment' table. You can move, or remove it, as needed.
        Me.AssignmentTableAdapter.Fill(Me.ApinihanDataSet.Assignment)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.AssignmentBindingSource.EndEdit()
        Me.AssignmentTableAdapter.Update(Me.ApinihanDataSet.Assignment)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If AssignmentDataGridView.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            AssignmentDataGridView.Rows.Remove(AssignmentDataGridView.SelectedRows(0))
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub



    'Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
    'Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet1.Worker)
    'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment' table. You can move, or remove it, as needed.
    'Me.AssignmentTableAdapter.Fill(Me.ApinihanDataSet.Assignment)
    'TODO: This line of code loads data into the 'ApinihanDataSet1.Manager' table. You can move, or remove it, as needed.
    'Me.ManagerTableAdapter.Fill(Me.ApinihanDataSet1.Manager)
    'TODO: This line of code loads data into the 'ApinihanDataSet.Worker' table. You can move, or remove it, as needed.
    'Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet.Worker)
    'TODO: This line of code loads data into the 'ApinihanDataSet.Assignment' table. You can move, or remove it, as needed.
    'Me.AssignmentTableAdapter.Fill(Me.ApinihanDataSet.Assignment)
    'End Sub
End Class