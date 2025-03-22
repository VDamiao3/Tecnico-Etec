using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_hospital
{
    class Program
    {
        public static int quantP { get; private set; }

        static void Main(string[] args)
        {
            paciente[] P = new paciente[10];
            string a = "b";
            int menu;
            int entrada = 0, saida = 0;
            int i=0;
            int emergencia = 0, preferencia=0;
           
            string sair = "?";
                while (a != "a")
                {
                try
                {

                    Console.Clear();
                    
                    fila F = new fila();
                    Console.WriteLine("\n 1-incluir \n 2-excluir \n 3-atender \n 4- exibir\n 5- emergencial \n 6- preferencial \n 7-sair");
                    menu = int.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case (1):
                            Console.Clear();
                            F.incluir(entrada);
                            break;

                        case (2):
                            Console.Clear();
                            F.excluir(saida, entrada, i, P);
                            break;

                        case (3):
                            Console.Clear();
                            F.atender(entrada, saida,P,quantP);
                            break;

                        case (4):
                            
                            Console.Clear();
                            F.exibir(entrada, quantP, i, P[entrada]);
                            break;

                        case (5):

                            Console.Clear();
                            F.emergencial(emergencia, P);
                            break;

                        case (6):

                            Console.Clear();
                            F.preferencial(emergencia,preferencia, P);
                            break;

                        case (7):
                            Console.Clear();
                            Console.WriteLine("deseja realmente sair? s/n");
                            sair = Console.ReadLine();
                            if (sair == "s")
                            {
                                Console.Clear();
                                a = "a";
                                Console.WriteLine("press enter");
                            }
                            if (sair == "n") { };
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalido");
                            break;

                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("NAO BUGA MEU PROGRAMA");
                }
        }
          
            Console.ReadKey();

        }

    }
}
    
