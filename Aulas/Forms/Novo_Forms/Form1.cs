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
    public partial class F_Principal : Form
    {
        public int num;

        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        // criar um novo forms 
        // clicar em Projeto -> Adicionar Formulario Windows -> Adicionar

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veiculo!");
                tb_veiculo.Focus();
                return;
            }

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

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculos.Text, this);
            // this vai enviar como um argumento a propria classe F_Principal
            // declarando um objeto da classe 'F_Veiculos' -> novo forms

            f_Veiculos.ShowDialog(); // - nao permite acessar outras janelas 
            //f_Veiculos.Show(); - permite acessar outras janelas
        }

        private void btn_valnum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();

            f_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();

            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();

            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();

            f_DateTimePicker.ShowDialog();
        }

        private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();

            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();

            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();

            f_ListView.ShowDialog();
        }
    }
}
