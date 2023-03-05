namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            double golsTime1 = Convert.ToDouble(txtGolsTime1.Text);
            double golsTime2 = Convert.ToDouble(txtGolsTime2.Text);

            if (golsTime1 > golsTime2)
            {
                MessageBox.Show("O vencedor da partida foi: " + txtNomeTime1.Text + ".");
            }
            else if (golsTime1 < golsTime2)
            {
                MessageBox.Show("O vencedor da partida foi: " + txtNomeTime2.Text + ".");
            }
            else
            {
                MessageBox.Show("A partida terminou empatada.");
            }
        }
    }
}