using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "") // texto com conteudo
            {
                MessageBox.Show("Digite um veiculo");
                tb_veiculo.Focus(); // posiciona o cursor '|' na caixa de texto 'tb_veiculo' sempre q essa condicao for verdadeira
                return;
                // return vai apenas terminar o evento do messagebox e retornar para o forms anterior

                // caixa de mensagem que aparecera caso o botao seja clicado e nao tenha nenhum conteudo no 'tb_veiculo'
            }
            
            //tb_listaVeiculos.Text = tb_listaVeiculos.Text + tb_veiculo.Text;
            tb_listaVeiculos.Text += tb_veiculo.Text + " , ";

            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }
    }
}
