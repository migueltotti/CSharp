using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Academia
{
    internal class Globais
    {
        // todas as variaveis globais serao criadas dentro desta classe
        // as variaveis serao para armazenar as informacoes do usuario logado e outras coisas necessarias
        // elas podem ser acessadas e manipuladas por todo o programa 

        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        // niveis de acesso:
        // Basico: 1
        // Gerente: 2
        // MASTER: 3

        // Campos Banco de Dados tb_usuarios:
        /*
         N_IDUSUARIO
         T_NOMEUSUARIO
         T_USERNAME
         T_SENHAUSUARIO
         T_STATUSUSUARIO
         N_NIVELUSUARIO
        */

    }
}
