// See https://aka.ms/new-console-template for more information
double salario;
double filhos;

double somaSal = 0;
double mediaSal;

double somaFilhos = 0;
double mediaFilhos;

double maiorSal = 0;

double sal1000 = 0;
double perSal1000;

double contador = 0;

do
{
    Console.WriteLine("Digite o valor do salário:");
    salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantida de filhos:");
    filhos = double.Parse(Console.ReadLine());

    if (salario >= 0) { 

    if (salario > maiorSal)
    {
        maiorSal = salario;
    }

    somaSal = somaSal + salario;
    somaFilhos = somaFilhos + filhos;
    
    if (salario <= 1000 && salario >=   0)
    {
        sal1000++;
    }


        contador++;
    }

    mediaFilhos = somaFilhos / contador;
    mediaSal = somaSal / contador;
    perSal1000 = (sal1000 * 100) / contador;
}
while (salario >= 0);

Console.WriteLine("A média do salário da populção é de: " + mediaSal + " reais.");
Console.WriteLine("A média do número de filhos da populção é de: " + mediaFilhos + " filhos.");
Console.WriteLine("O maior salário da população é de: " + maiorSal + " reais.");
Console.WriteLine("O percentual de pessoas com salário até 1000 reais é: " + perSal1000 + "%.");

