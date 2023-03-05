namespace CalculoImpostoAppJanela
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
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.cbEmbalagem = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorBruto = new System.Windows.Forms.Label();
            this.lblAcrecimos = new System.Windows.Forms.Label();
            this.lblValorLiquido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 19);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 52);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(69, 15);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(12, 86);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(47, 15);
            this.lblOrigem.TabIndex = 2;
            this.lblOrigem.Text = "Origem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Embalagem especial";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(133, 16);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(133, 49);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 5;
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Items.AddRange(new object[] {
            "Animal",
            "Vegetal",
            "Outros"});
            this.cbOrigem.Location = new System.Drawing.Point(133, 83);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(100, 23);
            this.cbOrigem.TabIndex = 6;
            // 
            // cbEmbalagem
            // 
            this.cbEmbalagem.FormattingEnabled = true;
            this.cbEmbalagem.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbEmbalagem.Location = new System.Drawing.Point(133, 115);
            this.cbEmbalagem.Name = "cbEmbalagem";
            this.cbEmbalagem.Size = new System.Drawing.Size(100, 23);
            this.cbEmbalagem.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(221, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorBruto
            // 
            this.lblValorBruto.AutoSize = true;
            this.lblValorBruto.Location = new System.Drawing.Point(12, 196);
            this.lblValorBruto.Name = "lblValorBruto";
            this.lblValorBruto.Size = new System.Drawing.Size(65, 15);
            this.lblValorBruto.TabIndex = 9;
            this.lblValorBruto.Text = "Valor Bruto";
            // 
            // lblAcrecimos
            // 
            this.lblAcrecimos.AutoSize = true;
            this.lblAcrecimos.Location = new System.Drawing.Point(12, 226);
            this.lblAcrecimos.Name = "lblAcrecimos";
            this.lblAcrecimos.Size = new System.Drawing.Size(63, 15);
            this.lblAcrecimos.TabIndex = 10;
            this.lblAcrecimos.Text = "Acrécimos";
            // 
            // lblValorLiquido
            // 
            this.lblValorLiquido.AutoSize = true;
            this.lblValorLiquido.Location = new System.Drawing.Point(12, 256);
            this.lblValorLiquido.Name = "lblValorLiquido";
            this.lblValorLiquido.Size = new System.Drawing.Size(76, 15);
            this.lblValorLiquido.TabIndex = 11;
            this.lblValorLiquido.Text = "Valor Líquido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 289);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValorLiquido);
            this.Controls.Add(this.lblAcrecimos);
            this.Controls.Add(this.lblValorBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbEmbalagem);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValor;
        private Label lblQuantidade;
        private Label lblOrigem;
        private Label label4;
        private TextBox txtValor;
        private TextBox txtQuantidade;
        private ComboBox cbOrigem;
        private ComboBox cbEmbalagem;
        private Button btnCalcular;
        private Label lblValorBruto;
        private Label lblAcrecimos;
        private Label lblValorLiquido;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}