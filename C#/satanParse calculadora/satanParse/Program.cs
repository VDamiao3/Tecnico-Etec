using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satanParse
{
    class Program
    {

        // Elder Luiz, 2° modulo Info
        static void limpa()
        {

            Console.Clear();
        }


        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            double result = 0;
            string operador = "+";
            string check = "n";

            while (check != "q")
            {
                Console.WriteLine("digite que tipo de operação deseja fazer \n + \n - \n / \n *");
                operador = Console.ReadLine();
                limpa();
                try
                {
                    Console.WriteLine("digite um valor");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite outro valor");
                    b = int.Parse(Console.ReadLine());
                    switch (operador)
                    {
                        case "+":
                            result = a + b;
                            Console.WriteLine("O resultado é " + result);
                            break;
                        case "-":
                            result = a - b;
                            Console.WriteLine("O resultado é " + result);
                            break;
                        case "/":
                            if (b == 0)
                            {
                                Console.WriteLine("impossivel dividir por 0");
                                break;
                            }
                            else
                            {
                                result = a / b;
                                Console.WriteLine("O resultado é " + result);
                            }
                            break;
                        case "*":
                            result = a * b;
                            Console.WriteLine("O resultado é " + result);
                            break;

                        default: Console.WriteLine("operação invalida"); break;

                    }
                    

                }

                catch (Exception)
                {
                    Console.WriteLine("erro");
                    
                }


            }


        }
    }
}
