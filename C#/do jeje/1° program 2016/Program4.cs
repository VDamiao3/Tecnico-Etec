using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorEMenor
{
    class Program
    {
        public static void Main(string[] args)
        {
            string c = "s";
            int maior = 0;
            int menor = 0;
            string nome ,sobrenome;
            int i;
            while (c!="N") {
                Console.Write ("Digite um número");
                int H = int.Parse(Console.ReadLine());
                
                if (H == menor) {
                menor = H;
                }
                
                else if (H < menor) {
                menor = H;
                }
                
                if (H > maior) {
                maior = H;
                
                }
                Console.WriteLine ("De novo? [S/N]");
                c = Console.ReadLine();
            
            }
            
            Console.WriteLine ("O maior valor digitado foi: "+maior+"\nE o menor valor digitado foi: "+menor);

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine("registrando usuário...");
            for (i = 0; i < 11; i++)
            {
                
                Console.Write("#");
                
                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine("\n Usuário Registrado...{0} {1}", nome, sobrenome); 
            



            Console.ReadKey();
        }
    }



        }
    
