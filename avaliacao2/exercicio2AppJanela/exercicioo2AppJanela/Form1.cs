namespace exercicioo2AppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (valor <= 0)
            {
                MessageBox.Show("O número digitado é inválido!");
            }
            else
            {
                double fatorial = valor;

                for (double i = valor - 1 ; i >= 1; i--)
                {
                    fatorial = fatorial * i;
                }

                txtFatorial.Text = fatorial.ToString();
            }
        }
    }
}