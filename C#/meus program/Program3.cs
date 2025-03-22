using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont;
            int[]vetor=new int[10];
            i = 0;
            for (cont = 0; cont <= 9; cont++)
            {
                Console.WriteLine("preencha o vetor A{" + cont + "]");
                vetor[cont]= int.Parse(Console.ReadLine());
            }
            for (cont = 0; cont <= 9; cont++)
            {

                if (vetor[cont] > 15)
                {

                    i = i + 1;


                }


            }



                Console.WriteLine("tem"+i+"maiores que 15");
            Console.ReadKey();


        }
    }
}
