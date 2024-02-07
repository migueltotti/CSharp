using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // biblioteca para mecher com arquivos

namespace Editor_de_Texto
{
    // Funcoes principais:
    //  * barra de menu - barra de ferramentas - area de edicao de texto
    // outros elementos sao acessorios

    // para evitar implementacoes repetidas, criaremos metodos e assim implementamos apenas o metodo em cada evento do menu ou do toolstrip

    public partial class F_Principal : Form
    {

        StringReader leitura = null;
        // elemento para leitura do arquivo de texto

        bool FormularioFechado = false;

        enum TipoAcao
        {
            NovoArquivo,
            Abrir,
            Sair,
        }
 
        public F_Principal()
        {
            InitializeComponent();
        }

        private void NovoArquivo()
        {
            VerificaAcaoArquivo(TipoAcao.NovoArquivo.ToString(), Properties.Resources.Alerta_Abrir);
        }

        private void SalvarArquivo()
        {
            // Precisamos chamar a caixa de dialogo saveFileDialog
            try
            {
                // caso o retorno da caixa de dialogo de salvar seja OK, um arquivo sera gerado com o conteudo de RichTextBox
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // podemos tbm filtrar as opcoes de formatacao de arquivos que seram mostradas na caixa de dialogo de salvar utilizando o filter na programacao ou na parte grafica

                    // criar um arquivo: precisamos 'nome_arquivo', 'modo_do_arquivo', 'modo_de_acesso'
                    // Criacao do arquivo que vai salvar o conteudo

                    FileStream Arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Arq_streamWriter = new StreamWriter(Arquivo);
                    
                    // Limpei o Buffer para receber o conteudo
                    Arq_streamWriter.Flush();

                    // Informeu ao meu escrevedor a partir de onde ele vai comecar a gravar 
                    Arq_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    
                    // Informa ao meu escrevedor oq ele vai escrever dentro do arquivo
                    Arq_streamWriter.Write(this.richTextBox1.Text);

                    // sempre limpar o buffer antes e apos escrever
                    Arq_streamWriter.Flush();

                    // a partir do fechar ele salvara o arquivo
                    Arq_streamWriter.Close();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro na gravacao: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abrir()
        {
            // todas essas alteracoes podem ser feitas pela janela grafica do programa

            // setar que a caixa de dialogo de abrir o arquivo possa selecionar apenas 1 arquivo
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir Arquivo";

            // define o diretorio inicial que mostrara quando a caixa de dialogo de abertura de arquivos for acionada
            // o arroba serve para evitar problemas com caracteres especiais
            openFileDialog1.InitialDirectory = @"C:\\Users\\User\\Documents\\C#\\CSharp\\Projetos\\Editor de Texto";

            // filtrar as opcoes de mostrar arquivos apenas para formatos '.txt'
            // "Todos Arquivos(*.*)|*.*" indica que todos os arquivos apareceram independendte da formatacao
            //openFileDialog1.Filter = "(*.TXT)|*.TXT";
            openFileDialog1.Filter = "(*.MI)|*.MI|(*.TXT)|*.TXT"; // permite tbm filtrar por formatacoes especificas criadas por mim mesmo

            // verificacao se deu tudo certo, se o retorno eh OK
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // criar um FileStream que vai receber o arquivo que deseja ser aberto
                    FileStream Arquivo = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                    // criar um lededor que vai receber o conteudo do arquivo desejado
                    StreamReader arq_streamReader = new StreamReader(Arquivo);

                    // Informeu ao meu lededor a partir de onde ele vai comecar a gravar 
                    arq_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                    // vai limpar o componente de texto para entrada do conteudo do arquivo a ser aberto
                    this.richTextBox1.Clear();

                    // uma string fara a leitura de CADA LINHA do arquivo a ser aberto e vai concatenando as linhas no componente de texto desejado
                    string line = arq_streamReader.ReadLine();
                    while (line != null)
                    {
                        this.richTextBox1.Text += line + "\n";
                        line = arq_streamReader.ReadLine();
                    }
                    // vai ler a linha ate que retorne null, chege ao final do conteudo do arquivo

                    arq_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                }
            }

            /* ou podemos fzr de outra forma
            
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if(dr == System.Windows.Forms.DialogResult.OK)
            {

            }
            */
        }

        private void VerificaAcaoArquivo(string tipoAcao, string Alerta)
        {
            F_SairSemSalvar f_SairSemSalvar = new F_SairSemSalvar(Alerta);

            if (tipoAcao == TipoAcao.Abrir.ToString())
            {
                if (this.richTextBox1.Text == "")
                {
                    Abrir();
                }
                else
                {
                    f_SairSemSalvar.ShowDialog();

                    if (f_SairSemSalvar.retorno_alerta == "s")
                    {
                        SalvarArquivo();
                        Abrir();
                    }
                    else if (f_SairSemSalvar.retorno_alerta == "n")
                    {
                        Abrir();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if ((tipoAcao == TipoAcao.Sair.ToString()))
            {
                if (this.richTextBox1.Text == "")
                {
                    this.Close();
                }
                else
                {
                    f_SairSemSalvar.ShowDialog();

                    if (f_SairSemSalvar.retorno_alerta == "s")
                    {
                        SalvarArquivo();
                        this.Close();
                    }
                    else if (f_SairSemSalvar.retorno_alerta == "n")
                    {
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (tipoAcao == TipoAcao.NovoArquivo.ToString())
            {
                if (this.richTextBox1.Text == "")
                {
                    richTextBox1.Clear();
                    richTextBox1.Focus();
                }
                else
                {
                    f_SairSemSalvar.ShowDialog();

                    if (f_SairSemSalvar.retorno_alerta == "s")
                    {
                        SalvarArquivo();
                        richTextBox1.Clear();
                        richTextBox1.Focus();
                    }
                    else if (f_SairSemSalvar.retorno_alerta == "n")
                    {
                        richTextBox1.Clear();
                        richTextBox1.Focus();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n,i,s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);

            if (n == false)
            {
                if(i == true && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else // (i == false && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Underline);
                }
                else if (i == true && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Italic);
                }
                else // (i == false && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
                }
            }
        }

        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            if (i == false)
            {
                if (n == true && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else // (i == false && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false && s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Underline);
                }
                else if (n == true && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Bold);
                }
                else // (i == false && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
                }
            }
        }

        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            if (s == false)
            {
                if (n == true && i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false && i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (n == true && i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold);
                }
                else // (i == false && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true && i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false && i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Italic);
                }
                else if (n == true && i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular | FontStyle.Bold);
                }
                else // (i == false && s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
                }
            }
        }

        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string txt = this.richTextBox1.Text;
            leitura = new StringReader(txt);

            // se o retorno da caixa de impressao foi Ok, caso seja clicado o cancelar nao vai acontecer a impressao
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        //
        // Eventos:
        //

        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void novoArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoArquivo();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            NovoArquivo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {

            VerificaAcaoArquivo(TipoAcao.Abrir.ToString(), Properties.Resources.Alerta_Abrir);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificaAcaoArquivo(TipoAcao.Abrir.ToString(), Properties.Resources.Alerta_Abrir);
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void btn_centro_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { // definir as configuracoes da rotina impressao da pagina com o conteudo do texto

            // Configuracao padrao utilizando referencia do video 87/88 do curso de CSharp do CFB Cursos

            float linhas_pagina = 0;
            float PosY = 0;
            int cont = 0;

            // definir as margens: esquerda e direita sao as margens de referencia
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            linhas_pagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);

            linha = leitura.ReadLine();
            while(cont < linhas_pagina)
            {
                PosY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosY, new StringFormat());
                cont++;
                linha = leitura.ReadLine();
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificaAcaoArquivo(TipoAcao.Sair.ToString(), Properties.Resources.Alerta_Sair);
        }
    }
}
