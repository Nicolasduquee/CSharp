namespace exercicioo2AppJanela
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
            this.components = new System.ComponentModel.Container();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFatorial = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtFatorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(4, 20);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // lblFatorial
            // 
            this.lblFatorial.AutoSize = true;
            this.lblFatorial.Location = new System.Drawing.Point(4, 100);
            this.lblFatorial.Name = "lblFatorial";
            this.lblFatorial.Size = new System.Drawing.Size(46, 15);
            this.lblFatorial.TabIndex = 1;
            this.lblFatorial.Text = "Fatorial";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(4, 54);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(158, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(56, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 23);
            this.txtValor.TabIndex = 4;
            // 
            // txtFatorial
            // 
            this.txtFatorial.Location = new System.Drawing.Point(56, 97);
            this.txtFatorial.Name = "txtFatorial";
            this.txtFatorial.ReadOnly = true;
            this.txtFatorial.Size = new System.Drawing.Size(106, 23);
            this.txtFatorial.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 130);
            this.Controls.Add(this.txtFatorial);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblFatorial);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Fatorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValor;
        private Label lblFatorial;
        private Button btnCalcular;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtValor;
        private TextBox txtFatorial;
    }
}