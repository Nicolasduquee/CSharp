namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double qtdPera = Convert.ToDouble(txtQtdPera.Text);

            if (qtdPera >= 12)
            {
                double valor = qtdPera * 1.00;
                MessageBox.Show("O valor total da compra é de R$" + valor);
            }
            else
            {
                double valor = qtdPera * 1.50;
                MessageBox.Show("O valor total da compra é de R$" + valor);
            }
        }
    }
}