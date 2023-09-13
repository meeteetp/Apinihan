Imports System.Text.RegularExpressions


Public Class StartupMiddleManager
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        CustomerForm.Show()

    End Sub

    Private Sub StartupExecutive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnWorker_Click(sender As Object, e As EventArgs) Handles btnWorker.Click
        WorkerUpdate.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        AssignmentTab.Show()

    End Sub

    Private Sub btnEquipment_Click(sender As Object, e As EventArgs) Handles btnEquipment.Click
        EquipmentInstall.Show()

    End Sub

    Private Sub btnPerformer_Click(sender As Object, e As EventArgs) Handles btnPerformer.Click
        PerformerSearch.Show()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs)
        BookForm.Show()

    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click
        EventCostLookUp.Show()

    End Sub


    Private Sub btnPerformerBookRpt_Click(sender As Object, e As EventArgs) Handles btnPerformerBookRpt.Click
        EventCity.Show()
    End Sub

    Private Sub btnEventRpt_Click(sender As Object, e As EventArgs) Handles btnEventRpt.Click
        HighProfileClients.Show()

    End Sub

    Private Sub btnCustomerRpt_Click(sender As Object, e As EventArgs) Handles btnCustomerRpt.Click
        IncomebyEventRpt.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PerformerNeverBooked.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SalariesPayableRpt.Show()

    End Sub
End Class