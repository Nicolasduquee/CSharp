namespace Ex3
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVotosValidos = new System.Windows.Forms.Label();
            this.lblVotosBranco = new System.Windows.Forms.Label();
            this.lblVotosNulo = new System.Windows.Forms.Label();
            this.txtTotalEleitores = new System.Windows.Forms.TextBox();
            this.txtVotosValidos = new System.Windows.Forms.TextBox();
            this.txtVotosBranco = new System.Windows.Forms.TextBox();
            this.txtVotosNulo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total de eleitores:";
            // 
            // lblVotosValidos
            // 
            this.lblVotosValidos.AutoSize = true;
            this.lblVotosValidos.Location = new System.Drawing.Point(12, 60);
            this.lblVotosValidos.Name = "lblVotosValidos";
            this.lblVotosValidos.Size = new System.Drawing.Size(79, 15);
            this.lblVotosValidos.TabIndex = 1;
            this.lblVotosValidos.Text = "Votos válidos:";
            // 
            // lblVotosBranco
            // 
            this.lblVotosBranco.AutoSize = true;
            this.lblVotosBranco.Location = new System.Drawing.Point(12, 98);
            this.lblVotosBranco.Name = "lblVotosBranco";
            this.lblVotosBranco.Size = new System.Drawing.Size(99, 15);
            this.lblVotosBranco.TabIndex = 2;
            this.lblVotosBranco.Text = "Votos em branco:";
            // 
            // lblVotosNulo
            // 
            this.lblVotosNulo.AutoSize = true;
            this.lblVotosNulo.Location = new System.Drawing.Point(12, 136);
            this.lblVotosNulo.Name = "lblVotosNulo";
            this.lblVotosNulo.Size = new System.Drawing.Size(66, 15);
            this.lblVotosNulo.TabIndex = 3;
            this.lblVotosNulo.Text = "Votos nulo:";
            // 
            // txtTotalEleitores
            // 
            this.txtTotalEleitores.Location = new System.Drawing.Point(132, 19);
            this.txtTotalEleitores.Name = "txtTotalEleitores";
            this.txtTotalEleitores.Size = new System.Drawing.Size(100, 23);
            this.txtTotalEleitores.TabIndex = 4;
            // 
            // txtVotosValidos
            // 
            this.txtVotosValidos.Location = new System.Drawing.Point(132, 57);
            this.txtVotosValidos.Name = "txtVotosValidos";
            this.txtVotosValidos.Size = new System.Drawing.Size(100, 23);
            this.txtVotosValidos.TabIndex = 5;
            // 
            // txtVotosBranco
            // 
            this.txtVotosBranco.Location = new System.Drawing.Point(132, 95);
            this.txtVotosBranco.Name = "txtVotosBranco";
            this.txtVotosBranco.Size = new System.Drawing.Size(100, 23);
            this.txtVotosBranco.TabIndex = 6;
            // 
            // txtVotosNulo
            // 
            this.txtVotosNulo.Location = new System.Drawing.Point(132, 133);
            this.txtVotosNulo.Name = "txtVotosNulo";
            this.txtVotosNulo.Size = new System.Drawing.Size(100, 23);
            this.txtVotosNulo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 174);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(220, 36);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 226);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVotosNulo);
            this.Controls.Add(this.txtVotosBranco);
            this.Controls.Add(this.txtVotosValidos);
            this.Controls.Add(this.txtTotalEleitores);
            this.Controls.Add(this.lblVotosNulo);
            this.Controls.Add(this.lblVotosBranco);
            this.Controls.Add(this.lblVotosValidos);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTotal;
        private Label lblVotosValidos;
        private Label lblVotosBranco;
        private Label lblVotosNulo;
        private TextBox txtTotalEleitores;
        private TextBox txtVotosValidos;
        private TextBox txtVotosBranco;
        private TextBox txtVotosNulo;
        private Button btnCalcular;
    }
}