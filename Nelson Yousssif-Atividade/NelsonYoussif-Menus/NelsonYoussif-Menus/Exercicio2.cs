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
    public partial class frmTeste2 : Form
    {
        public frmTeste2()
        {
            InitializeComponent();
        }

        private void frmTeste2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (System.Convert.ToDouble(textBox1.Text) % 2 == 0 || System.Convert.ToDouble(textBox1.Text) % 5 == 0 || System.Convert.ToDouble(textBox1.Text) % 10 == 0)
            {
                label1.Text = "É divisivel por ";
            } else {
                label1.Text = "Não é divisivel";
            }

            if (System.Convert.ToDouble(textBox1.Text) % 2 == 0)
            {
                label1.Text += "2 ";
            }
           
            if (System.Convert.ToDouble(textBox1.Text) % 5 == 0)
            {
                label1.Text += "5 ";
            }


            if (System.Convert.ToDouble(textBox1.Text) % 10 == 0)
            {
                label1.Text += "10 ";
            }
            
        }
    }
}







