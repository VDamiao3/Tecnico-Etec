using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication1
{
    class Program
    {
        private static string valor1;
        private static string valor2;

        static void Main(string[] args)
        {
            
            calculadora conta;
            conta = new calculadora();

            float result, x, y;
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            switch(operacao)
            {
                case (1):
                    result = conta.soma(x, y);
                    Console.WriteLine(result);
                    break;
                case (2):
                    result = conta.subi(x, y);
                    Console.WriteLine(result);
                    break;

                case (3):
                    result = conta.multi(x, y);
                    break;

                case (4):
                    result = conta.divi(x, y);
                    if (y == 0)
                    {
                        Console.WriteLine("0 não é um numero divisivel");
                    }
                    else {
                        Console.WriteLine(result);
                    }
                    break;
            }
            
            
    }
  }
}
        
    

