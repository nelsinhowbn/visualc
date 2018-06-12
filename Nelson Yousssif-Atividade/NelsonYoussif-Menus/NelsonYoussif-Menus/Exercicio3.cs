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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {    double A = System.Convert.ToDouble(textBox1.Text);
             double B = System.Convert.ToDouble(textBox2.Text);
             double C = System.Convert.ToDouble(textBox3.Text);
             if (A == B && A == C)
             {
                 textBox4.Text = "Equilatero";
             }
             else if (A == B && B != C)
             {
                 textBox4.Text = "Isosceles";
             }
             else
             {
                 textBox4.Text = "Escaleno";
             }


            

            }
        }
    }

