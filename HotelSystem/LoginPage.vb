Public Class LoginPage
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameBox.Text = "iSimon" Then
            If PasswordBox.Text = "CIS376" Then
                Dim form As New HomePage
                form.Show()
                Me.Close()
            Else
                FailedLogin.Text = "Invalid Login"
            End If
        ElseIf UsernameBox.Text = "kMurdock" Then
            If PasswordBox.Text = "CIS376" Then
                Dim form As New HomePage
                form.Show()
                Me.Close()
            Else
                FailedLogin.Text = "Invalid Login"
            End If
        ElseIf UsernameBox.Text = "aSayad" Then
            If PasswordBox.Text = "CIS376" Then
                Dim form As New HomePage
                form.Show()
                Me.Close()
            Else
                FailedLogin.Text = "Invalid Login"
            End If
        Else
            FailedLogin.Text = "Invalid Login"
        End If

    End Sub

End Class
