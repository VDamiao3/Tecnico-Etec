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


namespace empres_de_pintura
{
    public partial class Login : Form
    {
        public string tipo;
        public string codusu;
        public string senha;
        private MySqlConnection con;
        private MySqlDataAdapter adp;
        private DataSet dtSet;
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


            if (textBox1.Text == "123" && textBox2.Text == "123" && comboBox1.Text == "Gerente")
            {
                Gerente G = new Gerente();
                G.Show();
                this.ShowInTaskbar = false;
                this.Hide();
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
            else { MessageBox.Show("invalido"); }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string codusu = textBox1.Text;
            textBox1.Text = codusu.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string senha = textBox2.Text;
            textBox2.Text = senha.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginfecha(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
