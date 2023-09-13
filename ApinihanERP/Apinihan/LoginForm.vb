Public Class LoginForm
    Private Sub UsernamepassBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsernamepassBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub UsernamepassBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsernamepassBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ApinihanDataSet)

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ApinihanDataSet.Usernamepass' table. You can move, or remove it, as needed.
        'Me.UsernamepassTableAdapter.Fill(Me.ApinihanDataSet.Usernamepass)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.UsernamepassTableAdapter.FillBy(Me.ApinihanDataSet.Usernamepass, CType(Me.UsernameTextBox.Text, String), CType(Me.PasswordTextBox.Text, String))
        'If PositionTextBox.Text = "Executive" Then
        'Dim MiddleManagerStartup As New StartupMiddleManager
        'MiddleManagerStartup.Show()
        'Else
        'MsgBox("lololol")
        'End If
        'If UsernamepassBindingSource Is DBNull Then
        'MsgBox("hello")
        ' End If
    End Sub

    Private Sub PositionTextBox_TextChanged(sender As Object, e As EventArgs) Handles PositionTextBox.TextChanged
        If PositionTextBox.Text = "Executive" Then
            Dim ExecutiveStartup As New StartupExecutive
            ExecutiveStartup.Show()
            ExecutiveStartup.lblLoggedinAs.Text = "Login ID: " + UsernameTextBox.Text

            'Else
            'MsgBox(" Thenlololol")
        ElseIf PositionTextBox.Text = "MiddleManager" Then
            Dim MiddleManagerStartup As New StartupMiddleManager
            MiddleManagerStartup.Show()
            MiddleManagerStartup.lblLoggedinAs.Text = "Login ID: " + UsernameTextBox.Text
            'MsgBox("WRONG wrongwrong")
        Else
            MsgBox("Wrong Username/Password")
        End If

    End Sub

End Class