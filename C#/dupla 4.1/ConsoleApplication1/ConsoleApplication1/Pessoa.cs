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
        private int telefone;
        public string endereco;
        public DateTime datanasc;
        public int i;




        public string Nome
        {
            get { return nome = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower()); }

            set { nome = value; }
        }
        public int CPF
        {
            get
            {
                
                Console.WriteLine("Digite o cpf (Digite numero por numero)");
                for (i = 0; i <cpf.Length; i++)
                {
                    cpf[i] = int.Parse(Console.ReadLine());
                  
                }
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}/{9}{10}", cpf[0],cpf[1],cpf[2],cpf[3],cpf[4],cpf[5],cpf[6],cpf[7],cpf[8],cpf[9],cpf[10] );
            
                return cpf[0];
                return cpf[1];
                return cpf[2];
                return cpf[3];
                return cpf[4];
                return cpf[5];
                return cpf[6];
                return cpf[7];
                return cpf[8];
                return cpf[9];
                return cpf[10];

            }
            set
            {
                cpf[0] = value;
                cpf[1] = value;
                cpf[2] = value;
                cpf[3] = value;
                cpf[4] = value;
                cpf[5] = value;
                cpf[6] = value;
                cpf[7] = value;
                cpf[8] = value;
                cpf[9] = value;
                cpf[10] = value;
            }
        }

        public int Telefone
        {
            get {
                Console.WriteLine("Digite o telefone celular + DDD ");
                
                    telefone = int.Parse(Console.ReadLine());
                        Console.WriteLine(telefone);
                    
                      return telefone;
            }
             set{ telefone= value;}
            }
        
    
        
        }
    }

