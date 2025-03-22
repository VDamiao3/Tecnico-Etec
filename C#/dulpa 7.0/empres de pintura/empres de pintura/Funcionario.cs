using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empres_de_pintura
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void funcionariofecha(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Deseja Realmente sair?");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadCliente C= new CadCliente ();
            C.Show();
            ShowInTaskbar = false;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servicos S =new Servicos();
            S.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }
    }
}
