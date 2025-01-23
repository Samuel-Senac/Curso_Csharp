namespace Ex0012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.Write("Digite um número: ");
            final = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= final; i ++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0}, ",i);
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("O programa deu certo!(mais ou menos!)");
            Console.WriteLine("------------------------------------");
        }
    }
}
