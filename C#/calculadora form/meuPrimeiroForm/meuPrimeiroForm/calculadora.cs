using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuPrimeiroForm
{
   
    public partial class calculadora : Form
    {
        
        public double a;
        public double b;
        public double c;
        public string operacoes;
        public calculadora()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void btmult_Click(object sender, EventArgs e)
        {
            operacoes = "*";
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operacoes = "/";
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "4";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);

            switch (operacoes)
            { 
                case("+"):
                    c = a + b;
                    textBox1.Text = c.ToString();
                    break;
                case("-"):
                    c = a - b;
                    textBox1.Text = c.ToString();
                    break;
                case("*"):
                    c = a * b;
                    textBox1.Text = c.ToString();
                    break;
                case("/"):
                    c = a / b;
                    if (b == 0)
                    {
                        MessageBox.Show(" 0 não é um numero divisivel");
                    }
                    else
                    {
                        textBox1.Text = c.ToString();
                    }
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
                    
            }
        }

        private void btzero_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            operacoes = "+";
            a = double.Parse(textBox1.Text);
            textBox1.Clear();


            
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            operacoes = "-";
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btpont_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ ".";
        }
   
}
    }
  



