using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academia
{
    internal class Usuario
    {
        // classe para receber informacoes dos novos usuarios e salvar no banco de dados

        public Int32 id;
        public string nome;
        public string username;
        public string senha;
        public string status;
        public Int32 nivel;
    }
}
