Public Class ShutdownPrompt
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "Shut down" Then
            Process.Start("shutdown", "/s /t 00")
        ElseIf ComboBox1.Text = "Restart" Then
            Process.Start("shutdown", "/s /t 00")
        ElseIf ComboBox1.Text = "Close SHitSHell" Then
            ShareefDontLikeIt.SHitClose()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Shut down" Then
            Label2.Text = "Closes all apps and shuts down the PC."
        ElseIf ComboBox1.Text = "Restart" Then
            Label2.Text = "Closes all apps and restarts the PC."
        ElseIf ComboBox1.Text = "Close SHitSHell" Then
            Label2.Text = "Closes SHitSHell and returns the default desktop."
        End If
    End Sub

    Private Sub ShutdownPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class