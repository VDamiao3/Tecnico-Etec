Public Class Form1
    Dim a, b, c, d, media As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        If Not IsNumeric(TextBox1.Text)  Then
            MessageBox.Show("Digite apenas numeros")
            Exit Sub

        End If
        If Not IsNumeric(TextBox2.Text) Then
            MessageBox.Show("Digite apenas numeros")
            Exit Sub

        End If

        If Not IsNumeric(TextBox3.Text) Then
            MessageBox.Show("Digite apenas numeros")
            Exit Sub

        End If

        If Not IsNumeric(TextBox4.Text) Then
            MessageBox.Show("Digite apenas numeros")
            Exit Sub

        End If


        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text


        If a < 0 Or a > 10 Then
            MessageBox.Show("digite um numero entre 0 e 10")
            Exit Sub
        End If
        If b < 0 Or b > 10 Then
            MessageBox.Show("digite um numero entre 0 e 10")
            Exit Sub
        End If
        If c < 0 Or c > 10 Then
            MessageBox.Show("digite um numero entre 0 e 10")
            Exit Sub
        End If
        If d < 0 Or d > 10 Then
            MessageBox.Show("digite um numero entre 0 e 10")
            Exit Sub
        End If

        media = (a + b + c + d) / 4

        result.Text = media

        If media >= 7 Then
            MessageBox.Show("Este alundo foi aprovado")
        Else
            MessageBox.Show("Este aluno foi Reprovado")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        result.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
