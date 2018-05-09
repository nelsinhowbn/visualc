using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NelsonYoussif_SuperCalculadora
{
    public partial class Form1 : Form
    {

        double n1, r;
        String operacao;
        int op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "6";

            else
            {
                painel.Text = (painel.Text) + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "8";

            else
            {
                painel.Text = (painel.Text) + "8";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 1;
           

           
           
        }


        private void button8_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 3;


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "1";

            else
            {
                painel.Text = (painel.Text) + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "2";

            else
            {
                painel.Text = (painel.Text) + "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "3";

            else
            {
                painel.Text = (painel.Text) + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "4";

            else
            {
                painel.Text = (painel.Text) + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "5";

            else
            {
                painel.Text = (painel.Text) + "5";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "7";

            else
            {
                painel.Text = (painel.Text) + "7";
            }
        }

    

        private void btn0_Click(object sender, EventArgs e)
        {
            
            if (painel.Text == "")
                painel.Text = "0";

            else
            {
                painel.Text = (painel.Text) + "0";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (painel.Text == "0")
                painel.Text = "9";

            else
            {
                painel.Text = (painel.Text) + "9";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 4; 

        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 2;

            }

      

        private void btnigual_Click(object sender, EventArgs e)
        {
            compute (op);
         }

        public void compute(int op)
        {
            switch (op)
            {
                case 1:
                    r = n1 * float.Parse(painel.Text);
                    painel.Text = r.ToString();
                    break;
                case 2:
                    r = n1 + float.Parse(painel.Text);
                    painel.Text = r.ToString();
                    break;
                case 3:
                    r = n1 - float.Parse(painel.Text);
                    painel.Text = r.ToString();
                    break;
                case 4:
                    r = n1 / float.Parse(painel.Text);
                    painel.Text = r.ToString();
                    break;
            }
        }

        private void painel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
