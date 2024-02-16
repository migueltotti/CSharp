using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Sistema_Academia
{
    public partial class F_GestaoTurmas : Form
    {
        ///// Variaveis Globais

        string IdSelecionado = string.Empty;
        int modo = 0; // 0 - padrao, 1 - edicao, 2 - insercao
        string queryDGV = @"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horario'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
        ";

        //// Fim variaveis globais

        //////// METODOS
        

        private string CalculoVagas()
        {
            DataTable dt = new DataTable();

            string queryVagas = String.Format(@"
                    SELECT 
                        count (N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS = 'A' AND N_IDTURMA = {0}", IdSelecionado);

            dt = Banco.DQL(queryVagas);

            // vagas = numero maximo de alunos para a turma selecionada - quantidade de alunos ativos na turma
            int vagas = Int32.Parse(Math.Round(n_numAlunos.Value, 0).ToString()) - Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());

            return vagas.ToString();
        }


        //// Fim dos metodos

        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            dgv_turmas.DataSource = Banco.DQL(queryDGV);

            dgv_turmas.Columns[0].Width = 60;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 90;

            // Popular ComboBox Professores

            string queryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
            ";

            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.DQL(queryProfessores);

            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            // Popular ComboBox Status (Ativo=A, Paralisado=P, Cancelado=C)

            Dictionary<string, string> st = new Dictionary<string, string>();

            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");

            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);

            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            // Popular ComboBox Horarios

            string queryHorarios = @"
                SELECT
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";

            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.DQL(queryHorarios);

            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();

                modo = 0; // definir o modo de salvamento

                // vamos armazenar globalmente o Id sempre que uma linha do DGV for selecionada, podendo ser usado em outros metodos
                IdSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA = " + IdSelecionado;

                dt = Banco.DQL(vquery);

                // as informacoes selecionadas serao mostradas com relacao ao valor de cada item do combobox, nesse caso o Id do professor
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR");
                n_numAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");


                //// Calculo de vagas

                tb_vagas.Text = CalculoVagas();
            }
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1; // limpar 
            n_numAlunos.Value = 0;
            cb_status.SelectedIndex = -1; // limpar
            cb_horario.SelectedIndex = -1; // limpar
            tb_dscTurma.Focus();

            modo = 2; // definir modo de insersao
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (modo != 0) {
                string queryAtualizarTurma = String.Empty;
                if (modo == 1)
                {
                    // utilizar o SrintFormat() permite criarmos uma string e informarmos os paramentros {n} para depois substituir seus valores 
                    queryAtualizarTurma = String.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DSCTURMA = '{0}',
                        N_IDPROFESSOR = {1},
                        N_IDHORARIO = {2},
                        N_MAXALUNOS = {3},
                        T_STATUS = '{4}'
                    WHERE
                        N_IDTURMA = {5}", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_numAlunos.Value, 0).ToString()), cb_status.SelectedValue, IdSelecionado);
                }
                else
                {
                    queryAtualizarTurma = String.Format(@"
                        INSERT INTO
                            tb_turmas (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS)
                        VALUES
                            ('{0}', {1}, {2}, {3}, '{4}')", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_numAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                }

                // vamos pegar o indice da linha selecionada para nao precisar recarregar o DataGridView denovo usando uma query
                // apenas alterar a linha selecionada diretamente 
                int linha = dgv_turmas.SelectedRows[0].Index;                

                Banco.DML(queryAtualizarTurma);

                if( modo == 1)
                {
                    dgv_turmas[1, linha].Value = tb_dscTurma.Text;
                    dgv_turmas[2, linha].Value = cb_horario.Text;

                    tb_vagas.Text = CalculoVagas();
                }
                else
                {
                    dgv_turmas.DataSource = Banco.DQL(queryDGV);
                }

                MessageBox.Show("Dados Gravados!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusao?", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                    DELETE 
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA = {0}", IdSelecionado);

                Banco.DML(queryExcluirTurma);

                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_dscTurma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void n_numAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            string dados = "";

            // paragrafo 1

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));

            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Gerenciamento de Academia\n");

            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("Curso de C#\n");

            string txt = "Turmas";
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo1.Add(txt+"\n");

            // paragrafo 2

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));

            paragrafo2.Alignment = Element.ALIGN_LEFT;
            txt = "Texto do Segundo paragrafo";
            paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo2.Add(txt);

            doc.Open();
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Close();

        }
    }
}
