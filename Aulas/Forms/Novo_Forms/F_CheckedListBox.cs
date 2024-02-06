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
    public partial class F_CheckedListBox : Form
    {
        List<string> tr = new List<string>();

        public F_CheckedListBox()
        {
            InitializeComponent();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Moto");
            tr.Add("Bicicleta");
            tr.Add("Onibus");
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            clb_transportes.Items.AddRange(tr.ToArray());
            // precisamos converter uma Lista (tr) em uma Colecao (Array)
        }

        private void btn_addNovoTransp_Click(object sender, EventArgs e)
        {
            tr.Add(tb_novoTransp.Text);

            if (tb_novoTransp.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransp.Text);
                tb_novoTransp.Clear();
                tb_novoTransp.Focus();
            }
            else
            {
                MessageBox.Show("Digite um Transporte!");
            }
        }

        private void btn_desmarcar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < tr.Count; i++)
            {
                clb_transportes.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
