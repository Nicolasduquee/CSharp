namespace exercicio4AppJanela
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
            this.cbRam = new System.Windows.Forms.ComboBox();
            this.cbProcessador = new System.Windows.Forms.ComboBox();
            this.cbTela = new System.Windows.Forms.ComboBox();
            this.cbPag = new System.Windows.Forms.ComboBox();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblProcessador = new System.Windows.Forms.Label();
            this.lblTela = new System.Windows.Forms.Label();
            this.lblPag = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbRam
            // 
            this.cbRam.FormattingEnabled = true;
            this.cbRam.Items.AddRange(new object[] {
            "4 GB - R$ 250,00",
            "8 GB - R$ 350,00",
            "16 GB - R$ 599,00"});
            this.cbRam.Location = new System.Drawing.Point(109, 24);
            this.cbRam.Name = "cbRam";
            this.cbRam.Size = new System.Drawing.Size(121, 23);
            this.cbRam.TabIndex = 0;
            // 
            // cbProcessador
            // 
            this.cbProcessador.FormattingEnabled = true;
            this.cbProcessador.Items.AddRange(new object[] {
            "I3 - R$ 400,00",
            "I5 - R$ 700,00",
            "I7 - R$ 1049,00"});
            this.cbProcessador.Location = new System.Drawing.Point(109, 66);
            this.cbProcessador.Name = "cbProcessador";
            this.cbProcessador.Size = new System.Drawing.Size(121, 23);
            this.cbProcessador.TabIndex = 1;
            // 
            // cbTela
            // 
            this.cbTela.FormattingEnabled = true;
            this.cbTela.Items.AddRange(new object[] {
            "13 pol - R$ 300,00",
            "14 pol -  R$ 650,00",
            "15 pol - R$ 999,00"});
            this.cbTela.Location = new System.Drawing.Point(109, 108);
            this.cbTela.Name = "cbTela";
            this.cbTela.Size = new System.Drawing.Size(121, 23);
            this.cbTela.TabIndex = 2;
            // 
            // cbPag
            // 
            this.cbPag.FormattingEnabled = true;
            this.cbPag.Items.AddRange(new object[] {
            "À vista",
            "Parcelado"});
            this.cbPag.Location = new System.Drawing.Point(109, 148);
            this.cbPag.Name = "cbPag";
            this.cbPag.Size = new System.Drawing.Size(121, 23);
            this.cbPag.TabIndex = 3;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(12, 27);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(84, 15);
            this.lblRam.TabIndex = 4;
            this.lblRam.Text = "Memória RAM";
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.Location = new System.Drawing.Point(12, 69);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(71, 15);
            this.lblProcessador.TabIndex = 5;
            this.lblProcessador.Text = "Processador";
            // 
            // lblTela
            // 
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(12, 111);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(94, 15);
            this.lblTela.TabIndex = 6;
            this.lblTela.Text = "Tamanho da tela";
            // 
            // lblPag
            // 
            this.lblPag.AutoSize = true;
            this.lblPag.Location = new System.Drawing.Point(12, 151);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(68, 15);
            this.lblPag.TabIndex = 7;
            this.lblPag.Text = "Pagamento";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 191);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(218, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular valor";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 235);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(109, 232);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(121, 23);
            this.txtValor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 274);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPag);
            this.Controls.Add(this.lblTela);
            this.Controls.Add(this.lblProcessador);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.cbPag);
            this.Controls.Add(this.cbTela);
            this.Controls.Add(this.cbProcessador);
            this.Controls.Add(this.cbRam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbRam;
        private ComboBox cbProcessador;
        private ComboBox cbTela;
        private ComboBox cbPag;
        private Label lblRam;
        private Label lblProcessador;
        private Label lblTela;
        private Label lblPag;
        private Button btnCalcular;
        private Label lblValor;
        private TextBox txtValor;
    }
}