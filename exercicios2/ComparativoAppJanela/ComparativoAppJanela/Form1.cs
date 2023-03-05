namespace ComparativoAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);

            if ( valor1 > valor2)
            {
                MessageBox.Show(valor1 + " é o maior valor.");
            }

            else if (valor1 == valor2)
            {
                MessageBox.Show("Os valores são iguais.");
            }

            else
            {
                MessageBox.Show(valor2 + " é o maior valor.");
            }
        }
    }
}