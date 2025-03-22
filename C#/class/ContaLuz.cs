using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ContaLuz
    {
        public string c;
        public string vencimento;
        public int kwh;
        public double valor;
        public string cliente;

        public double valormulta(double valor) 
        {
            double multa;
            multa = valor * 1.02;
            return Math.Round(multa, 2);

        }

    }
}
