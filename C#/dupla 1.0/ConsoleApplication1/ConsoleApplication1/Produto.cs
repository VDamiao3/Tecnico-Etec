using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produto
    {
        public string nome;
        public double preco;
        public string marca;
        public string tipo;


        public virtual Produto(string n, double p, string m, string t)
            : base(n, p, m, t)
        {



        }

        public override void imprimirDados()
        {
            Console.WriteLine(" nome: {0} preco: {1} marca: {2} tipo: {3}");
            this.nome; this.preco; this.marca; this.tipo;
            Console.ReadLine();
        }
        
    }
}
