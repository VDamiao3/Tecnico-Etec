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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Form principal;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDOC = new XmlDocument();
            xmlDOC.Load("XMLFile1.xml");
            XmlNodeList xmlist = xmlDOC.GetElementsByTagName("login");

            if ((textBox1.Text.Equals(xmlist[0]["usuario"].InnerText)) && (textBox2.Text.Equals(xmlist[0]["senha"].InnerText)))
            {
                Form2 F = new Form2();
                principal = this;
                F.Show();
                this.Hide();
                this.textBox1.Text = "";
                this.textBox2.Text = "";

            }
            else 
            {
                MessageBox.Show("Usario Invalido");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
