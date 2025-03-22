using System;

namespace _1__program_2016
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome;
            int a, b, c;
            Console.WriteLine(" Boa morte! \n digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Bem vindo " + nome + " ! >:c ");
            Console.WriteLine("\ndigite um valor para a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor de b");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("o resultado é  "+ c);
     




            Console.ReadKey();
            


        }
    }
}
