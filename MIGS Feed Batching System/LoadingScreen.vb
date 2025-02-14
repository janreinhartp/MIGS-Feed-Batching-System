Public Class LoadingScreen
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Me.Hide()
        frmSettings.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class