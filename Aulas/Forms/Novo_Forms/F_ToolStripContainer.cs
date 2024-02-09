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
    public partial class F_ToolStripContainer : Form
    {
        public F_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void barraDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SelecionarToolStrip f_SelecionarToolStrip = new F_SelecionarToolStrip(toolStripContainer1);

            f_SelecionarToolStrip.ShowDialog();
        }
    }
}
