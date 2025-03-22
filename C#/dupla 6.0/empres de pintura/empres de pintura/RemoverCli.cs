using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//utilização da biblioteca do banco de dados
//MySql

namespace empres_de_pintura
{
    public partial class RemoverCli : Form
    {
        MySqlConnection bdCon;
        public RemoverCli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            bdComan.CommandText = "delete from aluno where AluCod = " + textBox1.Text;
            bdComan.BeginExecuteNonQuery();
            MessageBox.Show("Apagado sucesso");
        }
    }
    }

