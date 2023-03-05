namespace CalcularAreaAppJanela
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnCalcularQuadrado = new System.Windows.Forms.Button();
            this.lblResultadoQuadrado = new System.Windows.Forms.Label();
            this.txtResultadoQuadrado = new System.Windows.Forms.TextBox();
            this.lblAlturaRetangulo = new System.Windows.Forms.Label();
            this.lblBaseRetangulo = new System.Windows.Forms.Label();
            this.txtBaseRetantgulo = new System.Windows.Forms.TextBox();
            this.txtAlturaRetangulo = new System.Windows.Forms.TextBox();
            this.btnCalcularRetangulo = new System.Windows.Forms.Button();
            this.lblResultadoRetangulo = new System.Windows.Forms.Label();
            this.txtResultadoRetangulo = new System.Windows.Forms.TextBox();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.btnCalcularTriangulo = new System.Windows.Forms.Button();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.txtResultadoTriangulo = new System.Windows.Forms.TextBox();
            this.lblResultadoTriangulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultadoQuadrado);
            this.groupBox1.Controls.Add(this.lblResultadoQuadrado);
            this.groupBox1.Controls.Add(this.btnCalcularQuadrado);
            this.groupBox1.Controls.Add(this.txtLado);
            this.groupBox1.Controls.Add(this.lblLado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área do Quadrado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultadoRetangulo);
            this.groupBox2.Controls.Add(this.lblResultadoRetangulo);
            this.groupBox2.Controls.Add(this.btnCalcularRetangulo);
            this.groupBox2.Controls.Add(this.txtAlturaRetangulo);
            this.groupBox2.Controls.Add(this.txtBaseRetantgulo);
            this.groupBox2.Controls.Add(this.lblBaseRetangulo);
            this.groupBox2.Controls.Add(this.lblAlturaRetangulo);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área do Retângulo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResultadoTriangulo);
            this.groupBox3.Controls.Add(this.txtResultadoTriangulo);
            this.groupBox3.Controls.Add(this.txtAlturaTriangulo);
            this.groupBox3.Controls.Add(this.txtBaseTriangulo);
            this.groupBox3.Controls.Add(this.btnCalcularTriangulo);
            this.groupBox3.Controls.Add(this.lblAlturaTriangulo);
            this.groupBox3.Controls.Add(this.lblBaseTriangulo);
            this.groupBox3.Location = new System.Drawing.Point(12, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Área do Triângulo";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(6, 29);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(33, 15);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado";
            this.lblLado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(114, 26);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(157, 23);
            this.txtLado.TabIndex = 1;
            // 
            // btnCalcularQuadrado
            // 
            this.btnCalcularQuadrado.Location = new System.Drawing.Point(5, 64);
            this.btnCalcularQuadrado.Name = "btnCalcularQuadrado";
            this.btnCalcularQuadrado.Size = new System.Drawing.Size(265, 23);
            this.btnCalcularQuadrado.TabIndex = 2;
            this.btnCalcularQuadrado.Text = "Calcular";
            this.btnCalcularQuadrado.UseVisualStyleBackColor = true;
            this.btnCalcularQuadrado.Click += new System.EventHandler(this.btnCalcularQuadrado_Click);
            // 
            // lblResultadoQuadrado
            // 
            this.lblResultadoQuadrado.AutoSize = true;
            this.lblResultadoQuadrado.Location = new System.Drawing.Point(6, 104);
            this.lblResultadoQuadrado.Name = "lblResultadoQuadrado";
            this.lblResultadoQuadrado.Size = new System.Drawing.Size(59, 15);
            this.lblResultadoQuadrado.TabIndex = 3;
            this.lblResultadoQuadrado.Text = "Resultado";
            this.lblResultadoQuadrado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtResultadoQuadrado
            // 
            this.txtResultadoQuadrado.Location = new System.Drawing.Point(114, 101);
            this.txtResultadoQuadrado.Name = "txtResultadoQuadrado";
            this.txtResultadoQuadrado.ReadOnly = true;
            this.txtResultadoQuadrado.Size = new System.Drawing.Size(157, 23);
            this.txtResultadoQuadrado.TabIndex = 4;
            // 
            // lblAlturaRetangulo
            // 
            this.lblAlturaRetangulo.AutoSize = true;
            this.lblAlturaRetangulo.Location = new System.Drawing.Point(6, 74);
            this.lblAlturaRetangulo.Name = "lblAlturaRetangulo";
            this.lblAlturaRetangulo.Size = new System.Drawing.Size(39, 15);
            this.lblAlturaRetangulo.TabIndex = 1;
            this.lblAlturaRetangulo.Text = "Altura";
            // 
            // lblBaseRetangulo
            // 
            this.lblBaseRetangulo.AutoSize = true;
            this.lblBaseRetangulo.Location = new System.Drawing.Point(6, 32);
            this.lblBaseRetangulo.Name = "lblBaseRetangulo";
            this.lblBaseRetangulo.Size = new System.Drawing.Size(31, 15);
            this.lblBaseRetangulo.TabIndex = 2;
            this.lblBaseRetangulo.Text = "Base";
            // 
            // txtBaseRetantgulo
            // 
            this.txtBaseRetantgulo.Location = new System.Drawing.Point(114, 29);
            this.txtBaseRetantgulo.Name = "txtBaseRetantgulo";
            this.txtBaseRetantgulo.Size = new System.Drawing.Size(157, 23);
            this.txtBaseRetantgulo.TabIndex = 3;
            // 
            // txtAlturaRetangulo
            // 
            this.txtAlturaRetangulo.Location = new System.Drawing.Point(114, 71);
            this.txtAlturaRetangulo.Name = "txtAlturaRetangulo";
            this.txtAlturaRetangulo.Size = new System.Drawing.Size(157, 23);
            this.txtAlturaRetangulo.TabIndex = 4;
            // 
            // btnCalcularRetangulo
            // 
            this.btnCalcularRetangulo.Location = new System.Drawing.Point(6, 113);
            this.btnCalcularRetangulo.Name = "btnCalcularRetangulo";
            this.btnCalcularRetangulo.Size = new System.Drawing.Size(265, 23);
            this.btnCalcularRetangulo.TabIndex = 5;
            this.btnCalcularRetangulo.Text = "Calcular";
            this.btnCalcularRetangulo.UseVisualStyleBackColor = true;
            this.btnCalcularRetangulo.Click += new System.EventHandler(this.btnCalcularRetangulo_Click);
            // 
            // lblResultadoRetangulo
            // 
            this.lblResultadoRetangulo.AutoSize = true;
            this.lblResultadoRetangulo.Location = new System.Drawing.Point(6, 150);
            this.lblResultadoRetangulo.Name = "lblResultadoRetangulo";
            this.lblResultadoRetangulo.Size = new System.Drawing.Size(59, 15);
            this.lblResultadoRetangulo.TabIndex = 6;
            this.lblResultadoRetangulo.Text = "Resultado";
            // 
            // txtResultadoRetangulo
            // 
            this.txtResultadoRetangulo.Location = new System.Drawing.Point(114, 147);
            this.txtResultadoRetangulo.Name = "txtResultadoRetangulo";
            this.txtResultadoRetangulo.ReadOnly = true;
            this.txtResultadoRetangulo.Size = new System.Drawing.Size(157, 23);
            this.txtResultadoRetangulo.TabIndex = 7;
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(8, 34);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(31, 15);
            this.lblBaseTriangulo.TabIndex = 3;
            this.lblBaseTriangulo.Text = "Base";
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(6, 75);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(39, 15);
            this.lblAlturaTriangulo.TabIndex = 4;
            this.lblAlturaTriangulo.Text = "Altura";
            // 
            // btnCalcularTriangulo
            // 
            this.btnCalcularTriangulo.Location = new System.Drawing.Point(6, 119);
            this.btnCalcularTriangulo.Name = "btnCalcularTriangulo";
            this.btnCalcularTriangulo.Size = new System.Drawing.Size(265, 23);
            this.btnCalcularTriangulo.TabIndex = 6;
            this.btnCalcularTriangulo.Text = "Calcular";
            this.btnCalcularTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularTriangulo.Click += new System.EventHandler(this.btnCalcularTriangulo_Click);
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(114, 31);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(157, 23);
            this.txtBaseTriangulo.TabIndex = 8;
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(114, 72);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(157, 23);
            this.txtAlturaTriangulo.TabIndex = 9;
            // 
            // txtResultadoTriangulo
            // 
            this.txtResultadoTriangulo.Location = new System.Drawing.Point(114, 153);
            this.txtResultadoTriangulo.Name = "txtResultadoTriangulo";
            this.txtResultadoTriangulo.ReadOnly = true;
            this.txtResultadoTriangulo.Size = new System.Drawing.Size(157, 23);
            this.txtResultadoTriangulo.TabIndex = 10;
            // 
            // lblResultadoTriangulo
            // 
            this.lblResultadoTriangulo.AutoSize = true;
            this.lblResultadoTriangulo.Location = new System.Drawing.Point(8, 153);
            this.lblResultadoTriangulo.Name = "lblResultadoTriangulo";
            this.lblResultadoTriangulo.Size = new System.Drawing.Size(59, 15);
            this.lblResultadoTriangulo.TabIndex = 8;
            this.lblResultadoTriangulo.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calcular Área";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblLado;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResultadoQuadrado;
        private Button btnCalcularQuadrado;
        private TextBox txtLado;
        private TextBox txtResultadoQuadrado;
        private TextBox txtResultadoRetangulo;
        private Label lblResultadoRetangulo;
        private Button btnCalcularRetangulo;
        private TextBox txtAlturaRetangulo;
        private TextBox txtBaseRetantgulo;
        private Label lblBaseRetangulo;
        private Label lblAlturaRetangulo;
        private Label lblResultadoTriangulo;
        private TextBox txtResultadoTriangulo;
        private TextBox txtAlturaTriangulo;
        private TextBox txtBaseTriangulo;
        private Button btnCalcularTriangulo;
        private Label lblAlturaTriangulo;
        private Label lblBaseTriangulo;
    }
}