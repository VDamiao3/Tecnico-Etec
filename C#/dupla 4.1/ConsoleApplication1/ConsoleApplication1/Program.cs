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
            

            string loop = "a";
            int usu, cad;
            int Tentativa, confirm, chose;
            int i;
            int lerCod;
            gerente[] G = new gerente[10];
            string a;

            while (loop != "b") {
               

            Console.WriteLine(" 1- Gerente \n 2- Funcionario \n 3-Administrador \n 4-sair ");
            usu = int.Parse(Console.ReadLine());
            if (usu == 1)
            {
                Console.WriteLine("Digite seu Codigo para confirmação");
                    lerCod=int.Parse(Console.ReadLine());
                    for (i = 0; i < G.Length; i++)
                    {
                        if (G[i].codFunc == lerCod)
                        {
                            Console.WriteLine("Ola Gerente");
                        }
                    }
            }
            if (usu == 2)
            {
                Console.WriteLine("Digite seu Codigo para confirmação");
                    Console.ReadLine();
                    
            }
                if (usu == 3)
                {
                    for (Tentativa = 0; Tentativa <= 4; Tentativa++)
                    {

                        if (Tentativa == 4)
                        {
                            Console.WriteLine("Tentativa invasão detectada \n ");
                            Tentativa = 5;
                        }

                        if (Tentativa == 1 || Tentativa == 2 || Tentativa== 3)
                        {

                            Console.WriteLine("\n 1-sair \n 2-Senha");
                            chose = int.Parse(Console.ReadLine());

                            if (chose == 1) { loop = "b"; }

                            if (chose == 2)
                            {
                                Console.WriteLine("Senha:");
                                confirm = int.Parse(Console.ReadLine());

                                if (confirm == 123)
                                {
                                    Tentativa = 4;
                                    Console.WriteLine("Cadastrar Usuario \n ");
                                    Console.WriteLine("1-Gerente \n 2-Funcionario");
                                    cad = int.Parse(Console.ReadLine());
                                    if (cad == 1)
                                    {
                                        
                                       
                                           
                                            for (i = 0; i < i + 1;i++ )
                                            {
                                                Console.WriteLine("Preencha os dados do novo  gerente ");
                                                Console.WriteLine("Nome");
                                                G[i].Nome= Console.ReadLine();
                                                Console.WriteLine(G[i].CPF);
                                                Console.WriteLine("Digite seu endereço :");
                                                G[i].endereco = Console.ReadLine();
                                                Console.WriteLine("Digite a data de nascimento");
                                                DateTime dtnasc = new DateTime();
                                                dtnasc = DateTime.Now;
                                                Console.WriteLine("Codigo do Gerente");
                                                G[i].codFunc = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Cadastro concluido com Exido ");
                                            }
                                    }
                                    if (cad == 2) { }



                                }
                                if (confirm != 123) { Console.WriteLine("\n tente de novo \n"); }
                               }
                           }
                        }

                }
                if (usu == 4) { loop = "b"; }
               }
            Console.ReadKey();
        }
          
        }
    }

