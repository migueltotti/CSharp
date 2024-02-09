using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academia
{
    public partial class F_Login : Form
    {
        Form1 form1;
        // variavel para armazenar o datatable retornado dos metodos de pesquisa no banco de dados
        DataTable dataTable = new DataTable();

        public F_Login(Form1 f)
        {
            InitializeComponent();

            // fazer alteracoes, manipular elementos e receber informacoes do forms pai (Form1) pelo forms filho (F_Login)
            form1 = f;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuario e/ou senha invalidos!");
                tb_username.Focus();
                return;
            }

            // * acessar o banco de dados e verificar as credenciais para login

            // comando WHERE faz uma filtragem no banco de dados buscando apenas ROWS aonde o campo eh especificado
            // para passar strings como campos de filtragem no WHERE precisamos colocalos entre aspas simples ('')
            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"' AND T_SENHAUSUARIO='"+senha+"'";

            dataTable = Banco.Consulta(sql);

            // encontrou o username e a senha digitada
            // podemos criar uma verificacao mais profunda e ver se a senha e o username sao iguais mas n existe necessidade pq o banco de dados ja faz isso
            if (dataTable.Rows.Count == 1)
            {
                // alterar os dados de login na pagina principal (Forms1)

                // pegar as informacoes do dataTable que veio do banco de dados

                // podemos fazer de varias formas:
                // * 1: pegar as informacoes pelo indice da linha do banco de dados (1 a qtde_rows)
                // nesse caso o indice 5 indica a row de nivel de acesso
                form1.lb_acesso.Text = dataTable.Rows[0].ItemArray[5].ToString();

                // * 2: passando o tipo do 'campo' (row) da consulta e definir o nome da 'campo' (row)
                // nesse caso queremos acessar a row aonde o tipo eh 'string' e o nome eh 'T_NomeUsuario'
                form1.lb_nomeUsuario.Text = dataTable.Rows[0].Field<string>("T_NomeUsuario");

                // definir o led verde - logado
                form1.pb_ledLogado.Image = Properties.Resources.led_verde;


                // definir as variaveis globais
                Globais.nivel = int.Parse(dataTable.Rows[0].Field<Int64>("N_NivelUsuario").ToString());
                Globais.logado = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
                tb_username.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
