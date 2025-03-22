using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

  
    class Program
    {

      

        static void Main(string[] args)
        {
            
            //conta é a classe que criou 
            // C objeto
            //vencimento ou outro nome do atributo
            ContaLuz C; // contaluz é como se fosse declaração um tipo de var e C o nome da var que ira reservar o espaço
            C = new ContaLuz();// lendo e utilizando a class
            C.vencimento = "15/03/2016"; // conta recebendo o valor 
            C.kwh = 100;
            C.cliente = "JEJE ";
          
          
            Console.WriteLine(C.vencimento);//chamando para exibir
            // console é classe
            //writeline método
            //c.vencimento parametro
          
            //aplicando multa 
            Console.WriteLine(C.valormulta(C.valor));
            
        }
    }
}
