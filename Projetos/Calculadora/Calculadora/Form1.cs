using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class F_Principal : Form
    {
        // Implementar 2 raiz de 2
        // implementar numeros com virgula e tentar deixar o codigo mais legivel, organizado e bonito -> calculadora

        Queue<string> QueueDisplay = new Queue<string>();
        Stack<string> StackNum = new Stack<string>();
        Stack<string> StackOp = new Stack<string>();

        List<string> Historico = new List<string>();

        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_display.Text += 1.ToString();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_display.Text += 2.ToString();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_display.Text += 3.ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_display.Text += 4.ToString();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_display.Text += 5.ToString();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_display.Text += 6.ToString();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_display.Text += 7.ToString();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_display.Text += 8.ToString();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_display.Text += 9.ToString();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_display.Text += 0.ToString();
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            tb_display.Text += ",";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            string txt = string.Empty;

            if (tb_display.Text.Last() == '+' || tb_display.Text.Last() == '-' || tb_display.Text.Last() == 'x' || tb_display.Text.Last() == '÷' || tb_display.Text.Last() == '^' || tb_display.Text.Last() == '√')
            {
                MessageBox.Show("Erro de formatacao;\n'Nao eh possivel terminacao vazia ou com operador!'");
                tb_display.Clear();
                return;
            }
            else
            {
                foreach (char t in tb_display.Text)
                {
                    if (t == '+' || t == '-' || t == 'x' || t == '÷' || t == '^' || t == '√')
                    {
                        QueueDisplay.Enqueue(txt);
                        txt = string.Empty;
                        QueueDisplay.Enqueue(t.ToString());
                    }
                    else
                    {
                        txt += t;
                    }
                }


                QueueDisplay.Enqueue(txt);
            }

            Calculadora(QueueDisplay, StackNum, StackOp);

            Historico.Add(tb_display.Text + " = " + StackNum.Peek());

            tb_display.Text = StackNum.Pop();

            StackNum.Clear();
            StackOp.Clear();
            QueueDisplay.Clear();

            //MessageBox.Show(QueueDisplay.Dequeue() + " " + QueueDisplay.Dequeue() + " " + QueueDisplay.Dequeue());
            //MessageBox.Show(QueueDisplay.Count.ToString());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tb_display.Text += "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            tb_display.Text += "-";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            tb_display.Text += "x";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            tb_display.Text += "÷";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_display.Clear();
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            tb_display.Text += "^";
        }

        private void btn_sqRt_Click(object sender, EventArgs e)
        {
            tb_display.Text += "√";
        }

        private void btn_deletedigit_Click(object sender, EventArgs e)
        {
            if (tb_display.Text.Length > 0)
            {
                tb_display.Text = tb_display.Text.Remove(tb_display.Text.Count() - 1);
            }
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            F_Historico f_Historico = new F_Historico(Historico);

            f_Historico.ShowDialog();
        }

        private void Calculadora(Queue<string> QueueDisplay, Stack<string> StackNum, Stack<string> StackOp)
        {
            while (QueueDisplay.Count > 0) // 5 + 5 X 3 ^ 2
            {
                if (QueueDisplay.First() == "+" || QueueDisplay.First() == "-" || QueueDisplay.First() == "x" || QueueDisplay.First() == "÷" || QueueDisplay.First() == "^" || QueueDisplay.First() == "√")
                {
                    if(StackOp.Count == 0 || !(StackOp.Peek() == "√" || StackOp.Peek() == "^" || (QueueDisplay.First() == "+" && StackOp.Peek() == "-") || (QueueDisplay.First() == "-" && StackOp.Peek() == "+") || StackOp.Peek() == "÷" || StackOp.Peek() == "x"))
                    {
                        // entrar no StackOp
                        StackOp.Push(QueueDisplay.Dequeue());
                    }
                    /*else if (!(StackOp.Peek() == "÷" || StackOp.Peek() == "x" || QueueDisplay.First() == StackOp.Peek() || (QueueDisplay.First() == "+" && StackOp.Peek() == "-") || (QueueDisplay.First() == "-" && StackOp.Peek() == "+")))
                    {
                        StackOp.Push(QueueDisplay.Dequeue());
                    }*/
                    else
                    {
                        Calculo(StackNum, StackOp);
                    }
                }
                else
                {
                    // entra no StackNum
                    StackNum.Push(QueueDisplay.Dequeue());
                }
            }

            if(!(StackNum.Count == 1 && StackOp.Count == 0))
            {
                while(StackOp.Count > 0)
                {
                    Calculo(StackNum, StackOp);
                }
            }
        }

        private void Calculo(Stack<string> StackNum, Stack<string> StackOp)
        {
            double ret=0;
            double num1 = double.Parse(StackNum.Pop());
            string Operador = StackOp.Pop();

            if (Operador != "√")
            {
                if (StackNum.Count() > 0)
                {
                    double num2 = double.Parse(StackNum.Pop());
                    //string Operador = StackOp.Pop();

                    switch (Operador)
                    {
                        case "+":
                            ret = num2 + num1;
                            break;
                        case "-":
                            ret = num2 - num1;
                            break;
                        case "x":
                            ret = num2 * num1;
                            break;
                        case "÷":
                            ret = num2 / num1;
                            break;
                        case "^":
                            ret = Math.Pow(num2, num1);
                            break;
                    }
                }
                else // apenas um elemento na pilha de numeros
                {
                    string r = Operador + num1.ToString();
                    ret = double.Parse(r);
                }
            }
            else // StackOp.Peek() == "√"
            {
                ret = Math.Sqrt(num1);
            }


            StackNum.Push(ret.ToString());
        }
    }
}
