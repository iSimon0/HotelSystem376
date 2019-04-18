Public Class LoginPage
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameBox.Text = "name" Then
            If PasswordBox.Text = "pass" Then
                Dim form As New HomePage
                form.Show()
                Me.Close()
            End If
        End If

    End Sub

End Class
