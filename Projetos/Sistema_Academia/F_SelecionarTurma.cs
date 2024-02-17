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
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno formNovoAluno;

        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();

            formNovoAluno = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurma = String.Format(@"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horario',
                    tbp.T_NOMEPROFESSOR as 'Professor',
                    tbt.N_MAXALUNOS as 'Max. ALunos',
                    (   SELECT
                            count(N_IDALUNO)
                        FROM
                            tb_alunos as tba
                        WHERE
                            tba.N_IDTURMA = tbt.N_IDTURMA AND T_STATUS = 'A'
                    ) as 'Qtde. Alunos'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ");
            // podemos criar uma outraaaaa query select dentro de uma query

            dgv_turmas.DataSource = Banco.DQL(queryTurma);
        }

        private void dgv_turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdeAlunos = 0;

            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            if (qtdeAlunos >= maxAlunos)
            {
                MessageBox.Show("Nao ha vagas nesta turma!");
                return;
            }
            else
            {
                //formNovoAluno.tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                //formNovoAluno.tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();

                formNovoAluno.tb_turma.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                formNovoAluno.tb_turma.Tag = dgv.SelectedRows[0].Cells[0].Value.ToString();

                // mesma acao, formas diferentes

                Close();
            }
        }
    }
}
