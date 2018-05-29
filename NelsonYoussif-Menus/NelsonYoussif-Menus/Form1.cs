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
            frmTeste2 tst2 = new frmTeste2();
            tst2.MdiParent = this;
            tst2.Show();
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




    }
}
