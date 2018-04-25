namespace NelsonYoussif_Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblvalorA = new System.Windows.Forms.Label();
            this.valorAtextbox = new System.Windows.Forms.TextBox();
            this.lblvalorB = new System.Windows.Forms.Label();
            this.valorBtextbox = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblr = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvalorA
            // 
            this.lblvalorA.AutoSize = true;
            this.lblvalorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorA.Location = new System.Drawing.Point(12, 9);
            this.lblvalorA.Name = "lblvalorA";
            this.lblvalorA.Size = new System.Drawing.Size(88, 25);
            this.lblvalorA.TabIndex = 0;
            this.lblvalorA.Text = "Valor A:";
            // 
            // valorAtextbox
            // 
            this.valorAtextbox.Location = new System.Drawing.Point(106, 12);
            this.valorAtextbox.Name = "valorAtextbox";
            this.valorAtextbox.Size = new System.Drawing.Size(100, 20);
            this.valorAtextbox.TabIndex = 1;
            // 
            // lblvalorB
            // 
            this.lblvalorB.AutoSize = true;
            this.lblvalorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorB.Location = new System.Drawing.Point(17, 74);
            this.lblvalorB.Name = "lblvalorB";
            this.lblvalorB.Size = new System.Drawing.Size(88, 25);
            this.lblvalorB.TabIndex = 2;
            this.lblvalorB.Text = "Valor B:";
            // 
            // valorBtextbox
            // 
            this.valorBtextbox.Location = new System.Drawing.Point(106, 74);
            this.valorBtextbox.Name = "valorBtextbox";
            this.valorBtextbox.Size = new System.Drawing.Size(100, 20);
            this.valorBtextbox.TabIndex = 3;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(22, 127);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(67, 23);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "SOMA";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblr.Location = new System.Drawing.Point(17, 186);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(115, 25);
            this.lblr.TabIndex = 5;
            this.lblr.Text = "Resultado:";
            this.lblr.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(138, 192);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(80, 20);
            this.resultbox.TabIndex = 6;
            this.resultbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(106, 127);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(79, 23);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(197, 127);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.valorBtextbox);
            this.Controls.Add(this.lblvalorB);
            this.Controls.Add(this.valorAtextbox);
            this.Controls.Add(this.lblvalorA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvalorA;
        private System.Windows.Forms.TextBox valorAtextbox;
        private System.Windows.Forms.Label lblvalorB;
        private System.Windows.Forms.TextBox valorBtextbox;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
    }
}

