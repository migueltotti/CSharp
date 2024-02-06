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
    public partial class F_Veiculos : Form
    {
        F_Principal fp;

        // para passarmos valores/dados de um formulario filho para um formulario pai precisamos passar o formulario pai como argumento de entrada do metodo construtor da classe filho
        // assim conseguimos ter acesso a propriedades da classe pai pela classe filho
        public F_Veiculos(string Texto, F_Principal f)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = Texto;

            fp = f;
            f.num = 10;
        }

        // para podermos alterar o textbox do Forms pai pelo filho pelo proprio textbox precisamos declarar o textbox do pai como public para podermos acessar ele
        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = this.tb_listaVeiculos.Text;
        }
    }
}
