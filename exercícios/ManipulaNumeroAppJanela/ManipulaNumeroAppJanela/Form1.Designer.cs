namespace ManipulaNumeroAppJanela
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl150 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl25 = new System.Windows.Forms.Label();
            this.lblTriplo = new System.Windows.Forms.Label();
            this.lblDobro = new System.Windows.Forms.Label();
            this.lblPosterior = new System.Windows.Forms.Label();
            this.txtPor150 = new System.Windows.Forms.TextBox();
            this.txtPor100 = new System.Windows.Forms.TextBox();
            this.txtPor50 = new System.Windows.Forms.TextBox();
            this.txtPor25 = new System.Windows.Forms.TextBox();
            this.txtTriplo = new System.Windows.Forms.TextBox();
            this.txtDobro = new System.Windows.Forms.TextBox();
            this.txtPosterior = new System.Windows.Forms.TextBox();
            this.txtAnterior = new System.Windows.Forms.TextBox();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(9, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(82, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(138, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 71);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(214, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl150);
            this.groupBox2.Controls.Add(this.lbl100);
            this.groupBox2.Controls.Add(this.lbl50);
            this.groupBox2.Controls.Add(this.lbl25);
            this.groupBox2.Controls.Add(this.lblTriplo);
            this.groupBox2.Controls.Add(this.lblDobro);
            this.groupBox2.Controls.Add(this.lblPosterior);
            this.groupBox2.Controls.Add(this.txtPor150);
            this.groupBox2.Controls.Add(this.txtPor100);
            this.groupBox2.Controls.Add(this.txtPor50);
            this.groupBox2.Controls.Add(this.txtPor25);
            this.groupBox2.Controls.Add(this.txtTriplo);
            this.groupBox2.Controls.Add(this.txtDobro);
            this.groupBox2.Controls.Add(this.txtPosterior);
            this.groupBox2.Controls.Add(this.txtAnterior);
            this.groupBox2.Controls.Add(this.lblAnterior);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 373);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // lbl150
            // 
            this.lbl150.AutoSize = true;
            this.lbl150.Location = new System.Drawing.Point(6, 350);
            this.lbl150.Name = "lbl150";
            this.lbl150.Size = new System.Drawing.Size(35, 15);
            this.lbl150.TabIndex = 17;
            this.lbl150.Text = "150%";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Location = new System.Drawing.Point(6, 306);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(35, 15);
            this.lbl100.TabIndex = 16;
            this.lbl100.Text = "100%";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(6, 262);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(29, 15);
            this.lbl50.TabIndex = 15;
            this.lbl50.Text = "50%";
            // 
            // lbl25
            // 
            this.lbl25.AutoSize = true;
            this.lbl25.Location = new System.Drawing.Point(6, 218);
            this.lbl25.Name = "lbl25";
            this.lbl25.Size = new System.Drawing.Size(29, 15);
            this.lbl25.TabIndex = 14;
            this.lbl25.Text = "25%";
            // 
            // lblTriplo
            // 
            this.lblTriplo.AutoSize = true;
            this.lblTriplo.Location = new System.Drawing.Point(6, 174);
            this.lblTriplo.Name = "lblTriplo";
            this.lblTriplo.Size = new System.Drawing.Size(36, 15);
            this.lblTriplo.TabIndex = 13;
            this.lblTriplo.Text = "Triplo";
            // 
            // lblDobro
            // 
            this.lblDobro.AutoSize = true;
            this.lblDobro.Location = new System.Drawing.Point(6, 130);
            this.lblDobro.Name = "lblDobro";
            this.lblDobro.Size = new System.Drawing.Size(40, 15);
            this.lblDobro.TabIndex = 12;
            this.lblDobro.Text = "Dobro";
            // 
            // lblPosterior
            // 
            this.lblPosterior.AutoSize = true;
            this.lblPosterior.Location = new System.Drawing.Point(6, 86);
            this.lblPosterior.Name = "lblPosterior";
            this.lblPosterior.Size = new System.Drawing.Size(54, 15);
            this.lblPosterior.TabIndex = 11;
            this.lblPosterior.Text = "Posterior";
            // 
            // txtPor150
            // 
            this.txtPor150.Location = new System.Drawing.Point(82, 347);
            this.txtPor150.Name = "txtPor150";
            this.txtPor150.ReadOnly = true;
            this.txtPor150.Size = new System.Drawing.Size(138, 23);
            this.txtPor150.TabIndex = 9;
            // 
            // txtPor100
            // 
            this.txtPor100.Location = new System.Drawing.Point(82, 303);
            this.txtPor100.Name = "txtPor100";
            this.txtPor100.ReadOnly = true;
            this.txtPor100.Size = new System.Drawing.Size(138, 23);
            this.txtPor100.TabIndex = 8;
            // 
            // txtPor50
            // 
            this.txtPor50.Location = new System.Drawing.Point(82, 259);
            this.txtPor50.Name = "txtPor50";
            this.txtPor50.ReadOnly = true;
            this.txtPor50.Size = new System.Drawing.Size(138, 23);
            this.txtPor50.TabIndex = 7;
            // 
            // txtPor25
            // 
            this.txtPor25.Location = new System.Drawing.Point(82, 215);
            this.txtPor25.Name = "txtPor25";
            this.txtPor25.ReadOnly = true;
            this.txtPor25.Size = new System.Drawing.Size(138, 23);
            this.txtPor25.TabIndex = 6;
            // 
            // txtTriplo
            // 
            this.txtTriplo.Location = new System.Drawing.Point(82, 171);
            this.txtTriplo.Name = "txtTriplo";
            this.txtTriplo.ReadOnly = true;
            this.txtTriplo.Size = new System.Drawing.Size(138, 23);
            this.txtTriplo.TabIndex = 5;
            // 
            // txtDobro
            // 
            this.txtDobro.Location = new System.Drawing.Point(82, 127);
            this.txtDobro.Name = "txtDobro";
            this.txtDobro.ReadOnly = true;
            this.txtDobro.Size = new System.Drawing.Size(138, 23);
            this.txtDobro.TabIndex = 4;
            // 
            // txtPosterior
            // 
            this.txtPosterior.Location = new System.Drawing.Point(82, 83);
            this.txtPosterior.Name = "txtPosterior";
            this.txtPosterior.ReadOnly = true;
            this.txtPosterior.Size = new System.Drawing.Size(138, 23);
            this.txtPosterior.TabIndex = 3;
            // 
            // txtAnterior
            // 
            this.txtAnterior.Location = new System.Drawing.Point(82, 39);
            this.txtAnterior.Name = "txtAnterior";
            this.txtAnterior.ReadOnly = true;
            this.txtAnterior.Size = new System.Drawing.Size(138, 23);
            this.txtAnterior.TabIndex = 2;
            // 
            // lblAnterior
            // 
            this.lblAnterior.AutoSize = true;
            this.lblAnterior.Location = new System.Drawing.Point(6, 42);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(50, 15);
            this.lblAnterior.TabIndex = 1;
            this.lblAnterior.Text = "Anterior";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbl150;
        private Label lbl100;
        private Label lbl50;
        private Label lbl25;
        private Label lblTriplo;
        private Label lblDobro;
        private Label lblPosterior;
        private TextBox txtPor150;
        private TextBox txtPor100;
        private TextBox txtPor50;
        private TextBox txtPor25;
        private TextBox txtTriplo;
        private TextBox txtDobro;
        private TextBox txtPosterior;
        private TextBox txtAnterior;
        private Label lblAnterior;
        private Button btnCalcular;
    }
}