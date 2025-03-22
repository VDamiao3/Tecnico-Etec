Imports System.Data.OleDb

Public Class Form1


    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath & "\cadastro.accdb"
    ''conexao com o banco tipo local tudo isso em uma variavel string 
    Dim DBCon As New OleDb.OleDbConnection(ConString)
    Dim IConta As Integer '' var ver virificacao de tentativas
    Dim dr As OleDb.OleDbDataReader '' guarda o valor e retorna o que procurou  no access

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub consulta()
        Dim cod As String = TextBox10.Text
        Dim sql As String = "Select * from Cliente where codCliente=" + cod
        Dim cm As New OleDb.OleDbCommand(sql, DBCon)
        Try
            DBCon.Open()
            dr = cm.ExecuteReader
            EXIBIR()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CUIDADO MONSTRO",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

        End Try
    End Sub

    Private Sub EXIBIR()
        If dr.HasRows Then
            While dr.Read
                TextBox1.Text = dr.Item("NOME")
                TextBox2.Text = dr.Item("ENDERECO")
                TextBox3.Text = dr.Item("CIDADE")
                TextBox4.Text = dr.Item("BAIRRO")
                TextBox5.Text = dr.Item("ESTADO")
                TextBox6.Text = dr.Item("CEP")
                TextBox7.Text = dr.Item("TELEFONE")
                TextBox8.Text = dr.Item("EMAIL")
                TextBox9.Text = dr.Item("NASCIMENTO")
            End While
        Else
            warn.ShowDialog()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub atualiza()
        Me.DataGridView1.Rows.Clear() ''ASC ASCENDENTE (ALFABETICO)
        Dim sql As String = "select * from CLIENTE ORDER BY NOME ASC"
        Dim cm As New OleDb.OleDbCommand(sql, DBCon)
        DBCon.Open()
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Me.DataGridView1.Rows.Add(dr.Item("codCliente"), dr.Item("nome"), dr.Item("cidade"), dr.Item("email"), dr.Item("telefone"))

            End While
        End If
        DBCon.Close()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox10.Text) Then
            warn.ShowDialog()
            TextBox10.Focus()


        End If
        consulta()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualiza()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not IsNumeric(TextBox10.Text) Then
            MessageBox.Show("DIGITE UM CODIGO PARA CONSULTA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox10.Focus()
            Return
        End If
        Dim strsql As String
        strsql = "delete from CLIENTE where CODCLIENTE =" + TextBox10.Text + ";"
        Try
            Dim CM As New OleDbCommand(strsql, DBCon)
            If MessageBox.Show("confirmar exclusao?", "permissao para deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DBCon.Open()
                CM.ExecuteNonQuery()
                DBCon.Close()
                Form3.Label1.Text = "Excluido com sucesso"
                Form3.ShowDialog()
                atualiza()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Not IsNumeric(TextBox10.Text) Then
            warn.ShowDialog()
            TextBox1.Focus()
            Return
        End If
        Dim SQL As String
        SQL = "insert into CLIENTE (CODCLIENTE,NOME,ENDERECO,CIDADE,BAIRRO,ESTADO,CEP,TELEFONE,EMAIL,NASCIMENTO) VALUES          (@CODCLIENTE,@NOME,@ENDERECO,@CIDADE,@BAIRRO,@ESTADO,@CEP,@TELEFONE,@EMAIL,@NASCIMENTO)"
        Dim cm As New OleDbCommand(SQL, DBCon)
        cm.Parameters.AddWithValue("@CODCLIENTE", TextBox10.Text)
        cm.Parameters.AddWithValue("@NOME", TextBox1.Text)
        cm.Parameters.AddWithValue("@ENDERECO", TextBox2.Text)
        cm.Parameters.AddWithValue("@CIDADE", TextBox3.Text)
        cm.Parameters.AddWithValue("@BAIRRO", TextBox4.Text)
        cm.Parameters.AddWithValue("@ESTADO", TextBox5.Text)
        cm.Parameters.AddWithValue("@CEP", TextBox6.Text)
        cm.Parameters.AddWithValue("@TELEFONE", TextBox7.Text)
        cm.Parameters.AddWithValue("@EMAIL", TextBox8.Text)
        cm.Parameters.AddWithValue("NASCIMENTO", TextBox9.Text)

        Try
            DBCon.Open()
            cm.ExecuteNonQuery()
            DBCon.Close()
            Form2.Label1.Text = "QUE DELICIACARA CADASTROU COM SUCESSO"
            Form2.ShowDialog()
            atualiza() '' ATUALIZA O DATAGRID
            Button2.PerformClick()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "erro ao cadastrar !")

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AboutBox1.ShowDialog()

    End Sub
End Class
