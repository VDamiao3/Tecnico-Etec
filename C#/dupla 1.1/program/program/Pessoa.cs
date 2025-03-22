using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Pessoa
    {
        public string nome;
        public string cpf;


        public void p(string Exibir)
        {
            Console.WriteLine(Exibir);
        }

        public virtual Pessoa(string n, string cpf)
            : base(n, cpf)
        { }
    }
}
