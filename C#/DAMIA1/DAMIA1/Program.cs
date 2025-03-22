using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMIA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //V.Damião 2º mod informatica
            int valor1, valor2, result, laço = 0, laço1 = 1;
            string fecha;
            while (laço != laço1)
            {
                Console.WriteLine("DIgite um numero");
                valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro numero");
                valor2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n 1 para somar\n 2 para subitrair\n 3 para multiplicar \n 4 para dividir");
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                { Console.WriteLine("ERRO"); }
                result = int.Parse(Console.ReadLine());
                switch(result)
                {
                    case 1:
                        result=valor1+valor2;
                        Console.WriteLine("o valor é "+ result);
                        break;
                    case 2:
                        result=valor1-valor2;
                         Console.WriteLine("o valor é "+ result);
                        break;
                    case 3 :
                        result=valor1*valor2;
                         Console.WriteLine("o valor é "+ result);
                        break;
                    case 4:
                        if(valor2==0)
                        {

                         Console.WriteLine("zero não é um numero divisível");
                        break;
                        }
                            
                        else
                        {
                         result=valor1/valor2;
                            Console.WriteLine("o valor é "+ result);
                            break;

                        }
                    
                         default :
                             Console.WriteLine("Invalido");
                            break;  
                         
                }
                Console.WriteLine(" deseja continuar s/q");
                fecha = Console.ReadLine();
                if (fecha == "q")
                {
                    laço = 1;
                }

            }
        }
    }
}
