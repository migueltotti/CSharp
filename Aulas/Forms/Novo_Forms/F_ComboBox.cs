using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Forms
{
    public partial class F_ComboBox : Form
    {
        // ComboBox eh uma caixinha que quando clicada aparece varias opcoes selecionaveis embaixo dela
        
        List<string> tr = new List<string>();
        
        public F_ComboBox()
        {
            InitializeComponent();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");
            tr.Add("Moto");
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            // ComboBox permite o usuario escrever ao inves de selecionar
            if (cb_transportes.Items.Contains(cb_transportes.Text)) // faz a verificacao da existencia da informacao digitada pelo usuario no 'ComboBox'
            {
                MessageBox.Show(cb_transportes.Text);
            }
            else
            {
                MessageBox.Show("Informe um elemento existente no ComboBox!");
            }
            
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.Text = string.Empty;
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            foreach (string t in  tr)
            {
                cb_transportes.Items.Add(t);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_novoElemento.Text != "")
            {
                if (!(cb_transportes.Items.Contains(tb_novoElemento.Text)))
                { // poderia usar cb_transportes.FindString(tb_novoElemento.Text) para verificar se aquele elemento existe, caso nao existe retorna -1
                    tr.Add(tb_novoElemento.Text);

                    cb_transportes.Items.Add(tb_novoElemento.Text);
                }
                else
                {
                    MessageBox.Show("Elemento ja existe no ComboBox!\n\nDigite outro elemento");
                }

                tb_novoElemento.Clear();
                tb_novoElemento.Focus();
            }
            else
            {
                MessageBox.Show("Informe um Elemento!");
            }
            
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_novoElemento.Text = cb_transportes.Text;
        }
    }
}
