using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos_de_Click_e_Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // para inserir eventos de Click no cogido basta clicarmos duas vezes no 'botao'
        // ou nas propriedades clicamos no raiozinho ('eventos') e damos dois clicks em 'Click'
        // vamos fazer a caixa de texto receber uma string e depois escrever no label
        private void btn_texto_Click(object sender, EventArgs e)
        {
            lb_text.Text = tb_texto.Text;
            // estamos definindo o texto recebido no 'TextBox' no 'label' toda vez que clicamos no botao
        }
    }
}
