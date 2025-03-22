using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cliente
    {
        
        public string nome;
        public int cod;
        public string rg;
        public int cpf;
        public int telefone;
        public string datanasc;
        public int cep;
        public string cidade;
        public string bairro;
        public string sexo;
        public string pedido;
        public double valor;
        public string garantia;

        public string retorno() 
            //void NAO tem retorno 
            // variavel TEM retorno
        {
            return this.nome;
            return this.rg;
            return this.datanasc;
           
        }
        public int retro() 
        {
            return this.cpf ;
        }
        public void print(string y) {
            Console.WriteLine("seus dados estão corretos?");
            Console.WriteLine(y);
            Console.ReadKey();
           
        }




    }
}
