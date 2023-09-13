Public Class ManagerForm
    Private Sub ManagerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ManagerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ManagerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet._Event' table. You can move, or remove it, as needed.
        Me.EventTableAdapter.Fill(Me.ApinihanDataSet._Event)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Manager' table. You can move, or remove it, as needed.
        Me.ManagerTableAdapter.Fill(Me.ApinihanDataSet.Manager)

    End Sub
End Class