using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   
             public +
             - private
             # protect 
             */

            Cliente ser = new Cliente();
            Console.WriteLine("Digite seu nome");

            Console.WriteLine("Digite seu cpf");
            ser.nome = Console.ReadLine();
            Console.WriteLine("Digite seu cpf");
            ser.cpf = Console.ReadLine();
            Console.WriteLine("Se for cadastro para cliente digite 1");
            int op = int.Parse(Console.ReadLine());

            if (op == 2)
            {
                Cliente cl = new Cliente();


                Console.WriteLine("Digite seu endereço :");
                cl.enderecoEntrega = Console.ReadLine();

                Compra C = new Compra();
                DateTime dataCompra = new DateTime(2016, 05, 04);

                Console.ReadLine();


                
                C.o("ID da compra");
                C.idCompra = Console.ReadLine();
                C.o("Data da compra");
                C.dataCompra = Console.ReadLine();
                int cliente = int.Parse(Console.ReadLine());

            }
        }
    }
}
