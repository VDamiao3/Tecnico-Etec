using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_hospital
{
    class fila
    {
        
        public  paciente[] P = new paciente[10];
        public int i=0;
        public int menu=0;
        public int entrada=0;
        public int saida=0;
        public int emergencia=0;
        public int preferencia=0;
        public int  quantP=0;

        public void estanciar() {
            
            for (i = 0; i <= P.Length; i++)
            {
                P[i] = new paciente();
            }
        }

        public int incluir( int entrada)
        {
           
                P[this.entrada] = new paciente();
                 
                P[this.entrada].Nome = Console.ReadLine();
                return this.entrada = this.entrada + 1;
            
            
               
            
        }
       
public int excluir( int saida, int entrada , int i, paciente []P)
        {
            Console.WriteLine("exluir:");
            Console.WriteLine("0- "+ this.P[0].Nome);
            Console.WriteLine("1- "+this.P[1].Nome);
            Console.WriteLine("2- "+this.P[2].Nome);
            Console.WriteLine("3- "+this.P[3].Nome);
            Console.WriteLine("4- "+this.P[4].Nome);
            Console.WriteLine("5- "+this.P[5].Nome);
            Console.WriteLine("6- "+this.P[6].Nome);
            Console.WriteLine("7- "+this.P[7].Nome);
            Console.WriteLine("8- "+this.P[8].Nome);
            Console.WriteLine("9- "+this.P[9].Nome);

            this.saida = int.Parse(Console.ReadLine());
            for (this.i = this.saida; this.i < P.Length; this.i++)
            {
               this.P[this.i].Nome = this.P[this.i + 1].Nome;
            }


            return this.saida;
            return this.entrada;
            
            
        }

        internal void exibir(int entrada, int quantP, int i, paciente paciente)
        {
            throw new NotImplementedException();
        }

        public int atender(int entrada , int saida, paciente[]P,int quantP)
        {
            quantP = 0;
                for (this.saida = 0; i < this.entrada- 1; saida++)
                {
                    this.P[saida].Nome = this.P[saida + 1].Nome;
                }
            this.quantP = this.entrada - 1;
            return this.quantP;
                
            
            }

        public paciente exibir(int entrada, int quantP, int i, paciente[]P ) {

            for (i = 0; i <= this.quantP; i++)
            {
                Console.WriteLine( this.P[i].Nome);
               
            }
            
            return this. P[i];
                
            }

        public int emergencial(int emergencia,paciente[] P)
        {


            
                this.P[this.emergencia+1].Nome = this.P[this.emergencia].Nome;
                
                this.P[this.emergencia].Nome = Console.ReadLine();
                this.emergencia++;

            
            
            return this.emergencia;
            
        }

        public int preferencial(int emergencia, int preferencia, paciente []P)
        {
            
            this.preferencia = this.emergencia+1;
            
                this.P[preferencia+1].Nome = P[preferencia].Nome;
                this.P[this.preferencia].Nome = Console.ReadLine();
                this.preferencia++;


            return preferencia;
        }


      




    }
}
