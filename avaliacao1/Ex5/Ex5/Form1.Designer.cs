namespace Ex5
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
            this.lblQtdPera = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtQtdPera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQtdPera
            // 
            this.lblQtdPera.AutoSize = true;
            this.lblQtdPera.Location = new System.Drawing.Point(12, 28);
            this.lblQtdPera.Name = "lblQtdPera";
            this.lblQtdPera.Size = new System.Drawing.Size(119, 15);
            this.lblQtdPera.TabIndex = 0;
            this.lblQtdPera.Text = "Quantidade de peras:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(11, 64);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(260, 38);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular valor";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtQtdPera
            // 
            this.txtQtdPera.Location = new System.Drawing.Point(153, 25);
            this.txtQtdPera.Name = "txtQtdPera";
            this.txtQtdPera.Size = new System.Drawing.Size(119, 23);
            this.txtQtdPera.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 116);
            this.Controls.Add(this.txtQtdPera);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblQtdPera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Valor peras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQtdPera;
        private Button btnCalcular;
        private TextBox txtQtdPera;
    }
}