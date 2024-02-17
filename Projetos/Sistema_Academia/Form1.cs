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

        ///////Metodos

        private void AbreForm(int nivel, Form F)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel >= nivel)
                {
                    F.ShowDialog();
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

        //// fim dos metodos

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

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
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
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();

            AbreForm(2, f_NovoUsuario);
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();

            AbreForm(2, f_GestaoUsuarios);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();

            AbreForm(2, f_NovoAluno);
        }

        private void horarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();

            AbreForm(3, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professores f_Professores = new F_Professores();

            AbreForm(3, f_Professores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();

            AbreForm(2, f_GestaoTurmas);
        }

        private void gestãoDeAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();

            AbreForm(2, f_GestaoAlunos);
        }
    }
}
