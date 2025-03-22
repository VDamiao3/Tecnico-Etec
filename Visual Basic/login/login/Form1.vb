Imports System.Data.OleDb
Public Class Form1
    Dim ConString As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath & "\acesso.accdb"
    ''conexao com o banco tipo local tudo isso em uma variavel string 
    Dim DBCon As New OleDb.OleDbConnection(ConString)
    Dim IConta As Integer '' var ver virificacao de tentativas 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g_login As String
        g_login = TextBox1.Text

        Dim strSenha As String = TextBox2.Text

        If g_login = "" Or strSenha = "" Then

            MessageBox.Show("Informação Incompleta preencha os campos com o nome do usuario e senha", "informacao incompleta")
            TextBox1.Focus()
            Return
            ''focus ira seleciona o obejeto pra preencher novamente 
        End If

        Dim strsql As String = "SELECT * FROM Usuarios Where Usuario='" & g_login & "'"
        '' criando a variavel sring com o texto de comando para busca em sql 

        Dim cm As New OleDb.OleDbCommand(strsql, DBCon) '' executa o comando, e procura no banco
        Dim dr As OleDb.OleDbDataReader '' guarda o valor e retorna o que procurou  no access
        Dim Flag As Boolean = False

        Try '' abre a conexão
            DBCon.Open()
            '' executa um comando e gera um datadeader(dr)
            dr = cm.ExecuteReader
            '' se houver dados retornados/encontrados
            If dr.HasRows Then
                ''pecorre o datareader
                While dr.Read
                    ''Se a senha informada for igual a senha do banco de dados define variável
                    '' FLAG como TRUE
                    If (dr.Item("Senha") = strSenha) And (dr.Item("Usuario") = g_login) Then
                        '' if vai verificar se senha e login estao corretos
                        Flag = True
                    End If

                End While
            End If



            If Flag = True Then
                MessageBox.Show("Acesso Permitido")
            Else
                MessageBox.Show("Dados Incorretos")

            End If
            If IConta = 3 Then
                MessageBox.Show("Limite das tentativas alcançadas")
                End
            End If

            '' fechar o datareader
            dr.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO genérico", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        DBCon.close()

    End Sub
End Class
