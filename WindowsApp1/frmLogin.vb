Imports System.Diagnostics.Eventing.Reader
Public Class frmLogin
    Dim usuario As String
    Dim contraseña As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox2
        Label2.Parent = PictureBox2
        Label3.Parent = PictureBox2
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario = TextBox1.Text
        contraseña = TextBox2.Text
        If usuario = "izo" And contraseña = "izo" Then
            frmMain.Show()
            Me.Close()
        Else MsgBox("Contraseña o Usuario incorrecto, vuelva a intentar.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

End Class
