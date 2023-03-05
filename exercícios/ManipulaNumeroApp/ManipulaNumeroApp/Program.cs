namespace ManipulaNumeroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, anterior, posterior, dobro, triplo, por25, por50, por100, por150;

            Console.WriteLine("Digite o valor desejado:");
            double.TryParse(Console.ReadLine(), out n);

            anterior = n - 1;
            Console.WriteLine("O número anterior de " + n + " é " + anterior);

            posterior = n + 1;
            Console.WriteLine("O número posterior de " + n + " é " + posterior);

            dobro = n * 2;
            Console.WriteLine("O dobro de " + n + " é = " + dobro);

            triplo = n * 3;
            Console.WriteLine("O triplo de " + n + " é = " + triplo);

            por25 = n * 0.25;
            Console.WriteLine("25% de " + n + " é = " + por25);

            por50 = n * 0.5;
            Console.WriteLine("50% de " + n + " é = " + por50);

            por100 = n * 1.0;
            Console.WriteLine("100% de " + n + " é = " + por100);

            por150 = n * 1.5;
            Console.WriteLine("150% de " + n + " é = " + por150);

            Console.ReadKey();
        }
    }
}
