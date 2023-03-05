Console.WriteLine("Digite o valor base da tabuada: ");
double valorBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o número de linhas da tabuada: ");
double valorLinhas = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= valorLinhas; i++)
{
    double conta = valorBase * i;

    Console.WriteLine(valorBase + " * " + i + " = " + conta);
}