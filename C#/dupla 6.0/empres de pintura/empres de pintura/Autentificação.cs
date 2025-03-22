using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empres_de_pintura
{
    static  class Autentificação
    {
        static string nome;
        static string senha;
        

        public static void login(string nome1, string senha1)
        {
            nome = nome1;
            senha = senha1;
            
        }

        public static void logout() {
            nome = null;
            senha = null;
        }
        public static String getUsuario()
        {
            return "Nome: " + nome + "\n Senha: "+senha;
        }
    }
}
