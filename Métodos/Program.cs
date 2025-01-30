namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Samuel Ferreira");
            Soma(10, 20);
        }
        static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá {nome}, seja bem-vindo!");
        }

        static void Soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
            Console.WriteLine("A soma de {0} + {1} é igual a {3}.", a, b, resultado);
            Console.WriteLine("A soma de " + a + " + " + b + " é igual a " + resultado + ".");
        }
    }
}
