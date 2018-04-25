using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NelsoYoussif_Maiorde3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boxA_TextChanged(object sender, EventArgs e)
        {


        }






        private void btnr_Click(object sender, EventArgs e)
        {
            double n = System.Convert.ToDouble(boxA.Text);
            double n1 = System.Convert.ToDouble(boxB.Text);
            double n3 = System.Convert.ToDouble(boxC.Text);

            if (n > n1 && n > n3)
            {
                boxr.Text = " O maior Valor é A";
            }
            else if (n1 > n && n1 > n3)
            {
                boxr.Text = " O maior Valor é B";
            }
            else if (n3 > n && n3 > n1)
            {
                boxr.Text = " O maior Valor é C";



                n.ToString();
                n1.ToString();
                n3.ToString();

            }
        }
    }
}
