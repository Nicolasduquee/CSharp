namespace Ex1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Location = new System.Drawing.Point(12, 28);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(63, 15);
            this.lblAnoAtual.TabIndex = 0;
            this.lblAnoAtual.Text = "Ano Atual:";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(12, 66);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(113, 15);
            this.lblAnoNascimento.TabIndex = 1;
            this.lblAnoNascimento.Text = "Ano de nascimento:";
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(153, 25);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(114, 23);
            this.txtAnoAtual.TabIndex = 2;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(152, 63);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(114, 23);
            this.txtAnoNascimento.TabIndex = 3;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.AutoSize = true;
            this.btnAnalisar.Location = new System.Drawing.Point(12, 98);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(254, 25);
            this.btnAnalisar.TabIndex = 4;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 133);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.lblAnoAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Idade Eleitoral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAnoAtual;
        private Label lblAnoNascimento;
        private TextBox txtAnoAtual;
        private TextBox txtAnoNascimento;
        private Button btnAnalisar;
    }
}