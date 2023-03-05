Console.WriteLine("Digite o primeiro valor do intervalo:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o último valor do intervalo:");
int n2 = Convert.ToInt32(Console.ReadLine());

double soma = 0;
double somaPar = 0;
double somaImpar = 0;
double i = n1;

do
{
    soma = soma + i;

    if (i % 2 == 0)
    {
        somaPar = somaPar + i;
    }
    else
    {
        somaImpar = somaImpar + i;
    }

    i++;
} while (i <= n2);

Console.WriteLine("A soma dos números do intervalo é: " + soma);
Console.WriteLine("A soma dos números pares do intervalo é: " + somaPar);
Console.WriteLine("A soma dos números ímpares do intervalo é: " + somaImpar);