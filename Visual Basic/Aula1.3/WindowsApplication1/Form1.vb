Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 1 To 10
        '    ComboBox1.Items.Add(i)
        'Next
        Dim a As Integer
        While a < 10
            'a+=1 seria a++ ou
            a = a + 1
            ComboBox1.Items.Add(a)
        End While
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim num, result As Integer
        num = ComboBox1.Text
        ListBox1.Items.Clear()
        For i = 1 To 10
            result = num * i
            ListBox1.Items.Add(result)
        Next


    End Sub
End Class
