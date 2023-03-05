int N;
int NFatorial;


Console.WriteLine("Digite o valor de N:");
N = int.Parse(Console.ReadLine());

int M = N;
int F = N;

do {
    M--;

    F = F * M;
} while (M > 0);

if (F > 0) {
    double E = 1 + 1 / 1 + 1 / 2 + 1 / 6 + 1 / F; 
}

Console.WriteLine("O resultado da expressão E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + 1 / N! é: " + F);

