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
        Me.Location = New Point(x / 2, y + 35)
        Me.TopMost = True
        With Me
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .Region = New Region(RoundedRectangle(.ClientRectangle, 50))
        End With
        With Me
            .ShowInTaskbar = False
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
            .Opacity = 0.96
            Dim r As Rectangle = Me.Bounds
            r.Inflate(2, 2)
            .Bounds = r
            .Region = New Region(RoundedRectangle(.ClientRectangle, 30))
            r = New Rectangle(3, 3, Me.Width - 1, Me.Height - 1)
            .Region.Exclude(RoundedRectangle(r, 48))
        End With
    End Sub

    Private Function RoundedRectangle(rect As RectangleF, diam As Single) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath
        path.AddArc(rect.Left, rect.Top, diam, diam, 180, 90)
        path.AddArc(rect.Right - diam, rect.Top, diam, diam, 270, 90)
        path.AddArc(rect.Right - diam, rect.Bottom - diam, diam, diam, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - diam, diam, diam, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ExplorerIcon.Click
        'Starts new instance of Windows Explorer.
        Process.Start("explorer.exe")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles SettingsIcon.Click
        'Tries to launch modern settings. If the user is running Windows 7, then it will and launch Control Panel instead.
        Try
            Process.Start("ms-settings:")
        Catch
            Process.Start("control")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles InternetIcon.Click
        'Launches the default browser.
        Process.Start(getDefaultBrowser)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Shows the shutdown dialogue.
        ShutdownPrompt.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Starts Command Prompt.
        Process.Start("cmd.exe")
    End Sub
End Class