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
    public partial class F_ListBox : Form
    {
        // ListBox eh MUITO parecido com o ComboBox

        List<string> Carros = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();

            Carros.Add("Chevete");
            Carros.Add("Lancer");
            Carros.Add("Skyline");
            Carros.Add("Civic");

            // propriedade DataSource - serve para passar informacoes de uma lista ou de um banco de dados para dentro de um 'ListBox ou ComboBox'

            lbo_carros.DataSource = Carros;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
                tb_carro.Focus();
            }
            else
            {
                if (!lbo_carros.Items.Contains(tb_carro.Text)) // elemento nao existe na lista
                {
                    Carros.Add(tb_carro.Text);

                    SetDataSource(lbo_carros, Carros);
                }
                else
                {
                    MessageBox.Show("Elemento ja existe na ListBox!\n\nDigite outro elemento");
                }

                tb_carro.Clear();
                tb_carro.Focus();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Carros.RemoveAt(lbo_carros.SelectedIndex);
            // remover um carro de acordo com o elemento selecionado no ListBox
            // SelectedIndex retorna o indice do elemento selecionado

            // depois apenas eh preciso atualizar o ListBox
            SetDataSource(lbo_carros, Carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = Carros[lbo_carros.SelectedIndex].ToString();
            // retorna para o TextBox o carro em formato de string da colecao Carros a partir do elemento selecionado diretamente pelo ListBox
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Carros.Clear();

            SetDataSource(lbo_carros, Carros);
        }

        public void SetDataSource(ListBox lbo, List<string> list)
        {
            lbo.DataSource = null;
            lbo.DataSource = list;
        }
    }
}
