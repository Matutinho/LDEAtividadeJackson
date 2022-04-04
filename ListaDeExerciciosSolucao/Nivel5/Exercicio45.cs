using System;

namespace Nivel5
{
    class Program
    {
        static void Main45(string[] args)
        {
            int qtdNums;

            Console.WriteLine("Quantos números deseja inserir: ");
            qtdNums = int.Parse(Console.ReadLine());

            int[] vetNums = new int[qtdNums];

            for (int i = 0; i < qtdNums; i++)
            {
                Console.WriteLine($"\nInsira um número: ");
                vetNums[i] = int.Parse(Console.ReadLine());
            }

            qtdNums--;

            for (int i = qtdNums; i >= 0; i--)
            {
                Console.WriteLine("");
                Console.WriteLine($"Número: {vetNums[i]}");
            }
        }
    }
}
