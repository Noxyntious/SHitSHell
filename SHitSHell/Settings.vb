﻿Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Dark" Then
            ShareefDontLikeIt.SetDark()
        End If
        If ComboBox1.Text = "Light" Then
            ShareefDontLikeIt.SetLight()
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Appearance = 0 Then
            ComboBox1.Text = "Dark"
        ElseIf My.Settings.Appearance = 1 Then
            ComboBox1.Text = "Light"
        End If
    End Sub
End Class