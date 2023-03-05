namespace Ex2
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
            this.txtGolsTime1 = new System.Windows.Forms.TextBox();
            this.txtNomeTime1 = new System.Windows.Forms.TextBox();
            this.lblGolsTime1 = new System.Windows.Forms.Label();
            this.lblNomeTime1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGolsTime2 = new System.Windows.Forms.TextBox();
            this.txtNomeTime2 = new System.Windows.Forms.TextBox();
            this.lblGolsTime2 = new System.Windows.Forms.Label();
            this.lblNomeTime2 = new System.Windows.Forms.Label();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGolsTime1);
            this.groupBox1.Controls.Add(this.txtNomeTime1);
            this.groupBox1.Controls.Add(this.lblGolsTime1);
            this.groupBox1.Controls.Add(this.lblNomeTime1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time 1";
            // 
            // txtGolsTime1
            // 
            this.txtGolsTime1.Location = new System.Drawing.Point(100, 64);
            this.txtGolsTime1.Name = "txtGolsTime1";
            this.txtGolsTime1.Size = new System.Drawing.Size(100, 23);
            this.txtGolsTime1.TabIndex = 3;
            // 
            // txtNomeTime1
            // 
            this.txtNomeTime1.Location = new System.Drawing.Point(100, 27);
            this.txtNomeTime1.Name = "txtNomeTime1";
            this.txtNomeTime1.Size = new System.Drawing.Size(100, 23);
            this.txtNomeTime1.TabIndex = 2;
            // 
            // lblGolsTime1
            // 
            this.lblGolsTime1.AutoSize = true;
            this.lblGolsTime1.Location = new System.Drawing.Point(6, 67);
            this.lblGolsTime1.Name = "lblGolsTime1";
            this.lblGolsTime1.Size = new System.Drawing.Size(88, 15);
            this.lblGolsTime1.TabIndex = 1;
            this.lblGolsTime1.Text = "Gols marcados:";
            // 
            // lblNomeTime1
            // 
            this.lblNomeTime1.AutoSize = true;
            this.lblNomeTime1.Location = new System.Drawing.Point(6, 30);
            this.lblNomeTime1.Name = "lblNomeTime1";
            this.lblNomeTime1.Size = new System.Drawing.Size(43, 15);
            this.lblNomeTime1.TabIndex = 0;
            this.lblNomeTime1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGolsTime2);
            this.groupBox2.Controls.Add(this.txtNomeTime2);
            this.groupBox2.Controls.Add(this.lblGolsTime2);
            this.groupBox2.Controls.Add(this.lblNomeTime2);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time 2";
            // 
            // txtGolsTime2
            // 
            this.txtGolsTime2.Location = new System.Drawing.Point(100, 63);
            this.txtGolsTime2.Name = "txtGolsTime2";
            this.txtGolsTime2.Size = new System.Drawing.Size(100, 23);
            this.txtGolsTime2.TabIndex = 3;
            // 
            // txtNomeTime2
            // 
            this.txtNomeTime2.Location = new System.Drawing.Point(100, 24);
            this.txtNomeTime2.Name = "txtNomeTime2";
            this.txtNomeTime2.Size = new System.Drawing.Size(100, 23);
            this.txtNomeTime2.TabIndex = 2;
            // 
            // lblGolsTime2
            // 
            this.lblGolsTime2.AutoSize = true;
            this.lblGolsTime2.Location = new System.Drawing.Point(6, 66);
            this.lblGolsTime2.Name = "lblGolsTime2";
            this.lblGolsTime2.Size = new System.Drawing.Size(88, 15);
            this.lblGolsTime2.TabIndex = 1;
            this.lblGolsTime2.Text = "Gols Marcados:";
            // 
            // lblNomeTime2
            // 
            this.lblNomeTime2.AutoSize = true;
            this.lblNomeTime2.Location = new System.Drawing.Point(6, 27);
            this.lblNomeTime2.Name = "lblNomeTime2";
            this.lblNomeTime2.Size = new System.Drawing.Size(43, 15);
            this.lblNomeTime2.TabIndex = 0;
            this.lblNomeTime2.Text = "Nome:";
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(12, 230);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(212, 35);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 270);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private TextBox txtGolsTime1;
        private TextBox txtNomeTime1;
        private Label lblGolsTime1;
        private Label lblNomeTime1;
        private GroupBox groupBox2;
        private TextBox txtGolsTime2;
        private TextBox txtNomeTime2;
        private Label lblGolsTime2;
        private Label lblNomeTime2;
        private Button btnAnalisar;
    }
}