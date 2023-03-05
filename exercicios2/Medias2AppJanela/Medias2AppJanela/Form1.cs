namespace Medias2AppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

            if (media >= 6)
            {
                MessageBox.Show("A Media foi " + media + ". Você foi aprovado!");
            }
            else
            {
                MessageBox.Show("A Media foi " + media + ". Você foi reprovado!");
            }
        }
    }
}