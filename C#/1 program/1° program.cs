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

            int a, b, c, d;
            a = 0;
            b = 0;
            d = 1;
            while (d <= 20)
            {
                Console.WriteLine("informe o valor");
                c = int.Parse(Console.ReadLine());
                c = c % 2;
                switch (c)
                {
                    case (1):
                        a++;
                        break;
                    case (0):
                        b++;
                        break;
                }
                d++;
            }
            Console.WriteLine("os calor que você digitou" + b + "foram par e " + a + "foram impar");
            Console.ReadKey();

        }
    }
}
        
        
        
        
        
        
        
        
        
        
        
