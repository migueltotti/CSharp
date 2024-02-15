using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Sistema_Academia
{
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
            SELECT
                N_IDHORARIO as 'Id Horário',
                T_DSCHORARIO as 'Horário'
            FROM
                tb_horarios
            ORDER BY
                T_DSCHORARIO
            ";

            dgv_horarios.DataSource = Banco.DQL(vquery);

            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 250;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                SELECT
                    *
                FROM
                    tb_horarios
                WHERE
                    N_IDHORARIO=" + vid;

                dt = Banco.DQL(vquery);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                mtb_horario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
            }
        }

        private void btn_novoHorario_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            mtb_horario.Clear();
            mtb_horario.Focus();
        }

        private void btn_salvarHorario_Click(object sender, EventArgs e)
        {
            string vquery;

            if (tb_id.Text == "")
            {
                vquery = "INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('" + mtb_horario.Text + "')";

            }
            else
            {
                vquery = "UPDATE tb_horarios SET T_DSCHORARIO='" + mtb_horario.Text + "' WHERE N_IDHORARIO="+tb_id.Text;
            }
            Banco.DML(vquery);

            // atualizar os dados chamando uma query que retorna os dados da tb_horarios e atualiza o dgv


            string vq = @"
            SELECT
                N_IDHORARIO as 'Id Horário',
                T_DSCHORARIO as 'Horário'
            FROM
                tb_horarios
            ORDER BY
                T_DSCHORARIO
            ";

            dgv_horarios.DataSource = Banco.DQL(vq);

            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 250;
        }

        private void btn_excluirHorario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusao?", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO=" + tb_id.Text;
                Banco.DML(vquery);
            }

            // atualizar os dados apenas deletando do dgv a row selecionada
            dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
