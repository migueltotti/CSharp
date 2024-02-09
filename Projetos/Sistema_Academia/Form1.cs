using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // chamar a caixa de Login
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;

            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bandoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 3)
                {
                    // PROCEDIMENTOS

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 2)
                {
                    // PROCEDIMENTOS
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= 2)
                {
                    // PROCEDIMENTOS

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                // PROCEDIMENTOS
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }
    }
}
