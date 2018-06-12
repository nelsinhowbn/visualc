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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data :" + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1();
            tst1.MdiParent = this;
            tst1.Show();

        }

        private void frmTeste1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Título",MessageBoxButtons.YesNo ,  MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }



        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste2 tst3 = new frmTeste2();
            tst3.MdiParent = this;
            tst3.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora :" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            lblHora.Text = "Hora :" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio3 tst3 = new Exercicio3();
            tst3.MdiParent = this;
            tst3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio4 tst4 = new Exercicio4();
            tst4.MdiParent = this;
            tst4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio5 tst5 = new Exercicio5();
            tst5.MdiParent = this;
            tst5.Show();
        }

        private void exerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio6 tst6 = new Exercicio6();
            tst6.MdiParent = this;
            tst6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio7 tst7 = new Exercicio7();
            tst7.MdiParent = this;
            tst7.Show();
        }




    }
}
