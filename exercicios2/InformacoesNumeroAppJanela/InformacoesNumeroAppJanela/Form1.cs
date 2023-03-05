namespace InformacoesNumeroAppJanela
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

            if (valor > 0)
            {
                txtPoN.Text = "Positivo.";
            } 

            else
            {
                txtPoN.Text = "Negativo.";
            }

            if (valor % 2 == 0)
            {
                txtIoP.Text = "Par.";
            }

            else
            {
                txtIoP.Text = "Ímpar.";
            }
        }
    }
}