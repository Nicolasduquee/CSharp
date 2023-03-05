namespace ManipulaNumeroAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNumero.Text);
            double anterior = numero - 1.0;
            double posterior = numero + 1.0;
            double dobro = numero * 2.0;
            double triplo = numero * 3.0;
            double por25 = numero * 0.25;
            double por50 = numero * 0.5;
            double por100 = numero * 1.0;
            double por150 = numero * 1.5;

            txtAnterior.Text = anterior.ToString();
            txtPosterior.Text = posterior.ToString();
            txtDobro.Text = dobro.ToString();
            txtTriplo.Text = triplo.ToString();
            txtPor25.Text = por25.ToString();
            txtPor50.Text = por50.ToString();
            txtPor100.Text = por100.ToString();
            txtPor150.Text = por150.ToString();
        }
    }
}