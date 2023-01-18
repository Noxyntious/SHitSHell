Imports IWshRuntimeLibrary

Public Class SHitSHell

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SHitDock.Show()
        SHitLauncher.Show()
        ' thanks, shady ass website!! :)
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
        Me.Location = New Point(x, 0)
        ' prepare for maximum jank
        Timer1.Enabled = True
        TextBox1.Text = Format(Now, "hh:mm:ss")
        TextBox2.Text = Format(Now, "dd-mm-yyyy")
        Me.FormBorderStyle = FormBorderStyle.None
        Me.TopMost = True

    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    'Checks the combobox for a string, then runs a process based on the selected string. TIP: For things like this, it's best to use buttons with pretty icons.

    '    If ComboBox1.Text = "Explorer" Then
    '        Process.Start("explorer.exe")
    '        ComboBox1.Text = ""
    '    ElseIf ComboBox1.Text = "Command Prompt" Then
    '        Process.Start("cmd.exe")
    '        ComboBox1.Text = ""
    '    ElseIf ComboBox1.Text = "Notepad" Then
    '        Process.Start("notepad.exe")
    '        ComboBox1.Text = ""
    '    ElseIf ComboBox1.Text = "Internet" Then
    '        Process.Start("http://google.com")
    '        ComboBox1.Text = ""
    '    ElseIf ComboBox1.Text = "Control Panel" Then
    '        Process.Start("control.exe")
    '        ComboBox1.Text = ""
    '    ElseIf ComboBox1.Text = "Settings (Windows 10)" Then

    '        Try
    '            Process.Start("ms-settings:")
    '            ComboBox1.Text = ""
    '        Catch
    '            MsgBox("This feature only works on Windows 8 or later.", MsgBoxStyle.Critical, "Exception")
    '        End Try

    '    End If
    '    Exit Sub
    'End Sub
    'To hell with this shit

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)

    '    'Adds the application to the Startup folder.

    '    Dim WshShell As WshShell = New WshShell()
    '    Dim ShortcutPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
    '    Dim Shortcut As IWshShortcut = CType(WshShell.CreateShortcut(System.IO.Path.Combine(ShortcutPath, Application.ProductName) & ".lnk"), IWshShortcut)
    '    Shortcut.TargetPath = Application.ExecutablePath
    '    Shortcut.WorkingDirectory = Application.StartupPath
    '    Shortcut.Description = "SHitSHell"
    '    Shortcut.Save()
    '    MsgBox("SHitSHell has been added to the Startup folder.", MsgBoxStyle.Information, "Information")
    'End Sub
    'button doesnt exist anymore

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = TimeString
        TextBox2.Text = DateString
    End Sub 'i think this is like the only not jank piece of code
End Class