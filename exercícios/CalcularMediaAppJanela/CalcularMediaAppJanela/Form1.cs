namespace CalcularMediaAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        double nota1 = Convert.ToDouble(txtNota1.Text);
        double nota2 = Convert.ToDouble(txtNota2.Text);
        double nota3 = Convert.ToDouble(txtNota3.Text);
        double nota4 = Convert.ToDouble(txtNota4.Text);
        double mediaAritmetica = ((nota1 + nota2 + nota3 + nota4) / 4);
        double mediaPonderada = ((nota1 + nota2 + nota3) / 3) * 0.3 + (nota4 * 0.7);

        txtMediaAritmetica.Text = mediaAritmetica.ToString();
        txtMediaPonderada.Text = mediaPonderada.ToString();
        }
    }
}