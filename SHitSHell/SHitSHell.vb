Imports System.Runtime.InteropServices
Imports Microsoft.Win32

#Region "Various Settings"
Module ShareefDontLikeIt
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As SetWindowPosFlags) As Boolean
    End Function
    <DllImport("shell32.dll", EntryPoint:="FindExecutableW")>
    Public Function FindExecutableW(<InAttribute(), MarshalAs(UnmanagedType.LPTStr)> ByVal lpFile As String, <InAttribute(), MarshalAs(UnmanagedType.LPTStr)> ByVal lpDirectory As String, <MarshalAs(UnmanagedType.LPWStr)> ByVal lpResult As System.Text.StringBuilder) As IntPtr
    End Function
    Public Function getDefaultBrowser() As String
        Dim tmpFile As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "fake.html")
        IO.File.WriteAllText(tmpFile, "")
        Dim sb As New System.Text.StringBuilder(260)
        FindExecutableW(tmpFile, Nothing, sb)
        If IO.File.Exists(tmpFile) Then IO.File.Delete(tmpFile)
        Return sb.ToString
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
        My.Settings.Appearance = 1
        My.Settings.Save()
    End Sub
    Sub SetDark()
        SHitSHell.TextBox1.ForeColor = Color.White
        SHitSHell.TextBox2.ForeColor = Color.White
        SHitSHell.TextBox1.BackColor = Color.FromArgb(64, 64, 64)
        SHitSHell.TextBox2.BackColor = Color.FromArgb(64, 64, 64)
        SHitSHell.BackColor = Color.FromArgb(64, 64, 64)
        SHitLauncher.BackColor = Color.FromArgb(64, 64, 64)
        SHitDock.BackColor = Color.FromArgb(64, 64, 64)
        My.Settings.Appearance = 0
        My.Settings.Save()
    End Sub
End Module
#End Region

Public Class SHitSHell
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load settings.
        If My.Settings.Appearance = 0 Then
            ShareefDontLikeIt.SetDark()
        Else
            ShareefDontLikeIt.SetLight()
        End If

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = TimeString
        TextBox2.Text = DateString
    End Sub 'i think this is like the only not jank piece of code
End Class