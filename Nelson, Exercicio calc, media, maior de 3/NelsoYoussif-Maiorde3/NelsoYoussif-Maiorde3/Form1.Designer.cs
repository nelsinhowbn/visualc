namespace NelsoYoussif_Maiorde3
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.boxC = new System.Windows.Forms.TextBox();
            this.boxB = new System.Windows.Forms.TextBox();
            this.boxA = new System.Windows.Forms.TextBox();
            this.btnr = new System.Windows.Forms.Button();
            this.boxr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(23, 27);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Valor A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(23, 68);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(69, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Valor B: ";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(26, 113);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(65, 20);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Valor C:";
            this.lblC.Click += new System.EventHandler(this.label3_Click);
            // 
            // boxC
            // 
            this.boxC.Location = new System.Drawing.Point(97, 113);
            this.boxC.Name = "boxC";
            this.boxC.Size = new System.Drawing.Size(127, 20);
            this.boxC.TabIndex = 3;
            // 
            // boxB
            // 
            this.boxB.Location = new System.Drawing.Point(98, 68);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(126, 20);
            this.boxB.TabIndex = 4;
            // 
            // boxA
            // 
            this.boxA.Location = new System.Drawing.Point(94, 27);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(130, 20);
            this.boxA.TabIndex = 5;
            this.boxA.TextChanged += new System.EventHandler(this.boxA_TextChanged);
            // 
            // btnr
            // 
            this.btnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnr.Location = new System.Drawing.Point(45, 159);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(179, 29);
            this.btnr.TabIndex = 6;
            this.btnr.Text = "Resultado: ";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // boxr
            // 
            this.boxr.Location = new System.Drawing.Point(60, 206);
            this.boxr.Name = "boxr";
            this.boxr.Size = new System.Drawing.Size(157, 20);
            this.boxr.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.boxr);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.boxA);
            this.Controls.Add(this.boxB);
            this.Controls.Add(this.boxC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox boxC;
        private System.Windows.Forms.TextBox boxB;
        private System.Windows.Forms.TextBox boxA;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.TextBox boxr;
    }
}

