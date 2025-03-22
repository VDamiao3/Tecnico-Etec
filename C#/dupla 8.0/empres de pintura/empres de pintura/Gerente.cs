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
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadFunci C = new CadFunci();
            C.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        
        }

        private void Gerente_Load(object sender, EventArgs e)
        {
            
        }

        private void gerentesair(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Deseja Realmente sair?");
            Application.Exit();
        }

        private void Deslogar_Click(object sender, EventArgs e)
        {
            /*
            Autentificação.Logout();

            */
            Login L = new Login();
            L.Show();
            this.ShowInTaskbar = false;
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadCliente C = new CadCliente();
            C.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Servicos S =new Servicos();
            S.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void RemCli_Click(object sender, EventArgs e)
        {

        }
    }
}
