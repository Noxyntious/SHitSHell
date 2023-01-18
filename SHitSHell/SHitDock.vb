Public Class SHitDock
    Private Sub SHitDock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim working_area As Rectangle =
SystemInformation.WorkingArea
        Dim x As Integer =
            working_area.Left +
            working_area.Width -
            Me.Width
        Dim y As Integer =
            working_area.Top +
            working_area.Height -
        Me.Height
        Me.Location = New Point(x / 2, y + 40)
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Process.Start("ms-settings:")
        Catch
            MsgBox("This feature only works on Windows 8 or later.", MsgBoxStyle.Critical, "Exception")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("explorer.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://google.com")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ShutdownPrompt.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("cmd.exe")
    End Sub
End Class