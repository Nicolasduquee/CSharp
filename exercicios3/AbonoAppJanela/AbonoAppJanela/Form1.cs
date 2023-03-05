namespace AbonoAppJanela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioBruto = Convert.ToDouble(txtSalBruto.Text);
            double salarioLiquido = 0;
            double abonoPorDependente = salarioBruto * 0.03;
            double abono = 0;

            switch (cbDependentes.SelectedIndex)
            {
                case 0:
                    abonoPorDependente = 0;
                    abono = 0;
                    salarioLiquido = salarioBruto + abonoPorDependente;
                break;

                case 1:
                    salarioLiquido = salarioBruto + abonoPorDependente;
                    abono = abonoPorDependente * 1;
                break;

                case 2:
                    salarioLiquido = salarioBruto + (abonoPorDependente * 2);
                    abono = abonoPorDependente * 2;
                    break;

                case 3:
                    salarioLiquido = salarioBruto + (abonoPorDependente * 3);
                    abono = abonoPorDependente * 3;
                    break;

                case 4:
                    salarioLiquido = salarioBruto + (abonoPorDependente * 4);
                    abono = abonoPorDependente * 4;
                    break;

                case 5:
                    abonoPorDependente = salarioBruto * 0.15;
                    salarioLiquido = salarioBruto + abonoPorDependente;
                    abono = abonoPorDependente;
                    break;

                case 6:
                    abonoPorDependente = salarioBruto * 0.15;
                    salarioLiquido = salarioBruto + abonoPorDependente;
                    abono = abonoPorDependente;
                    break;
            }

            txtSalLiquido.Text = salarioLiquido.ToString();
            txtAbono.Text = abono.ToString();

        }
    }
}