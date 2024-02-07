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
    public partial class F_RadioButton : Form
    {
        GroupBox groupBox;

        public F_RadioButton()
        {
            InitializeComponent();

            groupBox = groupBox1;
        }

        private void btn_selecionado1_Click(object sender, EventArgs e)
        {
            // maneira mais dificil
            // ir ate o groupbox, pegar os elementos/controloes, verificar quais sao RadioButton, chamar um metodo para pegar so um elemento ou um elemento padrao e dentro do metodo passar qual RadioButton quer pegar e qual propriedade utilizar

            string txt = string.Empty;

            txt = groupBox.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            tb_selecionado.Text = txt;
            MessageBox.Show(txt);
        }

        private void btn_selecionado2_Click(object sender, EventArgs e)
        {
            // forma mais facil
            // passar um foreach para percorrer cada controle do groupbox e verificar se aquele controle/variavel esta checked
            string txt = string.Empty;

            foreach (RadioButton rb in groupBox.Controls)
            {
                if (rb.Checked)
                {
                    txt = rb.Text;
                }
            }

            tb_selecionado.Text = txt;
            MessageBox.Show(txt);
        }

        private void btn_mudarGB_Click(object sender, EventArgs e)
        {
            // muda qual dos groupsbox o valor sera selecionado e mostrado
            if(groupBox == groupBox1)
            {
                groupBox = groupBox2;
            }
            else
            {
                groupBox = groupBox1;
            }

            tb_selecionado.Clear();
        }
    }
}
