using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_Academia
{
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = ""; //verificar se houve alteracao na turma 
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'Aluno'
                FROM
                    tb_alunos
            ";

            dgv_alunos.DataSource = Banco.DQL(vqueryDGV);
            dgv_alunos.Columns[0].Width = 50;
            dgv_alunos.Columns[1].Width = 180;

            if (dgv_alunos.Rows.Count > 0)
            {


                tb_nome.Text = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[1].Value.ToString();

                // Popular ComboBox Turmas - Query Especial

                // || = operador de CONCATENACAO no SQLite
                // - = operador de subtracao
                string queryTurmas = @"
                    SELECT
                        tbt.N_IDTURMA,
                        ('Vagas: '|| (
                                        (tbt.N_MAXALUNOS)-(
                                                        SELECT  
                                                            count(tba.N_IDALUNO)
                                                        FROM
                                                            tb_alunos as tba
                                                        WHERE
                                                            tba.T_STATUS = 'A' AND tba.N_IDTURMA = tbt.N_IDTURMA
                                                      )
                                     ) || ' / Turma: ' || T_DSCTURMA
                        ) as 'Turma'
                    FROM
                        tb_turmas as tbt
                    ORDER BY
                        tbt.N_IDTURMA
                ";
                // (Vagas: max_alunos - alunos_na_turma / Turma: nome_turma)

                cb_turmas.Items.Clear();
                cb_turmas.DataSource = Banco.DQL(queryTurmas);
                cb_turmas.DisplayMember = "Turma";
                cb_turmas.ValueMember = "N_IDTURMA";

                // Populando ComboBox Status (A-Ativo, B-Bloqueado, C-Cancelado)

                Dictionary<string, string> st = new Dictionary<string, string>();

                st.Add("A", "Ativo");
                st.Add("B", "Bloqueado");
                st.Add("C", "Cancelado");

                cb_status.Items.Clear();
                cb_status.DataSource = new BindingSource(st, null);
                cb_status.DisplayMember = "Value";
                cb_status.ValueMember = "Key";

                turma = cb_turmas.Text;
                turmaAtual = cb_turmas.Text;
                idSelecionado = dgv_alunos.Rows[dgv_alunos.SelectedRows[0].Index].Cells[0].Value.ToString();
            }
        }

        private void btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            turma = cb_turmas.Text;
            if (turmaAtual != turma) // turma do aluno foi alterada
            {
                // pegar a informacao do numero de alunos naquela turma
                // dividir o texto aonde tiver espacos 
                string[] t = turma.Split(' ');

                // como o cb_turmas eh sempre padronizado, o array de indice 1 gerado apos o split sempre sera o numero de vagas
                int vagas = int.Parse(t[1]);
                if(vagas < 1)
                {
                    MessageBox.Show("Nao ha vagas na turma selecionada, selecione outra turma!");
                    cb_turmas.Focus();
                    return;
                }

                linha = dgv_alunos.SelectedRows[0].Index;
                string queryAtualizarAluno = String.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOMEALUNO = '{0}',
                        T_TELEFONE = '{1}',
                        T_STATUS = '{2}',
                        N_IDTURMA = {3}
                    WHERE
                        N_IDALUNO = {4}
                ", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, idSelecionado);

                Banco.DML(queryAtualizarAluno);
                dgv_alunos[1, linha].Value = tb_nome.Text;

                string queryTurmas = @"
                SELECT
                    tbt.N_IDTURMA,
                    ('Vagas: '|| (
                                    (tbt.N_MAXALUNOS)-(
                                                    SELECT  
                                                        count(tba.N_IDALUNO)
                                                    FROM
                                                        tb_alunos as tba
                                                    WHERE
                                                        tba.T_STATUS = 'A' AND tba.N_IDTURMA = tbt.N_IDTURMA
                                                  )
                                 ) || ' / Turma: ' || T_DSCTURMA
                    ) as 'Turma'
                FROM
                    tb_turmas as tbt
                ORDER BY
                    tbt.N_IDTURMA
            ";
                // (Vagas: max_alunos - alunos_na_turma / Turma: nome_turma)

                cb_turmas.Items.Clear();
                cb_turmas.DataSource = Banco.DQL(queryTurmas);
                cb_turmas.DisplayMember = "Turma";
                cb_turmas.ValueMember = "N_IDTURMA";

                MessageBox.Show("Alteracoes Salvas!");
            }
        }

        private void btn_excluirAluno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Exclusao?", "Exclusao?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // faz a verificacao se o aluno possue foto ou nao
                if (File.Exists(pb_foto.ImageLocation)) // verifica se o picturebox contem o caminho da foto
                {
                    File.Delete(pb_foto.ImageLocation);
                }


                string vqueryExcluirAluno = String.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO = {0}
                ", idSelecionado);
                Banco.DML(vqueryExcluirAluno);
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.SelectedRows.Count > 0)
            {
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                //tb_nome.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                string vqueryCampos = String.Format(@"
                    SELECT 
                        *
                    FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO = {0}
                ", idSelecionado);

                DataTable dt = Banco.DQL(vqueryCampos);

                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_turmas.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");

                // vamos pegar os dados do CAMINHO da foto armazenado dentro do banco de dados e ai sim acessar e mostrar a foto
                pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");

                // sempre que um aluno for selecionado a variavel turmaAtual sera preenchida e depois utilizada para verificar se a turma foi alterada ou nao
                turmaAtual = cb_turmas.Text;
            }
        }

        private void btn_imprimirCarteirinha_Click(object sender, EventArgs e)
        {

        }
    }
}
