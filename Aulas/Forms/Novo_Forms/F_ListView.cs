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
    // ListViews possuem itens e subitens
    // itens - linhas
    // subitens - colunas
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();

            tb_id.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string[] prod = new string[4]; // representa as 4 colunas presentes no ListView

            prod[0] = tb_id.Text;
            prod[1] = tb_produto.Text;
            prod[2] = tb_qtde.Text;
            prod[3] = tb_preco.Text;

            foreach (string t in prod) // caso algum campo esteja vazio
            {
                if (t == "")
                {
                    MessageBox.Show("Campos obrigatorios nao preenchidos");
                    return;
                }
            }

            ListViewItem l = new ListViewItem(prod);

            lv_produtos.Items.Add(l);

            Limpar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            Obter();
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // evento acionado sempre que o indice do listview eh mudado

            if (lv_produtos.SelectedIndices.Count > 0) // existem itens selecionados
            {
                Obter();
            }
        }

        private void Obter()
        {
            // o indice 0 em SelectedItem, uma colecao, significa que ele vai pegar o primeiro item selecionado, primeira posicao da colecao
            // como a opcao de multiplos itens selecionados eh FALSE o unico item selecionado sepre sera o primeiro

            // Subitems[0] significa que ele vai receber o valor de 'Id', que eh o primeiro subitem de um determinado item

            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
