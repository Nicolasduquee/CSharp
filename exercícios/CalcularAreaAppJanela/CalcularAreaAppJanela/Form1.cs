namespace CalcularAreaAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcularQuadrado_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtLado.Text);
            double areaQuadrado = lado * lado;
            txtResultadoQuadrado.Text = areaQuadrado.ToString();

        }

        private void btnCalcularRetangulo_Click(object sender, EventArgs e)
        {
            double baseRetangulo = Convert.ToDouble(txtBaseRetantgulo.Text);
            double alturaRetangulo = Convert.ToDouble(txtAlturaRetangulo.Text);
            double areaRetangulo = (baseRetangulo * alturaRetangulo);

            txtResultadoRetangulo.Text = areaRetangulo.ToString();
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            double baseTriangulo = Convert.ToDouble(txtBaseTriangulo.Text);
            double alturaTriangulo = Convert.ToDouble(txtAlturaTriangulo.Text);
            double areaTriangulo = (( baseTriangulo * alturaTriangulo)/2);

            txtResultadoTriangulo.Text = areaTriangulo.ToString();

        }
    }
}