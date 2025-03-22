using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class gerente:Pessoa
    {
        public int codFunc;
        public string CadasFunc;
        public double comicao;
        public string AltFunci;
        public string CadasCli;
        public string RemoCli;
        public string RemoFunci;
        public string CadasPedi;
        public double EfetPag;

        public void CadastFun() { }

        public double valueComi(double comicao) {
            return comicao;
        }
    }
}
