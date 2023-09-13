Public Class WorkerUpdate
    Private Sub WorkerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WorkerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub WorkerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Worker' table. You can move, or remove it, as needed.
        Me.WorkerTableAdapter.Fill(Me.ApinihanDataSet.Worker)

    End Sub

    Private Sub WorkerDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles WorkerDataGridView.CellDoubleClick
        If e.ColumnIndex = 0 Then Me.Tab1.SelectTab(1)
    End Sub

    Private Sub TabWorker_Enter(sender As Object, e As EventArgs) Handles TabWorker.Enter
        ' Dim dgvr As System.Windows.Forms.DataGridViewRow
        ' dgvr = Me.WorkerDataGridView.CurrentRow
        ' If (dgvr Is Nothing) Then Return
        '
        '        Dim WorkerIDCurrent As String
        '        WorkerIDCurrent = dgvr.Cells("WorkerID").Value
        '        Me.WorkerTableAdapter.FillBy(Me.ApinihanDataSet.Worker, WorkerIDCurrent)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.WorkerBindingSource.EndEdit()
        Me.WorkerTableAdapter.Update(Me.ApinihanDataSet.Worker)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.WorkerBindingSource.EndEdit()
        Me.WorkerTableAdapter.Update(Me.ApinihanDataSet.Worker)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class