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

            int cont,cont2 ;
            bool primo;
            for(cont=100;cont>=2;cont--){
            cont2= cont -1;
            primo= true;
            while (cont2 > 1) { 
                if(cont%cont2==0){
                    cont2=1;
                    primo=false;

                }
            cont2=cont2-1;
          
            
          }
            if(primo==true){


                Console.WriteLine(cont);

            }



            
           
            }

            Console.ReadKey();











        }
    }
}
