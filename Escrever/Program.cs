namespace Escrever
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('*', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }

        static void Main(string[] args)
        {
            Escrever("Samuel Ferreira Carvalho Mariano");
            Console.WriteLine();
            Escrever("Curso#");
            Console.WriteLine();
            Escrever("Senac - L13");
            Console.WriteLine();
        }
    }
}
