Public Class EquipmentInstall
    Private Sub EquipmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EquipmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub EquipmentDataGridView_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles EquipmentDataGridView.UserAddedRow

    End Sub

    Private Sub EquipmentInstall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet._Event' table. You can move, or remove it, as needed.
        Me.EventTableAdapter.Fill(Me.ApinihanDataSet._Event)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Install' table. You can move, or remove it, as needed.
        Me.InstallTableAdapter.Fill(Me.ApinihanDataSet.Install)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.ApinihanDataSet.Equipment)

    End Sub
    Dim IsAdding As Boolean = False


End Class