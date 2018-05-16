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

        double n1, r,n2;
        
        int op,v=0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
            if (painel.Text == "0")
                painel.Text = "6";

            else
            {
                painel.Text = (painel.Text) + "6";
            }

            if (v == 0) // Se a operação for igual a 0, e o primeiro numero for diferente do 0 ele ira acrescentar esse numero *10 e mais o numero digitado
            {
                
                if (n1 != 0) {
                   n1=n1 * 10;
                }
                n1 = n1 + 6;
            }
            else {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 6;
            }
        } 

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
            if (painel.Text == "0")
                painel.Text = "8";

            else
            {
                painel.Text = (painel.Text) + "8";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 8;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 8;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "x";

            if (v >= 1)
            {
                switch (op)
                {
                    case 1:
                        r = n1 * n2;
                        painel.Text = r.ToString();
                        break;
                    case 2:
                        r = n1 + n2;
                        painel.Text = r.ToString();
                        break;
                    case 3:
                        r = n1 - n2;
                        painel.Text = r.ToString();
                        break;
                    case 4:
                        r = n1 / n2;
                        painel.Text = r.ToString();
                        break;
                }
                n1 = r;
                n2 = 0;
            }
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 1;
            v++; // adiciona uma variavel V
           

           
           
        }


        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";
            if (v >= 1)
            {
                switch (op)
                {
                    case 1:
                        r = n1 * n2;
                        painel.Text = r.ToString();
                        break;
                    case 2:
                        r = n1 + n2;
                        painel.Text = r.ToString();
                        break;
                    case 3:
                        r = n1 - n2;
                        painel.Text = r.ToString();
                        break;
                    case 4:
                        r = n1 / n2;
                        painel.Text = r.ToString();
                        break;
                }
                n1 = r;
                n2 = 0;
            }
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 3;
            v++;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
            if (painel.Text == "0")
                painel.Text = "1";

            else
            {
                painel.Text = (painel.Text) + "1";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 1;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 1;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            if (painel.Text == "0")
                painel.Text = "2";

            else
            {
                painel.Text = (painel.Text) + "2";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 2;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 2;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
            if (painel.Text == "0")
                painel.Text = "3";

            else
            {
                painel.Text = (painel.Text) + "3";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 3;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 3;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
            if (painel.Text == "0")
                painel.Text = "4";

            else
            {
                painel.Text = (painel.Text) + "4";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 4;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 4;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
            if (painel.Text == "0")
                painel.Text = "5";

            else
            {
                painel.Text = (painel.Text) + "5";
            }
            if (v == 0) 
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 5;
            }
                
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 5;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
            if (painel.Text == "0")
                painel.Text = "7";

            else
            {
                painel.Text = (painel.Text) + "7";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 7;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 7;
            }
        }

    

        private void btn0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
            
            if (painel.Text == "")
                painel.Text = "0";

            else
            {
                painel.Text = (painel.Text) + "0";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 0;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 0;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
            if (painel.Text == "0")
                painel.Text = "9";

            else
            {
                painel.Text = (painel.Text) + "9";
            }
            if (v == 0)
            {

                if (n1 != 0)
                {
                    n1 = n1 * 10;
                }
                n1 = n1 + 9;
            }
            else
            {
                if (n2 != 0)
                {
                    n2 = n2 * 10;
                }
                n2 = n2 + 9;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "/";

            if (v >= 1)
            {
                switch (op)
                {
                    case 1:
                        r = n1 * n2;
                        painel.Text = r.ToString();
                        break;
                    case 2:
                        r = n1 + n2;
                        painel.Text = r.ToString();
                        break;
                    case 3:
                        r = n1 - n2;
                        painel.Text = r.ToString();
                        break;
                    case 4:
                        r = n1 / n2;
                        painel.Text = r.ToString();
                        break;
                }
                n1 = r;
                n2 = 0;
            }
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 4;
            v++;

        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            if (v >= 1)
            {
                switch (op)
                {
                    case 1:
                        r = n1 * n2;
                        painel.Text = r.ToString();
                        break;
                    case 2:
                        r = n1 + n2;
                        painel.Text = r.ToString();
                        break;
                    case 3:
                        r = n1 - n2;
                        painel.Text = r.ToString();
                        break;
                    case 4:
                        r = n1 / n2;
                        painel.Text = r.ToString();
                        break;
                }
                n1 = r;
                n2 = 0;
                painel.Text = "" + r;
            }
            n1 = float.Parse(painel.Text);
            painel.Clear();
            painel.Focus();
            op = 2;
            v++;

            }



        private void btnigual_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "=";


           // painel.Text += "=";

            switch (op)
            {  
                case 1:
                    r = n1 * n2;
                    painel.Text = r.ToString();   // operação de multiplicação
                    break;
                case 2:
                    r = n1 + n2;
                    painel.Text = r.ToString(); // opração de adição
                    break;
                case 3:
                    r = n1 - n2;
                    painel.Text = r.ToString(); 
                    break;
                case 4:
                    r = n1 / n2;
                    painel.Text = r.ToString(); 
                    break;
            }

            n1 = r;
            n2 = 0;
            label1.Text = label1.Text + r;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = 0;
            n1 = 0;
            n2 = 0;
            v = 0;
            painel.Text = "";
            label1.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }
        

    
    }
}
