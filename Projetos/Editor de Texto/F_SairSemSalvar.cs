using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    public partial class F_SairSemSalvar : Form
    {
        public string retorno_alerta = string.Empty;
        public F_SairSemSalvar(string Alerta)
        {
            InitializeComponent();

            textBox1.Text = "Deseja " + Alerta + " sem Salvar?";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_naoSalvar_Click(object sender, EventArgs e)
        {
            // abrir ou sair sem salvar
            retorno_alerta = "n";
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // abrir ou sair e salvar
            retorno_alerta = "s";
            this.Close();
        }
    }
}
