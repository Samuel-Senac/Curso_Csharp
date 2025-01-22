namespace Ex0010
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o valor do salário recebido: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento = 0;
            double novosalario = 0;

            if (salario > 2500)
            {
                aumento = salario * 0.05;
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10;
            }
            else
            {
                aumento = salario * 0.15;
            }
            novosalario = salario + aumento;

            Console.WriteLine($"O valor do aumento é R${aumento:0}");
            
        }
    }
}
