Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frmMain
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLotes.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCambio.Show()
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
    End Sub
End Class
