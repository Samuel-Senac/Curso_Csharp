namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite a nota do primeiro bimestre");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo bimestre:");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = (num1 + num2) / 2;

            Console.WriteLine("A média de ({0} + {1}) / 2 = {2}", num1, num2, num3);

        }
    }
}
