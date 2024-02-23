using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// implementar a biblioteca para manipular arquivos
using System.IO;

namespace Sistema_Academia
{
    public partial class F_NovoAluno : Form
    {
        // criacao de strings para armazenar as informacoes do arquivo da foto
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminho_Fotos;
        string destinoCompleto = "";
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
            // no banco de dados vamos inserir o caminho da foto em um campo texto e a partir disso vamos conseguir acessar a foto do usuario de qualquer parte do programa


            // realizar a gravacao do arquivo da foto na pasta do Systema
            if (destinoCompleto == "")
            {
                if(MessageBox.Show("Nenhuma foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            if(destinoCompleto != "")
            {
                // vai criar uma copia do arquivo selecionado para dentro da pasta Fotos do systema, caso ja exista o mesmo arquivo dentro da pasta ele vai apenas sobrepor o arquivo antigo
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);

                if (File.Exists(destinoCompleto))
                {
                    // o arquivo foi copiado
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if(MessageBox.Show("Erro ao localizar o arquivo, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        // caso a foto n seja encontrada e o usuario digitar que nao quer continuar a rotina de gravacao para
                        return;
                    }
                }
            }


            //// GRAVACAO DOS DADOS DENTRO DO BANCO DE DADOS - nome - telefone - status - id_turma - foto


            string queryInsertAluno = String.Format(@"
                INSERT INTO
                    tb_alunos (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_FOTO)
                VALUES
                    ('{0}', '{1}', '{2}', {3}, '{4}')", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, tb_turma.Tag.ToString(), destinoCompleto);

            Banco.DML(queryInsertAluno);

            MessageBox.Show("Novo Aluno Inserido!");

            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            cb_status.SelectedIndex = 0;
            btn_novo.Enabled = true;
            btn_gravar.Enabled = false;
            btn_cancelar.Enabled = false;
            pb_foto.ImageLocation = destinoCompleto;

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

        private void btn_addFoto_Click(object sender, EventArgs e)
        {
            // quando o aluno inserir a foto ela sera armazenada em uma pasta do proprio sistema, para isso precisamos pegar as informacoes como sera feito abaixo

            // utilizacao de strings globais desse forms para armazenar as informacoes do arquivo da foto
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminho_Fotos;
            destinoCompleto = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName; // retorna o caminho completo do arquivo da foto
                foto = openFileDialog1.SafeFileName; // retorna apenas o nome do arquivo
                destinoCompleto = pastaDestino + foto;
            }

            // fazer uma verificacao se o arquivo de foto daquele aluno ja existe na pasta de Fotos do sistema
            if(File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo ja existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            // a imagem ainda nao foi copiada para dentro da pasta Fotos do systema
            // ent o caminho da foto eh o original da pasta aonde o usuario a escolheu
            pb_foto.ImageLocation = origemCompleto;
        }
    }
}
