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

        }

        private void Gerente_Load(object sender, EventArgs e)
        {
            
        }

        private void gerentesair(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Deslogar_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.ShowInTaskbar = false;
            this.Hide();
            
        }
    }
}
