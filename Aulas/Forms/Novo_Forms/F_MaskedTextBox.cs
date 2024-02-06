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
    public partial class F_MaskedTextBox : Form
    {
        // MaskedTextBox eh um TextBox com o diferencial de setar mascaras e condicoes para entrada de texto do usuario

        // PasswordChar - transforma o nosso mtb_ em um campo para inserir uma senha sem que ela seja vista

        // Procure no Site oficial da Microsoft .NET sobre MaskedTextBox.Mask para encontrar modelos de formatacao de mascaras
        bool Masked;

        public F_MaskedTextBox()
        {
            InitializeComponent();
            Masked = true;
        }

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
            if (Masked)
            {
                mtb_senha.PasswordChar = '\0';
                Masked = false;
            }
            else
            {
                mtb_senha.PasswordChar = '*';
                Masked = true;
            }
            
        }

        private void btn_mostrarTexto_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string txt = maskedTextBox1.Text;

            MessageBox.Show(txt);
        }
    }
}
