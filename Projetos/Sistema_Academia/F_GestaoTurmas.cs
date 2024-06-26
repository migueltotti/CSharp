﻿using System;
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
            tb_vagas.Clear();
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

            // adicionando imagens no pdf
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo_PDF.jpg");
            logo.ScaleToFit(140F, 120F);
            logo.Alignment = Element.ALIGN_LEFT;
            //logo.SetAbsolutePosition(100F, 700F); // X, -Y -> Y de baixo para cima (0 eh bem la embaixo no documento)
            // podemos setar a posicao da imagem usando o Alignment ou SetAbsolutePosition

            // paragrafo 1

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));

            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Relatório de Turmas\n\n");

            // paragrafo 2

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));

            paragrafo2.Alignment = Element.ALIGN_LEFT;
            paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold);
            paragrafo2.Add("\nSistema de Gerenciamento de Academia - 1.0v");

            // Adicionando Tabelas no PDF

            PdfPTable tabela = new PdfPTable(3); // 3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            /*
            // podemos adicionar celulas na tabela e edita-las
            PdfPCell celula1 = new PdfPCell();
            celula1.Colspan = 3; // linha 1 mesclada
            ///celula1.Rotation = 90;
            celula1.AddElement(logo);
            tabela.AddCell(celula1);
            

            // ou apenas adicionar celular sem edicao, apenas com o nome
            // quando atingir o numero maximo de colunas, a proxima celula inserida sera numa proxima linha
            tabela.AddCell("Codigo");
            tabela.AddCell("Produto");
            tabela.AddCell("Preco");

            tabela.AddCell("01");
            tabela.AddCell("Mouse");
            tabela.AddCell("25,00");

            tabela.AddCell("02");
            tabela.AddCell("Teclado");
            tabela.AddCell("65,00");

            PdfPCell celula2 = new PdfPCell(new Phrase("tabela de precos"));
            //celula2.Phrase.Add("tabela de precos");
            celula2.Colspan = 3; // linha 1 mesclada
            celula2.Rotation = 0;
            celula2.FixedHeight = 40;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.AddCell(celula2);
            */
            
            // insersao simples das celulas na tabela, sem nenhuma edicao
            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            // preenchendo as tabelas a partir das tables retornadas pela query que presenche os dados do DGV
            DataTable dtTurmas = Banco.DQL(queryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horario"));
            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            // perguntar se o usuario quer abrir o PDF apos cria-lo
            DialogResult res = MessageBox.Show("Deseja abrir o PDF?", "Abrir PDF?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }
}
