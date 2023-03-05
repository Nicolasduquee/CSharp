namespace SomaNumerosAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text.Length == 0 || txtValor2.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira um valor!", "Erro nos valores");
            }

            else
            { 
            double valor1, valor2, resultado;

            bool is_valor1_ok = double.TryParse(txtValor1.Text, out valor1);
            bool is_valor2_ok = double.TryParse(txtValor2.Text, out valor2);

            if (is_valor1_ok && is_valor2_ok)
            { 

                resultado = valor1 + valor2;

                txtResultado.Text = resultado.ToString();
             }

            else
                {
                    MessageBox.Show("Valores inválidos!", "Erro nos valores");
                }

            }
        }
    }
}