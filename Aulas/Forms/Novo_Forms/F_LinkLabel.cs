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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            ll_multiplosLinks.Links.Add(0, 6,"www.google.com.br");
            ll_multiplosLinks.Links.Add(9, 7, "www.youtube.com");
            // para criarmos um 'linklabel' que acesse varios locais precisamos dos metodos '.Link.Add()'
            // metodo .Add() necessita de um indice de inicio e tamanho do texto, da palavra que sera o link e depois inserir o link

            ll_multiplosLinks.Links[1].Enabled = false;
            // desabilitando um link
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("\"C:\\Users\\User\\Documents\\C#\\CSharp\\Projetos\\Calculadora\\Calculadora\\bin\\Debug\\Calculadora.exe\"");
            // esse comando permite comecar, dar inicio a um processo (site) ou *programa* definido
        }

        private void ll_gitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/migueltotti?nome=" + tb_nome.Text);
            // podemos passar paramentros para dentro de sites ou processos utilizando esses comando em formato 'PHP': ?nome=

            LinkLabel ll = (LinkLabel)sender;
            ll.Enabled = true;
            //ll_gitHub.LinkVisited = true;
            // define que o link ja foi visitado
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            // dessa forma conseguimos acessar os multiplos links
            
            e.Link.Visited = true;
            // define que o link ja foi visitado em um 'LinkLabel' com varios links
        }
    }
}
