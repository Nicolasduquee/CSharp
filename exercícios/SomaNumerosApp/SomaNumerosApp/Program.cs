namespace SomaNumerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Entre com o primeiro valor:");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Entre com o segundo valor:");
            int.TryParse(Console.ReadLine(), out b);

            soma = a + b;

            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();
        }
    }
}
