namespace exercicio4AppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = 0;

            if (cbRam.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os dados.");
            }

            else if (cbProcessador.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os dados.");
            }

            else if (cbTela.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os dados.");
            }

            else if (cbPag.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os dados.");
            }

            else
            {
                switch (cbRam.SelectedIndex)
                {
                    case 0:
                        valor = valor + 250;
                        break;

                    case 1:
                        valor = valor + 350;
                        break;

                    case 2:
                        valor = valor + 599;
                        break;
                }

                switch (cbProcessador.SelectedIndex)
                {
                    case 0:
                        valor = valor + 400;
                        break;

                    case 1:
                        valor = valor + 700;
                        break;

                    case 2:
                        valor = valor + 1049;
                        break;

                }

                switch (cbTela.SelectedIndex)
                {

                    case 0:
                        valor = valor + 300;
                        break;

                    case 1:
                        valor = valor + 650;
                        break;

                    case 2:
                        valor = valor + 999;
                        break;
                }

                switch (cbPag.SelectedIndex)
                {
                    case 0:
                        valor = valor - (valor * 0.075);
                        break;
                }

                txtValor.Text = ("R$  " + valor.ToString("N2"));
            }
        }
    }
}