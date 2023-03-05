namespace CalcularMediaAppJanela
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMediaAritmetica = new System.Windows.Forms.Label();
            this.lblMediaPonderada = new System.Windows.Forms.Label();
            this.txtMediaAritmetica = new System.Windows.Forms.TextBox();
            this.txtMediaPonderada = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtNota4);
            this.groupBox1.Controls.Add(this.txtNota3);
            this.groupBox1.Controls.Add(this.txtNota2);
            this.groupBox1.Controls.Add(this.txtNota1);
            this.groupBox1.Controls.Add(this.lblNota4);
            this.groupBox1.Controls.Add(this.lblNota3);
            this.groupBox1.Controls.Add(this.lblNota2);
            this.groupBox1.Controls.Add(this.lblNota1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMediaPonderada);
            this.groupBox2.Controls.Add(this.txtMediaAritmetica);
            this.groupBox2.Controls.Add(this.lblMediaPonderada);
            this.groupBox2.Controls.Add(this.lblMediaAritmetica);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(6, 33);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 15);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(6, 63);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(45, 15);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2 ";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(6, 93);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 15);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(6, 123);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(42, 15);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Nota 4";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(109, 30);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 23);
            this.txtNota1.TabIndex = 4;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(109, 59);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 23);
            this.txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(109, 88);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 23);
            this.txtNota3.TabIndex = 6;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(109, 120);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 23);
            this.txtNota4.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(203, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMediaAritmetica
            // 
            this.lblMediaAritmetica.AutoSize = true;
            this.lblMediaAritmetica.Location = new System.Drawing.Point(6, 47);
            this.lblMediaAritmetica.Name = "lblMediaAritmetica";
            this.lblMediaAritmetica.Size = new System.Drawing.Size(98, 15);
            this.lblMediaAritmetica.TabIndex = 1;
            this.lblMediaAritmetica.Text = "Media Aritmética";
            this.lblMediaAritmetica.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblMediaPonderada
            // 
            this.lblMediaPonderada.AutoSize = true;
            this.lblMediaPonderada.Location = new System.Drawing.Point(6, 100);
            this.lblMediaPonderada.Name = "lblMediaPonderada";
            this.lblMediaPonderada.Size = new System.Drawing.Size(100, 15);
            this.lblMediaPonderada.TabIndex = 2;
            this.lblMediaPonderada.Text = "Media Ponderada";
            // 
            // txtMediaAritmetica
            // 
            this.txtMediaAritmetica.Location = new System.Drawing.Point(109, 44);
            this.txtMediaAritmetica.Name = "txtMediaAritmetica";
            this.txtMediaAritmetica.ReadOnly = true;
            this.txtMediaAritmetica.Size = new System.Drawing.Size(100, 23);
            this.txtMediaAritmetica.TabIndex = 9;
            // 
            // txtMediaPonderada
            // 
            this.txtMediaPonderada.Location = new System.Drawing.Point(109, 97);
            this.txtMediaPonderada.Name = "txtMediaPonderada";
            this.txtMediaPonderada.ReadOnly = true;
            this.txtMediaPonderada.Size = new System.Drawing.Size(100, 23);
            this.txtMediaPonderada.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 346);
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

        private GroupBox groupBox1;
        private Button btnCalcular;
        private TextBox txtNota4;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private Label lblNota4;
        private Label lblNota3;
        private Label lblNota2;
        private Label lblNota1;
        private GroupBox groupBox2;
        private Label lblMediaPonderada;
        private Label lblMediaAritmetica;
        private TextBox txtMediaPonderada;
        private TextBox txtMediaAritmetica;
    }
}