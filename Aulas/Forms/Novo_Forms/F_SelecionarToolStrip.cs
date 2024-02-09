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
    public partial class F_SelecionarToolStrip : Form
    {
        ToolStripContainer toolStripContainer;

        public F_SelecionarToolStrip(ToolStripContainer tsc)
        {
            InitializeComponent();

            toolStripContainer = tsc;

        }

        private void F_SelecionarToolStrip_Load(object sender, EventArgs e)
        {
            List<ToolStrip> BF = new List<ToolStrip>();

            int num_barras_top = toolStripContainer.TopToolStripPanel.Controls.Count;

            for (int i = 0; i < num_barras_top; i++)
            {
                // toolStripContainer1.TopToolStripPanel.Controls retorna MenuStrip, por isso ele insere dentro do CheckedListBox o MenuStrip
                checkedListBox1.Items.Add(toolStripContainer.TopToolStripPanel.Controls[i].Name);
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indice = checkedListBox1.SelectedIndex;

            if (indice >= 0) 
            {
                if (checkedListBox1.GetItemChecked(indice))
                {
                    toolStripContainer.TopToolStripPanel.Controls[indice].Visible = false;
                }
                else
                {
                    toolStripContainer.TopToolStripPanel.Controls[indice].Visible = true;
                }
            }
        }
    }
}
