<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SHitDock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.InternetIcon = New System.Windows.Forms.PictureBox()
        Me.SettingsIcon = New System.Windows.Forms.PictureBox()
        Me.ExplorerIcon = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InternetIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExplorerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = Global.SHitSHell.My.Resources.Resources.imageres_101
        Me.PictureBox5.Location = New System.Drawing.Point(756, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Exit Session")
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.SHitSHell.My.Resources.Resources.imageres_165
        Me.PictureBox4.Location = New System.Drawing.Point(126, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Command Prompt")
        '
        'InternetIcon
        '
        Me.InternetIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InternetIcon.Image = Global.SHitSHell.My.Resources.Resources.shell32_16744
        Me.InternetIcon.Location = New System.Drawing.Point(88, 9)
        Me.InternetIcon.Name = "InternetIcon"
        Me.InternetIcon.Size = New System.Drawing.Size(32, 32)
        Me.InternetIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.InternetIcon.TabIndex = 3
        Me.InternetIcon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.InternetIcon, "Internet")
        '
        'SettingsIcon
        '
        Me.SettingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsIcon.Image = Global.SHitSHell.My.Resources.Resources.imageres_27
        Me.SettingsIcon.Location = New System.Drawing.Point(50, 9)
        Me.SettingsIcon.Name = "SettingsIcon"
        Me.SettingsIcon.Size = New System.Drawing.Size(32, 32)
        Me.SettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SettingsIcon.TabIndex = 2
        Me.SettingsIcon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SettingsIcon, "Settings/Control Panel")
        '
        'ExplorerIcon
        '
        Me.ExplorerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExplorerIcon.Image = Global.SHitSHell.My.Resources.Resources.imageres_1023
        Me.ExplorerIcon.Location = New System.Drawing.Point(12, 9)
        Me.ExplorerIcon.Name = "ExplorerIcon"
        Me.ExplorerIcon.Size = New System.Drawing.Size(32, 32)
        Me.ExplorerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ExplorerIcon.TabIndex = 1
        Me.ExplorerIcon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ExplorerIcon, "Windows Explorer")
        '
        'SHitDock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 50)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.InternetIcon)
        Me.Controls.Add(Me.SettingsIcon)
        Me.Controls.Add(Me.ExplorerIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SHitDock"
        Me.ShowInTaskbar = False
        Me.Text = " SHitDock"
        Me.TopMost = True
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InternetIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExplorerIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExplorerIcon As PictureBox
    Friend WithEvents SettingsIcon As PictureBox
    Friend WithEvents InternetIcon As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
