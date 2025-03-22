using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, soma, valor;
            Console.WriteLine("digite o valor");
            valor = int.Parse(Console.ReadLine());
            soma = 0;
            
            while (valor > 0)
            {
                soma = valor + soma;
                valor = valor - 1;


                Console.WriteLine(soma);




            }
         

            Console.ReadKey();
                

















        }
    }
}
