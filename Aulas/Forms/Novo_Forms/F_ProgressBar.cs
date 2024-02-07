using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// biblioteca abaixo para usar o comando sleep(), que para a execussao por um periodo
using System.Threading;

namespace Novo_Forms
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_valor.Text) < 100 && int.Parse(tb_valor.Text) > 0)
            {
                progressBar1.Value = int.Parse(tb_valor.Text);
            }
            else if (int.Parse(tb_valor.Text) >= 100)
            {
                progressBar1.Value = 100;
            }
            else
            {
                progressBar1.Value = 0;
            }
                
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(tb_quantidade.Text);
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;
                Thread.Sleep(30);
                // faz o for esperar 100 milisegundos para continar o loop
            }
        }
    }
}
