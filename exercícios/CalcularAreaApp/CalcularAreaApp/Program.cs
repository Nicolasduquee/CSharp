namespace CalcularAreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int LadoQuadrado, BaseRetangulo, AlturaRetangulo, BaseTriangulo, AlturaTriangulo, AreaQuadrado, AreaRetangulo, AreaTriangulo;

            Console.WriteLine("Digite o valor do lado do quadrado:");
            int.TryParse(Console.ReadLine(), out LadoQuadrado);
            AreaQuadrado = LadoQuadrado * LadoQuadrado;
            Console.WriteLine("A área do quadrado é = " + AreaQuadrado);

            Console.WriteLine("Digite o valor da base do retângulo:");
            int.TryParse(Console.ReadLine(), out BaseRetangulo);
            Console.WriteLine("Digite o valor da altura do retângulo");
            int.TryParse(Console.ReadLine(), out AlturaRetangulo);
            AreaRetangulo = BaseRetangulo * AlturaRetangulo;
            Console.WriteLine("A área do retângulo é = " + AreaRetangulo);

            Console.WriteLine("Digite o valor da base do triângulo:");
            int.TryParse(Console.ReadLine(), out BaseTriangulo);
            Console.WriteLine("Digite o valor da altura do triângulo");
            int.TryParse(Console.ReadLine(), out AlturaTriangulo);
            AreaTriangulo = (BaseTriangulo * AlturaTriangulo) / 2;
            Console.WriteLine("A área do tirângulo é = " + AreaTriangulo);

            Console.ReadKey();
        }
    }
}
