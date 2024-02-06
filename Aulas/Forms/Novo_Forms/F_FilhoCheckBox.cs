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
    public partial class F_FilhoCheckBox : Form
    {
        // utilizando 'OpenForms' para passar informacoes de uma janela para outra
        // nesse caso vamos fazer os 'CheckBox' de 'F_FilhoCheckBox' receberem as informacoes dos 'CheckBox' do pai 'F_CheckBox'

        public F_CheckBox f_CheckBox;

        public F_FilhoCheckBox()
        {
            InitializeComponent();

            try
            {
                f_CheckBox = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                // Application.OpenForms retorna uma colecao com todas as informacoes do formulario indicado
                // as F_CheckBox; serve para convertermos a colecao de formularios em um formulario do tipo 'F_CheckBox'
                // so vai funcionar se o Formulario que estamos pegando as informacoes esteja aberto
                cb_carro.Checked = f_CheckBox.cb_carro.Checked;
                cb_aviao.Checked = f_CheckBox.cb_aviao.Checked;
                cb_navio.Checked = f_CheckBox.cb_navio.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao Abrir o Formulario!");
            }
            // todos os CheckBox existentes no forms 'F_FilhoCheckBox' estao recebendo as mesmas informacoes dos CheckBox do forms 'F_CheckBox'

            // utilizar OpenForms eh apenas uma das formas de fazer essa passagem de informacoes, poderiamos ter utilizado argumentos de entrada no construtor 
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_carro.Checked = cb_carro.Checked;
            // para realizar a operacao contraria, basta inverter
            // fazer o formulario Pai receber as informacoes do formulario filho
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_navio.Checked = cb_navio.Checked;
        }
    }
}
