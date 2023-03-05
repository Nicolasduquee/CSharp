namespace AbonoAppJanela
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
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblDependentes = new System.Windows.Forms.Label();
            this.lblAbono = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.cbDependentes = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(17, 19);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(74, 15);
            this.lblSalBruto.TabIndex = 0;
            this.lblSalBruto.Text = "Salário bruto";
            // 
            // lblDependentes
            // 
            this.lblDependentes.AutoSize = true;
            this.lblDependentes.Location = new System.Drawing.Point(17, 59);
            this.lblDependentes.Name = "lblDependentes";
            this.lblDependentes.Size = new System.Drawing.Size(76, 15);
            this.lblDependentes.TabIndex = 1;
            this.lblDependentes.Text = "Dependentes";
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(17, 138);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(43, 15);
            this.lblAbono.TabIndex = 2;
            this.lblAbono.Text = "Abono";
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(17, 176);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(82, 15);
            this.lblSalLiquido.TabIndex = 3;
            this.lblSalLiquido.Text = "Salário líquido";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(106, 16);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(114, 23);
            this.txtSalBruto.TabIndex = 4;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(106, 135);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.ReadOnly = true;
            this.txtAbono.Size = new System.Drawing.Size(114, 23);
            this.txtAbono.TabIndex = 5;
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Location = new System.Drawing.Point(106, 173);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.ReadOnly = true;
            this.txtSalLiquido.Size = new System.Drawing.Size(114, 23);
            this.txtSalLiquido.TabIndex = 6;
            // 
            // cbDependentes
            // 
            this.cbDependentes.FormattingEnabled = true;
            this.cbDependentes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "mais"});
            this.cbDependentes.Location = new System.Drawing.Point(106, 56);
            this.cbDependentes.Name = "cbDependentes";
            this.cbDependentes.Size = new System.Drawing.Size(114, 23);
            this.cbDependentes.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(17, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(203, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 206);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbDependentes);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.lblDependentes);
            this.Controls.Add(this.lblSalBruto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSalBruto;
        private Label lblDependentes;
        private Label lblAbono;
        private Label lblSalLiquido;
        private TextBox txtSalBruto;
        private TextBox txtAbono;
        private TextBox txtSalLiquido;
        private ComboBox cbDependentes;
        private Button btnCalcular;
    }
}