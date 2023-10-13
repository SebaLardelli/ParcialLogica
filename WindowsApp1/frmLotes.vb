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
End Class