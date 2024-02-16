using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academia
{
    public partial class F_Professores : Form
    {
        public F_Professores()
        {
            InitializeComponent();
        }

        ///// METODOS
        private void CarregarDGV()
        {
            string vquery = @"
            SELECT 
                N_IDPROFESSOR as 'ID',
                T_NOMEPROFESSOR as 'Nome Professor',
                T_TELEFONE as 'Telefone'
            FROM 
                tb_professores
            ";

            dgv_professores.DataSource = Banco.DQL(vquery);
            dgv_professores.Columns[0].Width = 60;
            dgv_professores.Columns[1].Width = 230;
            dgv_professores.Columns[2].Width = 100;
        }
        
        /// fim dos metodos

        private void F_Professores_Load(object sender, EventArgs e)
        {
            CarregarDGV();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                SELECT 
                    *
                FROM 
                    tb_professores
                WHERE 
                    N_IDPROFESSOR = " + id;

                dt = Banco.DQL(vquery);

                tb_idProfessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_nomeProfessor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR").ToString();
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE").ToString();
            }
            
        }

        private void btn_novoProfessor_Click(object sender, EventArgs e)
        {
            tb_idProfessor.Clear();
            tb_nomeProfessor.Clear();
            mtb_telefone.Clear();
            tb_idProfessor.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string query = "";

            if (tb_idProfessor.Text != "")
            {
                // alteracao 
                query = "UPDATE tb_professores SET T_NOMEPROFESSOR='"+tb_nomeProfessor.Text+ "', T_TELEFONE='"+mtb_telefone.Text+ "' WHERE N_IDPROFESSOR="+tb_idProfessor.Text;
            }
            else
            {
                query = "INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) VALUES ('"+tb_nomeProfessor.Text+ "', '"+mtb_telefone.Text+"')";
            }

            Banco.DML(query);

            CarregarDGV();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (tb_idProfessor.Text != "")
            {
                DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Exclusão?", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    string query = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_idProfessor.Text;
                    Banco.DML(query);
                }

                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);

                tb_idProfessor.Clear();
                tb_nomeProfessor.Clear();
                mtb_telefone.Clear();
                tb_idProfessor.Focus();
            }
            
        }
    }
}
