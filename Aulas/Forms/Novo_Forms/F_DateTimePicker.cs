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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;
            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(int.Parse(tb_ano.Text), int.Parse(tb_mes.Text), int.Parse(tb_dia.Text));

            dtp_data.Value = dt;
        }

        private void btn_dataAtual_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;

            dtp_data.Value = dt;
        }
    }
}
