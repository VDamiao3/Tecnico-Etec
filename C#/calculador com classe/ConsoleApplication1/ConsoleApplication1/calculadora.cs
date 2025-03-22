using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class calculadora
    {
        public double result;
        public string fecha = "N";
        public double a, b;
        public double conta;


        public void escreva()
        {

            Console.WriteLine("O que gostaria de calcular? \n adiçao + \n subitraçao \n multiplicaçao * \n divisao / \n Q fechar ");
            fecha=Console.ReadLine();
        }

        public double soma()
        {
            fecha = "+";
            conta = a + b;
            Console.WriteLine(conta);
            return result;
        }

        public double subi()
        {
            fecha = "-";
            conta = a - b;
            Console.WriteLine(conta);
            return result;
        }

        public double multi()
        {
            fecha= "*";
            conta = a * b;
            Console.WriteLine(conta);
            return result;
        }

        public double divi()
        {


            if (b == 0)
            {
                Console.WriteLine("0 não é um numero divisivel");

            }
            if (a == 0)
            {
                Console.WriteLine("0 não é um numero divisivel");
            }
            else {
                fecha = "/";
                conta = a / b;
                Console.WriteLine(conta);
            }
            return result;



        }




        public double progr()
        {

            
             while (fecha != "Q")
            {
                Console.WriteLine("Digite o valor 1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2");
            b = double.Parse(Console.ReadLine());
                escreva();
            
             case "+":
                soma();
                break;

                case "-":
                subi();
                break;

                case "*":
                multi();
                break;

                case "/":
                divi();
                break;

                case "Q":
                fecha = "Q";

                default:
                Console.WriteLine("ERRO");
                break;
            }

            return result;
        }
            
           
        }

    }





       
           

              
    

    

