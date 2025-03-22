using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Des;
namespace testedll
{
    class Program
    {
        static void Main(string[] args)
        {
          Funcionario F = new Funcionario();
          F.Datanasc = "1995/05/03";
          F.Nome = "ANDISON";
            F.Telefone="01010101";
            Console.WriteLine("seus dados estao corretos nasc {0} nome {1} tel {2} ", F.Datanasc, F.Nome, F.Telefone);
            Console.ReadKey();
 

        }
    }
}
