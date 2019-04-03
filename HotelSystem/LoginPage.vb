Public Class LoginPage
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameBox.Text = "iSimon" Then
            If PasswordBox.Text = "TestPass1" Then
                Dim form As New HomePage
                form.Show()
                Me.Close()
            End If
        End If

    End Sub
End Class
