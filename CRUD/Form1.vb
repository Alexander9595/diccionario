Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagre.Click
        ListBox1.Items.Add(TextBox1.Text & "   " & TextBox2.Text)
        TextBox2.Text = ""
        TextBox1.Text = ""




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnborra.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnactu.Click
        Dim dato As String = ListBox1.SelectedIndex
        Dim dato2 As String = ListBox1.SelectedIndex
        ListBox1.Items.RemoveAt(dato & dato2)
        ListBox1.Items.Insert(dato, TextBox1.Text)
        ListBox1.Items.Insert(dato2, TextBox2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
