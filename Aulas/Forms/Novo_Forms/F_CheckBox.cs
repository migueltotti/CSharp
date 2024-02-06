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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> Transp = new List<CheckBox>();

        public F_CheckBox()
        {
            InitializeComponent();
            Transp.Add(cb_carro);
            Transp.Add(cb_aviao);
            Transp.Add(cb_navio);
        }

        private void btn_transportes_Click(object sender, EventArgs e)
        {
            string txt = "";

            /*if(cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }
            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }*/

            // mesma coisa que o codigo acima, porem menor
            foreach(CheckBox t in Transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcado!");
            }
        }

        private void btn_abrirFilho_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();

            f_FilhoCheckBox.ShowDialog();
        }
    }
}
