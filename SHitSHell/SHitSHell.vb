Imports IWshRuntimeLibrary
Imports System.Runtime.InteropServices
Imports System.Configuration
Module ShareefDontLikeIt
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As SetWindowPosFlags) As Boolean
    End Function

    <Flags>
    Private Enum SetWindowPosFlags As UInteger
        SynchronousWindowPosition = &H4000
        DeferErase = &H2000
        DrawFrame = &H20
        FrameChanged = &H20
        HideWindow = &H80
        DoNotActivate = &H10
        DoNotCopyBits = &H100
        IgnoreMove = &H2
        DoNotChangeOwnerZOrder = &H200
        DoNotRedraw = &H8
        DoNotReposition = &H200
        DoNotSendChangingEvent = &H400
        IgnoreResize = &H1
        IgnoreZOrder = &H4
        ShowWindow = &H40
    End Enum

    Sub HideTheTaskbar()
        'Hide taskbar on ShitShell startup.
        Dim window As IntPtr = FindWindow("Shell_traywnd", "")
        SetWindowPos(window, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.HideWindow)
    End Sub
    Sub SHitClose()
        'Show the taskbar when Shitshell is closed.
        Dim window As IntPtr = FindWindow("Shell_traywnd", "")
        SetWindowPos(window, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.ShowWindow)
        SHitSHell.Close()
    End Sub
    Sub SetLight()
        SHitSHell.TextBox1.ForeColor = Color.Black
        SHitSHell.TextBox2.ForeColor = Color.Black
        SHitSHell.TextBox1.BackColor = Color.WhiteSmoke
        SHitSHell.TextBox2.BackColor = Color.WhiteSmoke
        SHitSHell.BackColor = Color.WhiteSmoke
        SHitLauncher.BackColor = Color.WhiteSmoke
        SHitDock.BackColor = Color.WhiteSmoke
    End Sub
    Sub SetDark()
        SHitSHell.TextBox1.ForeColor = Color.White
        SHitSHell.TextBox2.ForeColor = Color.White
        SHitSHell.TextBox1.BackColor = Color.FromArgb(64, 64, 64)
        SHitSHell.TextBox2.BackColor = Color.FromArgb(64, 64, 64)
        SHitSHell.BackColor = Color.FromArgb(64, 64, 64)
        SHitLauncher.BackColor = Color.FromArgb(64, 64, 64)
        SHitDock.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
End Module

Public Class SHitSHell
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Registry.CurrentUser.CreateSubKey("SHitSHell")
        'Dim RegKeyAppearance = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SHitSHell", "Appearance", Nothing)
        'If RegKeyAppearance Is "light" Then
        '    MsgBox("Detected Light mode in registry.")
        '    ShareefDontLikeIt.SetLight()
        'ElseIf RegKeyAppearance Is "dark" Then
        '    MsgBox("Detected Dark mode in registry.")
        '    ShareefDontLikeIt.SetDark()
        'Else
        '    MsgBox("Registry value does not exist. Creating now.")
        '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SHitSHell", "Appearance", "dark")
        'End If
        'MsgBox("Style value is " & RegKeyAppearance)
        ShareefDontLikeIt.HideTheTaskbar()
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
        Me.Height = 22
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