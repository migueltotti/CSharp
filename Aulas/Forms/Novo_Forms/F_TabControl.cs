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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
            DefinirMax();
        }

        private void DefinirMax()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
            if (numericUpDown1.Maximum == 0)
            {
                numericUpDown1.Minimum = 0;
            }
            else
            {
                numericUpDown1.Minimum = 1;
            }
        }

        private void btn_addTab_Click(object sender, EventArgs e)
        {
            if (tb_novaTab.Text != "")
            {
                TabPage tabPage = new TabPage();

                tabPage.Text = tb_novaTab.Text;
                tabPage.Name = "tb_" + tb_novaTab.Text.ToLower();
                tabPage.TabIndex = tabControl1.TabPages.Count;
                tabPage.BackColor = Color.White;

                tabControl1.TabPages.Add(tabPage);
                tb_novaTab.Clear();

                DefinirMax();
            }
            else
            {
                MessageBox.Show("Digite um nome para a Nova Tab!");
            }

            tb_novaTab.Clear();
            tb_novaTab.Focus();
        }

        private void btn_removerTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            DefinirMax();
        }

        private void btn_posicionarTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = int.Parse(numericUpDown1.Value.ToString()) - 1;
        }
    }
}
