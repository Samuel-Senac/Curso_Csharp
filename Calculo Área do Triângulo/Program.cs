namespace Calculo_Área_do_Triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Cálculo_de_Área_do_Trinângulo");
            Console.WriteLine("=============================");
            Console.WriteLine();

            Console.WriteLine("Digite o valor da base do triângulo");
            double ba = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do triângulo");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            BaseAltura(ba, h);

        }

        static void BaseAltura(double b, double a)
        {
            double x = (b * a) / 2;
            Console.WriteLine($"A área do triângulo de {b} * {a} / 2 é de {x}.");
        }
    }
}
