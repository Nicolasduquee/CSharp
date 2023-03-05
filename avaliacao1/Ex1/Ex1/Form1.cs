namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            double aAtual = Convert.ToDouble(txtAnoAtual.Text);
            double aNascimento = Convert.ToDouble(txtAnoNascimento.Text);
            double idade = aAtual - aNascimento;

            if (idade >= 16)
            {
                MessageBox.Show("Você está apto para votar no ano de " + aAtual);
            }
            else
            {
                MessageBox.Show("Você não está apto para votar no ano de " + aAtual);
            }
        }
    }
}