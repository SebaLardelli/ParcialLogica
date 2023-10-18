
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

        Dim Ruta As String = "C:\Users\Larde\Desktop\FACULTAD\Programacion IZO\Pesos.txt"

        If Not File.Exists(Ruta) Then
            Using escribirDatos As StreamWriter = File.CreateText(Ruta)
                escribirDatos.WriteLine(TextBox3.Text)
            End Using
        Else
            Using escribirDatos As New StreamWriter(Ruta, True)
                escribirDatos.WriteLine(TextBox3.Text)
            End Using
        End If

        Dim datoTabla As New DataTable()
        datoTabla.Columns.Add("Pesos")

        Using leerSecuencia As New StreamReader(Ruta)
            Dim linea As String
            linea = leerSecuencia.ReadLine()
            Do While linea IsNot Nothing
                datoTabla.Rows.Add(linea)
                linea = leerSecuencia.ReadLine()
            Loop
        End Using

        DataGridView1.DataSource = datoTabla
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Button3.PerformClick()
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.S) Then
            Button2.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Button3.PerformClick()
            e.Handled = True
        End If
    End Sub
End Class
