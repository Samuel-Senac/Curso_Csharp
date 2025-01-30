namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 3];

            matriz[0, 0] = 10;
            matriz[0, 1] = 15;
            matriz[0, 2] = 20;

            matriz[1, 0] = 25;
            matriz[1, 1] = 30;
            matriz[1, 2] = 35;

            matriz[2, 0] = 40;
            matriz[2, 1] = 45;
            matriz[2, 2] = 50;

            matriz[3, 0] = 55;
            matriz[3, 1] = 60;
            matriz[3, 2] = 65;

            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matriz[l, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
