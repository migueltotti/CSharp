using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Forms
{
    public partial class F_BackGroundWorker : Form
    {
        // trabalha em segundo plano e n interfere no trabalho do programa

        int cont = 0;
        int max = 5000;

        public F_BackGroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < max; i++)
            {
                cont++;
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(10);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Trabalho terminado!");
            label1.Text = "W1 Terminado";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "W1 Trabalhando";
            label2.Text = cont.ToString();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                // roda a execusao em segundo plano
            }
            
        }
    }
}
