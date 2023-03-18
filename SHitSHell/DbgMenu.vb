Public Class DbgMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShareefDontLikeIt.SetLight()
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SHitSHell", "Appearance", "light")
        MsgBox("successfully set light mode", MsgBoxStyle.Information, "sukcess!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShareefDontLikeIt.SetDark()
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SHitSHell", "Appearance", "dark")
        MsgBox("successfully set dark mode", MsgBoxStyle.Information, "sukcess!")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DbgMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = getDefaultBrowser()
    End Sub
End Class