﻿Public Class Form1
    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        PictureBox1.Visible = False 'hide picture
        Label1.Text = CStr(Int(Rnd() * 10)) 'pick numbers
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        ' if any number is 7 display and beep
        If (Label1.Text = "7") Or (Label2.Text = "7") _
            Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class
