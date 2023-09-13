Public Class BookForm
    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet._Event' table. You can move, or remove it, as needed.
        'Me.EventTableAdapter.Fill(Me.ApinihanDataSet._Event)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Performer' table. You can move, or remove it, as needed.
        Me.PerformerTableAdapter.Fill(Me.ApinihanDataSet.Performer)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.ApinihanDataSet.Book)

    End Sub



    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy2ToolStripButton.Click
        Try
            Me.BookTableAdapter.FillBy2(Me.ApinihanDataSet.Book, PerformerIDToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub LoadBook(ByVal PerformerID As String)
        BookTableAdapter.FillBy2(ApinihanDataSet.Book, PerformerID)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub BookDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class