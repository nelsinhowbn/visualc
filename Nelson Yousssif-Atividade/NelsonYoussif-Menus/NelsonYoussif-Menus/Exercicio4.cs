using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NelsonYoussif_Menus
{
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = System.Convert.ToInt16(textBox1.Text);
            switch (d)
            {case 1:
                    label2.Text = "Mês de Janeiro";
                    break;
              case 2:
                    label2.Text = "Mês de Fevereiro";
                    break;
                case 3:
                    label2.Text = "Mês de Março";
                    break;
                case 4:
                    label2.Text = "Mês de Abril";
                    break;
                case 5:
                    label2.Text = "Mês de Maio";
                    break;
                case 6:
                    label2.Text = "Mês de Junho";

                    break;
                case 7:
                    label2.Text = "Mês de Julho";
                    break;
                case 8:
                    label2.Text = "Mês de Agosto";
                    break;
                case 9:
                    label2.Text = "Mês de Setembro";
                    break;
                case 10:
                    label2.Text = "Mês de Outubro";
                    break;
                case 11:
                    label2.Text = "Mês de Novembro";
                    break;
                case 12:
                    label2.Text = "Mês de Dezembro";
                    break;
                default :
                    label2.Text = "Digite de 1 a 12";
                    break;
            }
            }
        }
    }

