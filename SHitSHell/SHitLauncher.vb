Imports IWshRuntimeLibrary
Public Class SHitLauncher
    Private Sub SHitLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Location = New Point(0, 0)
        Me.TopMost = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Checks the combobox for a string, then runs a process based on the selected string. TIP: For things like this, it's best to use buttons with pretty icons.

        If ComboBox1.Text = "Exit" Then
            SHitSHell.Close()
            ComboBox1.Text = ""
        ElseIf ComboBox1.Text = "Add to Startup" Then
            Dim WshShell As WshShell = New WshShell()
            Dim ShortcutPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            Dim Shortcut As IWshShortcut = CType(WshShell.CreateShortcut(System.IO.Path.Combine(ShortcutPath, Application.ProductName) & ".lnk"), IWshShortcut)
            Shortcut.TargetPath = Application.ExecutablePath
            Shortcut.WorkingDirectory = Application.StartupPath
            Shortcut.Description = "SHitSHell"
            Shortcut.Save()
            MsgBox("SHitSHell has been added to the Startup folder.", MsgBoxStyle.Information, "Information")
            ComboBox1.Text = ""
        ElseIf ComboBox1.Text = "Credits" Then
            MsgBox("Noxyntious - almost everything" + vbCrLf + "WindowsLogic - add to startup, other things", MsgBoxStyle.Information, "Credits")
            ComboBox1.Text = ""
        End If
        Exit Sub
    End Sub
End Class