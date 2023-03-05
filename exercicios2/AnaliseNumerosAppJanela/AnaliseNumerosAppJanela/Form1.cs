namespace AnaliseNumerosAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            double valor3 = Convert.ToDouble(txtValor3.Text);

            if (valor1 > 0)
            {
                double dobro = valor1 * 2;
                MessageBox.Show("Dobro = " + dobro);
            }

            else
            {
                double triplo = valor1 * 3;
                MessageBox.Show("Triplo = " + triplo);
            }

            if (valor2 > 10 && valor2 < 100)
            {
                MessageBox.Show("Intervalo permitido");
            }

            if (valor3 > valor2)
            {
                double diferenca = valor3 - valor2;
                MessageBox.Show("A diferença é de " + diferenca);
            }

            else
            {
                double adicao = valor3++;
                MessageBox.Show("Adição = " + adicao);
            }

        }
    }
}