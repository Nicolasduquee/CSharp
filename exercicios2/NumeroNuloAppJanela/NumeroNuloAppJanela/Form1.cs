namespace NumeroNuloAppJanela
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

            if (valor == 0.0)
            {
                MessageBox.Show("O valor informado � = 0");
            }

            else
            {
                MessageBox.Show("O valor informado n�o � = 0");
            }
        }
    }
}