using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;//utilização da biblioteca do banco de dados
//MySql

namespace empres_de_pintura
{
    public partial class Login : Form
    {
        public string tipo;
        public string codusu;
        public string senha;
        //Criando uma variável do tipo conexão para receber a conexão
        //com o banco de dados MySql
        MySqlConnection bdCon;
        public Login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            comboBox1.Text = ToString();
        }

        private void entrar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "123" && maskedTextBox1.Text == "123" && comboBox1.Text == "Gerente")
            {
                Gerente G = new Gerente();
                G.Show();
                this.ShowInTaskbar = false;
                this.Hide();
                this.textBox1.Text = "";
                this.maskedTextBox1.Text = "";
            }
            else if (textBox1.Text == "123" && maskedTextBox1.Text == "123" && comboBox1.Text == "Funcionário")
            {
                Funcionario F = new Funcionario();
                F.Show();
                this.ShowInTaskbar = false;
                this.Hide();
                this.textBox1.Text = "";
                this.maskedTextBox1.Text = "";
            }
            else {
                MessageBox.Show("invalido");
            }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string senha = maskedTextBox1.Text;
            maskedTextBox1.Text = senha.ToString();
        }

        private void loginfecha(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Deseja Realmente sair?");
            Application.Exit();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string cod = textBox1.Text;
            senha= maskedTextBox1.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
