Public Class CustomerForm
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet._Event' table. You can move, or remove it, as needed.
        Me.EventTableAdapter.Fill(Me.ApinihanDataSet._Event)
        'TODO: This line of code loads data into the 'ApinihanDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.ApinihanDataSet.Customer)
        CountMatches()

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomerTableAdapter.FillBy(Me.ApinihanDataSet.Customer, CustNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Search_CustNameToolStripButton_Click(sender As Object, e As EventArgs) Handles Search_CustNameToolStripButton.Click
        Try
            Me.CustomerTableAdapter.Search_CustName(Me.ApinihanDataSet.Customer, CustNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        CountMatches()
    End Sub

    Private Sub GenerateCustomerID()
        'First Letter of Customer Name + 6 auto-numbers
        If txtCustomerName.Text = Nothing Then
            MsgBox("Please put customer name")
            'For Each 
            'Else
            'txtCustomerID.Text = Left(txtCustomerName.Text, 1) + number
        End If
        'loop through numbers
        'Dim cmd As New Data.SqlClient.SqlCommand

    End Sub

    Private Sub CountMatches()
        Dim sumSpending As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.EventDataGridView.Rows
            sumSpending += dgvr.Cells("EventPrice").Value
        Next
        lblTotalSpending.Text = sumSpending.ToString("$ #,##0.##")

        Dim n As Integer
        n = Me.EventDataGridView.Rows.Count - 1
        lblEventCount.Text = n.ToString
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        CountMatches()
    End Sub

    Private Sub btnGenerateID_Click(sender As Object, e As EventArgs)
        GenerateCustomerID()
    End Sub
    Dim IsAdding As Boolean = False
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        btnGenerate.Enabled = True
        IsAdding = True
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If IsAdding Then
            Try
                Dim cmd As New Data.SqlClient.SqlCommand
                cmd.CommandText = "SELECT CAST(Right(Max(CustomerID), 6) AS INTEGER) As MaxID FROM CUSTOMER WHERE CustomerID LIKE '" + Microsoft.VisualBasic.Left(txtCustomerName.Text, 1) + "%'"

                cmd.CommandType = CommandType.Text
                cmd.Connection = Me.CustomerTableAdapter.Connection
                Dim i As Integer
                cmd.Connection.Open()
                i = cmd.ExecuteScalar() + 1
                cmd.Connection.Close()

                Me.txtCustomerID.Text = Microsoft.VisualBasic.Left(txtCustomerName.Text, 1) + i.ToString("D6")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
