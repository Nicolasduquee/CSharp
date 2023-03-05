namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double anos = Convert.ToDouble(txtAnos.Text);
            double meses = Convert.ToDouble(txtMeses.Text);
            double dias = Convert.ToDouble(txtDias.Text);
            double idadeDias = (anos * 365) + (meses * 30) + dias;

            MessageBox.Show("Sua idade é de " + idadeDias + " dias.");
        }
    }
}