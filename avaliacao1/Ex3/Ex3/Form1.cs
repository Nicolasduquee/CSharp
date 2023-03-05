namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double eleitores = Convert.ToDouble(txtTotalEleitores.Text);
            double votosValidos = Convert.ToDouble(txtVotosValidos.Text);
            double votosBranco = Convert.ToDouble(txtVotosBranco.Text);
            double votosNulo = Convert.ToDouble(txtVotosNulo.Text);

            double porValidos = (votosValidos * 100) / eleitores;
            double porBranco = (votosBranco * 100) / eleitores;
            double porNulo = (votosNulo * 100) / eleitores;

            MessageBox.Show("O percentual de votos válidos é de " + porValidos + "%.");
            MessageBox.Show("O percentual de votos em branco é de " + porBranco + "%.");
            MessageBox.Show("O percentual de votos nulo é de " + porNulo + "%.");
        }
    }
}