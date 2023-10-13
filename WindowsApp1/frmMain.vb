Public Class frmMain
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLotes.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCambio.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Parent = PictureBox1

    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply

    End Sub
End Class