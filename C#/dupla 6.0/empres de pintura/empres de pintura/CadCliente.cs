using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace empres_de_pintura
{
    public partial class CadCliente : Form
    {
        MySqlConnection bdCon;
        string opcao;
        public CadCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void CadCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Deseja Realmente sair?");
            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bdCon = new MySqlConnection("server=localhost;database=escola; uid=root; PASSWORD=vertrigo");
            MySqlCommand bdComan = bdCon.CreateCommand();

            try
            {
                bdCon.Open();
            }
            catch
            {
                MessageBox.Show("Conexão falhou");
            }

            bdComan.CommandText = "insert into aluno(AluNome) values('" + textBox1.Text + "')";
            bdComan.BeginExecuteNonQuery();
            MessageBox.Show("Cadastrado sucesso");

        }
    }
}
