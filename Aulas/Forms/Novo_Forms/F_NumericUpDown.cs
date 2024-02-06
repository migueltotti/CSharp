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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_valor_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(tb_valor.Text) <= numericUpDown1.Maximum || decimal.Parse(tb_valor.Text) <= numericUpDown1.Minimum)
            {
                numericUpDown1.Value = decimal.Parse(tb_valor.Text);
            }
            else if(decimal.Parse(tb_valor.Text) >= numericUpDown1.Maximum)
            {
                numericUpDown1.Value = numericUpDown1.Maximum;
            }
            else
            {
                numericUpDown1.Value = numericUpDown1.Minimum;
            }
            
        }
    }
}
