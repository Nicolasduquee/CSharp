namespace InformacoesNumeroAppJanela
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtPoN = new System.Windows.Forms.TextBox();
            this.txtIoP = new System.Windows.Forms.TextBox();
            this.lblPoN = new System.Windows.Forms.Label();
            this.lblIoP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 26);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(73, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(131, 23);
            this.txtValor.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 64);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(192, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtPoN
            // 
            this.txtPoN.Location = new System.Drawing.Point(126, 110);
            this.txtPoN.Name = "txtPoN";
            this.txtPoN.ReadOnly = true;
            this.txtPoN.Size = new System.Drawing.Size(78, 23);
            this.txtPoN.TabIndex = 3;
            // 
            // txtIoP
            // 
            this.txtIoP.Location = new System.Drawing.Point(126, 149);
            this.txtIoP.Name = "txtIoP";
            this.txtIoP.ReadOnly = true;
            this.txtIoP.Size = new System.Drawing.Size(78, 23);
            this.txtIoP.TabIndex = 4;
            // 
            // lblPoN
            // 
            this.lblPoN.AutoSize = true;
            this.lblPoN.Location = new System.Drawing.Point(12, 113);
            this.lblPoN.Name = "lblPoN";
            this.lblPoN.Size = new System.Drawing.Size(108, 15);
            this.lblPoN.TabIndex = 5;
            this.lblPoN.Text = "Positivo / Negativo";
            // 
            // lblIoP
            // 
            this.lblIoP.AutoSize = true;
            this.lblIoP.Location = new System.Drawing.Point(12, 152);
            this.lblIoP.Name = "lblIoP";
            this.lblIoP.Size = new System.Drawing.Size(66, 15);
            this.lblIoP.TabIndex = 6;
            this.lblIoP.Text = "Ímpar / Par";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 184);
            this.Controls.Add(this.lblIoP);
            this.Controls.Add(this.lblPoN);
            this.Controls.Add(this.txtIoP);
            this.Controls.Add(this.txtPoN);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValor;
        private TextBox txtValor;
        private Button btnCalcular;
        private TextBox txtPoN;
        private TextBox txtIoP;
        private Label lblPoN;
        private Label lblIoP;
    }
}