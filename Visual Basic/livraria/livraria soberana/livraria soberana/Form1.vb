Imports System.Data.OleDb

Public Class Form1

    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath & "\livraria1.accdb"
    Dim DBcon As New OleDb.OleDbConnection(ConString)
    Dim Iconta As Integer
    Dim dr As OleDb.OleDbDataReader

   
    Private Sub EXIBIR()
        If dr.HasRows Then
            While dr.Read
                TextBox2.Text = dr.Item("Titulo")
                TextBox3.Text = dr.Item("Quantidade")
                TextBox4.Text = dr.Item("Paginas")
                TextBox5.Text = dr.Item("Autor")
                TextBox6.Text = dr.Item("Editora")


            End While
        Else

            TextBox1.Focus()
        End If
    End Sub

    Private Sub consulta()
        Dim cod As String = TextBox1.Text
        Dim sql As String = "Select * from Livros where CodLivro=" + TextBox1.Text
        Dim cm As New OleDb.OleDbCommand(sql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            EXIBIR()
            DBcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CUIDADO MONSTRO",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("DIGITE UM CODIGO PARA CONSULTA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return
        ElseIf Not IsNumeric(TextBox1.Text) Then
            TextBox1.Focus()
            MessageBox.Show("nao digite letras no codigo ")

            Return
        End If


        consulta()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("DIGITE UM CODIGO PARA CONSULTA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return
        End If
        Dim strsql As String
        strsql = "delete from Livros where CODLIVRO =" + TextBox1.Text + ";"
        Try
            Dim CM As New OleDbCommand(strsql, DBcon)
            If MessageBox.Show("confirmar exclusao?", "permissao para deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DBcon.Open()
                CM.ExecuteNonQuery()
                DBcon.Close()
                MessageBox.Show("Excluido com sucesso")

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox1.Focus()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        If (TextBox2.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA INCLUIR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox2.Focus()
            Return
        End If
        If (TextBox3.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA INCLUIR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox3.Focus()
            Return
        End If
        If (TextBox4.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA INCLUIR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox4.Focus()
            Return
        End If
        If (TextBox5.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA INCLUIR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox5.Focus()
            Return
        End If
        If (TextBox6.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA INCLUIR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox6.Focus()
            Return
        End If



        Dim SQL As String
        SQL = "insert into Livros (TITULO,QUANTIDADE,PAGINAS,AUTOR,EDITORA) VALUES (@TITULO,@QUANTIDADE,@PAGINAS,@AUTOR,@EDITORA)"
        Dim cm As New OleDbCommand(SQL, DBcon)

        cm.Parameters.AddWithValue("@TITULO", TextBox2.Text)
        cm.Parameters.AddWithValue("@QUANTIDADE", TextBox3.Text)
        cm.Parameters.AddWithValue("@PAGINAS", TextBox4.Text)
        cm.Parameters.AddWithValue("@AUTOR", TextBox5.Text)
        cm.Parameters.AddWithValue("@EDITORA", TextBox6.Text)


        Try
            DBcon.Open()
            cm.ExecuteNonQuery()
            DBcon.Close()
            MessageBox.Show("QUE DELICIACARA CADASTROU COM SUCESSO")

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox1.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "erro ao cadastrar !")

        End Try
    End Sub

   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

       


        If (TextBox2.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA ALTERAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return

        End If
        If (TextBox3.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA ALTERAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return

        End If
        If (TextBox4.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA ALTERAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return

        End If
        If (TextBox5.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA ALTERAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return

        End If
        If (TextBox6.Text = "") Then
            MessageBox.Show("PREENCHA TODOS OS CAMPOS PARA ALTERAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
            Return

        End If


        Dim SQL As String
        SQL = "update  Livros set TITULO=@TITULO,QUANTIDADE=@QUANTIDADE,PAGINAS=@PAGINAS,AUTOR=@AUTOR,EDITORA=@EDITORA Where CodLivro=@CodLivro"
        Dim cm As New OleDbCommand(SQL, DBcon)
        cm.Parameters.AddWithValue("@CodLivro", TextBox1.Text)
        cm.Parameters.AddWithValue("@TITULO", TextBox2.Text)
        cm.Parameters.AddWithValue("@QUANTIDADE", TextBox3.Text)
        cm.Parameters.AddWithValue("@PAGINAS", TextBox4.Text)
        cm.Parameters.AddWithValue("@AUTOR", TextBox5.Text)
        cm.Parameters.AddWithValue("@EDITORA", TextBox6.Text)


        Try
            DBcon.Open()
            cm.ExecuteNonQuery()
            DBcon.Close()
            MessageBox.Show("QUE DELICIA CARA ATUALIZO COM SUCESSO")

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox1.Focus()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "erro ao UPLOADAR MANIN !")

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
