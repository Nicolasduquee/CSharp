namespace Ex4
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(15, 25);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(139, 15);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Preencha com sua idade:";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(12, 64);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(37, 15);
            this.lblAnos.TabIndex = 1;
            this.lblAnos.Text = "Anos:";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(12, 102);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(43, 15);
            this.lblMeses.TabIndex = 2;
            this.lblMeses.Text = "Meses:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(12, 140);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(32, 15);
            this.lblDias.TabIndex = 3;
            this.lblDias.Text = "Dias:";
            // 
            // txtAnos
            // 
            this.txtAnos.Location = new System.Drawing.Point(65, 61);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.Size = new System.Drawing.Size(100, 23);
            this.txtAnos.TabIndex = 4;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(65, 99);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(100, 23);
            this.txtMeses.TabIndex = 5;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(65, 132);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 23);
            this.txtDias.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 173);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 208);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtAnos);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.lblEnunciado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEnunciado;
        private Label lblAnos;
        private Label lblMeses;
        private Label lblDias;
        private TextBox txtAnos;
        private TextBox txtMeses;
        private TextBox txtDias;
        private Button btnCalcular;
    }
}