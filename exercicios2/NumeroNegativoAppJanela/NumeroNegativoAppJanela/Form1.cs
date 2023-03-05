namespace NumeroNegativoAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (valor < 0.0)
            {
                MessageBox.Show("O valor informado é negativo");
            }

            else
            {
                MessageBox.Show("O valor informado não é negativo");
            }
        }
    }
}