using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NelsonYoussif_CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double n = System.Convert.ToDouble(box1.Text);
            double n1 = System.Convert.ToDouble(box2.Text);
            double n2 = System.Convert.ToDouble(box3.Text);
            double n3 = System.Convert.ToDouble(box4.Text);
        

            double r = (n + n1 + n2 + n3) / 4;
         
            boxr.Text = boxnome.Text+", sua média é:"+r.ToString();
            

        }

        private void boxr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
