Public Class LoginPage
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameBox.Text = "iSimon" Then
            If PasswordBox.Text = "TestPass1" Then
                Label1.Visible = False
                Label2.Visible = False
                Label3.Visible = False
                UsernameBox.Visible = False
                PasswordBox.Visible = False
                LoginButton.Visible = False
            End If
        End If

    End Sub
End Class
