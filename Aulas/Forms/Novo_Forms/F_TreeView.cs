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
    public partial class F_TreeView : Form
    {

        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox3.Text = treeView1.SelectedNode.Text;
            textBox2.Clear();

            if (treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Sao Paulo");
            estado1.Name = "estado1";

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover no, " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover no, " + ex.Message);
            }
            
        }
    }
}
