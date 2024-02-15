using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// * passo 1: implementar as bibliotecas do banco de dados
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Sistema_Academia
{
    internal class Banco
    {
        // * passo 2: criar variaveis de conexao
        private static SQLiteConnection _connection;


        // * passo 3: criar um metodo para realizar a conexao com o banco e retornar a conexao
        private static SQLiteConnection ConexaoBanco()
        {
            // passo 3.1: instanciar uma conexao definindo o caminho para o arquivo aonde esta o banco de dados + '\\nome_do_banco_de_dados'
            _connection = new SQLiteConnection("Data Source = C:\\Users\\User\\Documents\\C#\\CSharp\\Projetos\\Sistema_Academia\\BancoDeDados\\Banco_Academia");
            
            // passo 3.2: abrir a conexao do banco de dados
            _connection.Open();

            // passo 3.3: retorna a conexao para o projeto
            return _connection;
        }

        // * passo 4: criar um metodo que vai obter os dados de todos os usuarios e retornar uma colecao do tipo 'DataTable' para o sistema
        public static DataTable ObterTodosUsuarios()
        {
            // passo 4.1: criar um SQLiteDataAdapter e um DataTable e definir como null
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                // passo 4.2: criar um comando a partir de um texto que sera rodado pelo banco de dados e retornara todos os usuarios
                var cmd = vcon.CreateCommand();
                // passo 4.2.1: cria a linha de comando para receber tudo da table
                cmd.CommandText = "SELECT * FROM tb_usuarios";

                // passo 4.2.2: (ponte) recebe todas as informacoes usando a linha de comando definida no cmd e da conexao com o banco de dados
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);

                // passo 4.2.3: armazena as informacoes retiradas do banco de dados
                dataAdapter.Fill(dataTable);

                // passo 4.2.4: fechar a conexao com o banco
                vcon.Close();

                // passo 4.2.5: retorna todos os usuarios
                return dataTable;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // * passo 5: criar um metodo para consulta no banco de dados que retorna uma DataTabel
        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();
                
                cmd.CommandText = sql;

                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);

                vcon.Close();

                return dataTable;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///////// Funcoes do FORM F_GestaoUsuarios

        public static DataTable ObterTodosUsuariosIdNome()
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário', T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
                // as '' substitiui o nome por outro definido. NAO SUBSTITUI O NOME NO BANCO DE DADOS E SIM AONDE ELE SERA UTILIZADO QUANDO ESTE METODO SERA CHAMADO

                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);

                dataAdapter.Fill(dataTable);

                vcon.Close();

                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarDadosUsuario(Usuario user)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();
                // criar um comando de texto SQL para alterar (UPDATE) os valores (SET) na table 'tb_usuarios' ONDE (WHERE) id for igual ao informado, SEM O WHERE O UPDATE SERA REALIZADO EM TODAS AS ROWS DO BANCO DE DADOS
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO='"+user.nome+ "', T_USERNAME='"+user.username+ "', T_SENHAUSUARIO='"+user.senha+ "', T_STATUSUSUARIO='"+user.status+ "',  N_NIVELUSUARIO="+user.nivel+" WHERE N_IDUSUARIO="+user.id;

                // executar a Query
                cmd.ExecuteNonQuery();

                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO='"+id+"'";

                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);

                dataAdapter.Fill(dataTable);

                vcon.Close();

                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarUsuario(string ID)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();
                // criar um comando de texto SQL para DELETAR um usuario do banco de dados
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" + ID;

                // executar a Query
                cmd.ExecuteNonQuery();

                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// FIM - Funcoes do FORM F_GestaoUsuarios





        ///////// Funcoes do FORM F_NovoUsuario

        // * passo 6: inserir no banco de dados
        public static void NovoUsuario(Usuario user)
        {
            // passo 6.1: verificar a existencia de usernames repitidos
            // nao podem existir usernames repetidos
            if (ExisteUsername(user))
            {
                MessageBox.Show("Username já existe!");
                return;
            }

            // passo 6.2: realizar a insersao
            try
            {
                var vcon = ConexaoBanco();

                // passo 6.2.1: criar o comando de texto (query) para o banco de dados
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                
                // dessa forma eu consigo preencher os parametros (@___) com valores sem precisar ficar adicionando '+' na string
                cmd.Parameters.AddWithValue("@nome", user.nome);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@senha", user.senha);
                cmd.Parameters.AddWithValue("@status", user.status);
                cmd.Parameters.AddWithValue("@nivel", user.nivel);

                // passo 6.2.2: executar a query
                // uma nova row sera criada na tabela tb_usuarios no banco de dados
                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo Usuário Inserido");

                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao grava novo Usuário");
            }
        }

        /// FIM - Funcoes do FORM F_NovoUsuario
         
        ///////// ROTINAS GERAIS
        
        public static bool ExisteUsername(Usuario user)
        {
            bool res;
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            var vcon = ConexaoBanco();

            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+user.username+"'";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            vcon.Close();

            return res;
        }
    }
}
