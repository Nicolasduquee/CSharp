namespace CalcularMediasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, mediaAritmetica, mediaPonderada;

            Console.WriteLine("Digite o valor da primeira nota:");
            double.TryParse(Console.ReadLine(), out nota1);

            Console.WriteLine("Digite o valor da segunda nota:");
            double.TryParse(Console.ReadLine(), out nota2);

            Console.WriteLine("Digite o valor da terceira nota:");
            double.TryParse(Console.ReadLine(), out nota3);

            Console.WriteLine("Digite o valor da quarta nota:");
            double.TryParse(Console.ReadLine(), out nota4);

            mediaAritmetica = (nota1 + nota2 + nota3 + nota4) / 4.0;
            Console.WriteLine("A média Aritmética é = " + mediaAritmetica);

            mediaPonderada = ((nota1 + nota2 + nota3) / 3) * 0.3 + nota4 * 0.7;
            Console.WriteLine("A média Ponderada é = " + mediaPonderada);

            Console.ReadKey();
        }
    }
}