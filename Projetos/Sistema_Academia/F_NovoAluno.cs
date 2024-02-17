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
    public partial class F_NovoAluno : Form
    {
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> st = new Dictionary<string, string>();

            st.Add("A", "Ativo");
            st.Add("B", "Bloqueado");
            st.Add("C", "Cancelado");

            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            mtb_telefone.Enabled = true;
            cb_status.Enabled = true;
            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            tb_nome.Focus();
            btn_novo.Enabled = false;
            btn_gravar.Enabled = true;
            btn_cancelar.Enabled = true;
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_nome.Clear();
            mtb_telefone.Clear();
            tb_turma.Clear();
            cb_status.SelectedIndex = 0;
            btn_novo.Enabled = true;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string queryInsertAluno = String.Format(@"
                INSERT INTO
                    tb_alunos (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA)
                VALUES
                    ('{0}', '{1}', '{2}', {3})", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, tb_turma.Tag.ToString());

            Banco.DML(queryInsertAluno);
            MessageBox.Show("Novo Aluno Inserido!");

            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            cb_status.SelectedIndex = 0;
            btn_novo.Enabled = true;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_abrirTurmas_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma f_SelecionarTurma = new F_SelecionarTurma(this);

            f_SelecionarTurma.ShowDialog();
        }
    }
}
