using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NelsonYoussif_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double n = System.Convert.ToDouble(valorAtextbox.Text);
            double n2 = System.Convert.ToDouble(valorBtextbox.Text);
            double r = n + n2;

            resultbox.Text = r.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double n = System.Convert.ToDouble(valorAtextbox.Text);
            double n2 = System.Convert.ToDouble(valorBtextbox.Text);
            double r = n / n2;

            resultbox.Text = r.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double n = System.Convert.ToDouble(valorAtextbox.Text);
            double n2 = System.Convert.ToDouble(valorBtextbox.Text);
            double r = n * n2;

            resultbox.Text = r.ToString();

        }
    }
}
