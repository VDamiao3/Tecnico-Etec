Public Class GerarCodigo

    Public Radio As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        'Dim codigotxt As String = "select Campo from Tabela  order by Campo desc limit 1"
        'Dim codigo As Integer = Integer.Parse(codigotxt)
        'codigo = codigo + 1

        QrRecebe()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '' salvando foto

        Dim img As Image = DirectCast(QrCodeImgControl1.Image.Clone, Image)
        Dim sv As New SaveFileDialog
        sv.AddExtension = True
        sv.Filter = "Imagen JPG (*.jpg)|*.jpg"
        sv.ShowDialog()
        If Not String.IsNullOrEmpty(sv.FileName) Then
            img.Save(sv.FileName)
        End If
        img.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetDataObject(TextBox1.Text, True)
        MessageBox.Show("Copiado com sucesso")


    End Sub




    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ''& vbCrLf &
        QrRecebe()
    End Sub

    Private Sub GerarCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QrRecebe()
        QrCodeImgControl1.Text = "Código: " + TextBox2.Text + "  Nome: " + TextBox1.Text + "  Aluno: " + Radio

    End Sub

    Private Sub VerificaRadio()
        If RadioButton1.Checked = True Then
            Radio = "Sim"
            QrRecebe()
            Exit Sub

        ElseIf RadioButton2.Checked = True Then
            Radio = "Não"
            QrRecebe()
            Exit Sub
        End If

        Exit Sub
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        VerificaRadio()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        VerificaRadio()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class