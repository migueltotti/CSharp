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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            // podemos criar strings dentro do arquivo Resources.resx e elas serao globais para TUDO
            // assim qualquer mudanca nelas alterara a string em todos os lugares aonde ela estiver presente
            // sempre que a janela que contem aquela string for aberta ela ja estara carregada
            label1.Text = Properties.Resources.Nome_D;
            label2.Text = Properties.Resources.Nome_E;
        }

        private void btn_img1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.documento_de_texto;
        }

        private void btn_img2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Rabisco;
        }
    }
}
