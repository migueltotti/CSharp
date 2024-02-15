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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIdNome();

            dgv_usuarios.Columns[0].Width = 90;
            dgv_usuarios.Columns[1].Width = 245;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            // esse evento precisa de um tratamento para n ocorrer erros com tabelas carregadas sem nenhuma informacao
            // para isso basta receber a quantidade de rows selecionadas a partir do sender

            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                // obtendo o valor da primeira celula (coluna) da primeira row selecionada - obtendo o ID
                // como multselect esta desativado, a primeira row selecionada (com indice 0) sempre sera a selecionada pelo usuario
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dataTable = new DataTable();

                dataTable = Banco.ObterDadosUsuario(vid);

                // Rows[0] indica a primeira row da table retornada, como buscamos uma row pelo id e ele n pode ser repetido, a primeira row da table retornada sempre sera a certa
                tb_id.Text = dataTable.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dataTable.Rows[0].Field<string>("T_NOMEUSUARIO");
                tb_username.Text = dataTable.Rows[0].Field<string>("T_USERNAME");
                tb_senha.Text = dataTable.Rows[0].Field<string>("T_SENHAUSUARIO");
                cb_status.Text = dataTable.Rows[0].Field<string>("T_STATUSUSUARIO");
                n_nivel.Value = dataTable.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
           
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();

            f_NovoUsuario.ShowDialog();

            // REFRESH
            RefreshDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // REFRESH
            RefreshDGV();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            int linha = dgv_usuarios.SelectedRows[0].Index;

            user.id = int.Parse(tb_id.Text);
            user.nome= tb_nome.Text;
            user.username = tb_username.Text;
            user.senha = tb_senha.Text;
            user.status = cb_status.Text;
            user.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));

            Banco.AtualizarDadosUsuario(user);

            // quando o user for salvo e der o refresh a linha marcada sera a alterada
            //RefreshDGV();
            // CurrentCell eh a linha selecionada
            //dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];

            // para evitar carregar novamente todos os usuarios (caso sejam muitos) podemos apenas mudar os valores na exibicao
            dgv_usuarios[1, linha].Value = tb_nome.Text;

        }

        private void RefreshDGV()
        {
            dgv_usuarios.DataSource = Banco.ObterTodosUsuariosIdNome();

            dgv_usuarios.Columns[0].Width = 90;
            dgv_usuarios.Columns[1].Width = 245;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            // cria uma caixa de mensagem para confirmar a exclusao ou nao utilizando botoes YES - NO
            DialogResult res = MessageBox.Show("Confirma exclusao?", "Excluir?", MessageBoxButtons.YesNo);

            // faz a verificacao de qual botao foi precionado
            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
            }

            // para atualizar os dados do data grid view podemos recarregar os dados ou simplismente deletar a linha

            //RefreshDGV();

            dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
        }
    }
}
