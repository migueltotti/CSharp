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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            tb_dataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            tb_dataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            tb_dataHoje.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_dataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            tb_dataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            tb_dataHoje.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
