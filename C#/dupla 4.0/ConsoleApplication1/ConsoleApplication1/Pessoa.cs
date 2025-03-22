using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Pessoa
    {

        private string nome;
        private int[] cpf = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int []telefone= new int[12] {0,1,2,3,4,5,6,7,8,9,10,11 };
        public string endereco;
        public DateTime datanasc;



        public string Nome
        {
            get { return nome = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower()); }

            set { nome = value; }
        }
        public int CPF {
            get { return cpf[10];  }
            set {
              
                for (cpf[10] = cpf[0];cpf[10]<=11;cpf[0]++)
                {
                    Console.ReadLine();
                }
            }
        }

        public int Telefone
        {
            get { return telefone[12]; }
            set {
                telefone[0] = int.Parse(Console.ReadLine());
                telefone[1] = int.Parse(Console.ReadLine());
                telefone[2] = int.Parse(Console.ReadLine());
                telefone[3] = int.Parse(Console.ReadLine());
                telefone[4] = int.Parse(Console.ReadLine());
                telefone[5] = int.Parse(Console.ReadLine());
                telefone[6] = int.Parse(Console.ReadLine());
                telefone[7] = int.Parse(Console.ReadLine());
                telefone[8] = int.Parse(Console.ReadLine());
                telefone[9] = int.Parse(Console.ReadLine());
                telefone[10] = int.Parse(Console.ReadLine());
                telefone[11] = int.Parse(Console.ReadLine());
            }
        }
    
        
        }
    }

