Public Class Form1
    'comentario
    Dim a, b, c As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btsoma_Click(sender As Object, e As EventArgs) Handles btsoma.Click
        If Not IsNumeric(num1.Text) Then
            MessageBox.Show("Digite  apenas numeros")
            Exit Sub

        End If
        If Not IsNumeric(num2.Text) Then
            MessageBox.Show("Digite  apenas numeros")
            Exit Sub

        End If


        a = num1.Text()
        b = num2.Text()
        c = a + b
        result.Text = c

    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        num1.Clear()
        num2.Clear()
        result.Text = ""
    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Me.Close()

    End Sub
End Class
