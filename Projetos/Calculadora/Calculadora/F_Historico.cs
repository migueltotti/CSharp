using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class F_Historico : Form
    {
        F_Principal f_Principal;
        List<string> Hist;

        public F_Historico(List<string> Historico)
        {
            InitializeComponent();

            f_Principal = Application.OpenForms["F_Principal"] as F_Principal;

            Hist = Historico;
            lbo_historico.DataSource = Hist;
        }

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            string txt = Hist[lbo_historico.SelectedIndex].ToString();
            int pos = txt.IndexOf('=');
            
            txt = txt.Remove(pos-1, txt.Length-pos);
            // pos-1 pega o espaco em branco entre o ultimo numero e o '='

            f_Principal.tb_display.Text = txt;

            this.Close();
        }
    }
}
