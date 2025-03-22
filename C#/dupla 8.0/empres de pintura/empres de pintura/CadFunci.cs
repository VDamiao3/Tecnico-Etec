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
    public partial class CadFunci : Form
    {
        string opcao;
        public CadFunci()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
                Gerente G = new Gerente();
                G.Show();
                this.ShowInTaskbar = false;
                this.Hide();
           
        }
    }
}
