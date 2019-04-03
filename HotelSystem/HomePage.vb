Public Class HomePage
    Private Sub RefreshHomeInfo_Click(sender As Object, e As EventArgs) Handles RefreshHomeInfo.Click
        DateLabel.Text = System.DateTime.Now.ToString("dd MMMM yyyy")
    End Sub
End Class