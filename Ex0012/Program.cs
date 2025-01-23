namespace Ex0012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i ++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("O programa deu certo(mais ou menos)!");
            Console.WriteLine("------------------------------------");
        }
    }
}
