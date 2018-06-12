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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nm = Convert.ToInt32(textBox1.Text);
            if (nm > 50)
            {
               Resultado.Text = "Digite um numero que seja valido ";
            }
            else
            {
                if (!Resultado.Text.Equals("   //   "))
                {
                    Resultado.Text = "           ";
                } 
                for (int i = 1; i <= nm; i++)
                {
                    Resultado.Text = Resultado.Text + i + ", ";
                }
            }
        }
    }
}

    

