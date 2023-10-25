Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frmLotes
    Private Sub frmLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Parent = PictureBox1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) AndAlso IsNumeric(TextBox2.Text) Then
            TextBox3.Text = CDec(TextBox1.Text) * CDec(TextBox2.Text)
        Else MsgBox("Escriba Solo Números", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Button1.PerformClick()
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Button1.PerformClick()
            e.Handled = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class