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
    public partial class F_Timer : Form
    {
        int num = 0;
        int PosX, PosY;
        int PosXini, PosYini;

        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            //num = 0;
            textBox1.Text = timer1.Interval.ToString();
            PosX = PosXini = pictureBox1.Location.X;
            PosY = PosYini = pictureBox1.Location.Y;

        }

        private void btn_iniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_parar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_reiniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            timer1.Interval = int.Parse(textBox1.Text);
        }

        private void btn_iniciar_carro_Click(object sender, EventArgs e)
        {
            t_carro.Start();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            t_carro.Stop();
            PosX = PosXini;
            pictureBox1.Location = new Point(PosXini, PosYini);
        }

        private void btn_parar_carro_Click(object sender, EventArgs e)
        {
            t_carro.Stop();
        }

        private void t_carro_Tick(object sender, EventArgs e)
        {
            PosX+=5;
            if (PosX > 650)
            {
                PosX = -90;
            }
            pictureBox1.Location = new Point(PosX, PosY);
        }
    }
}
