Imports System.IO

Public Class frmCambio
    Private Sub frmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Parent = PictureBox1
        GroupBox2.Parent = PictureBox1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ReadOnly = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(TextBox1.Text) AndAlso IsNumeric(TextBox2.Text) Then
            TextBox3.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text)
        Else MsgBox("Escriba Solo Números", MsgBoxStyle.Exclamation, "Aviso")
        End If

        Dim filePath As String = "C:\Users\Larde\Desktop\FACULTAD\Programacion IZO\Pesos.txt"

        If Not File.Exists(filePath) Then
            Using sw As StreamWriter = File.CreateText(filePath)
                sw.WriteLine(TextBox3.Text)
            End Using
        Else
            Using sw As New StreamWriter(filePath, True)
                sw.WriteLine(TextBox3.Text)
            End Using
        End If

        Dim dt As New DataTable()
        dt.Columns.Add("Pesos")

        Using sr As New StreamReader(filePath)
            Dim line As String
            line = sr.ReadLine()
            Do While line IsNot Nothing
                dt.Rows.Add(line)
                line = sr.ReadLine()
            Loop
        End Using

        DataGridView1.DataSource = dt
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class
