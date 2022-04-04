using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio46
    {
        static void Main46(string[] args)
        {
            int qtdNums;
            int multResultado = 0;

            Console.WriteLine("Quantos números deseja inserir: ");
            qtdNums = int.Parse(Console.ReadLine());

            int[] vetNumX = new int[qtdNums];
            int[] vetNumY = new int[qtdNums];

            for (int i = 0; i < qtdNums; i++)
            {
                Console.WriteLine($"\nInsira um número para vetor X: ");
                vetNumX[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < qtdNums; i++)
            {
                Console.WriteLine($"\nInsira um número para vetor Y: ");
                vetNumY[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < qtdNums; i++)
            {
                Console.WriteLine($"\n{vetNumX[i]} x {vetNumY[i]} = {vetNumX[i]*vetNumY[i]}");
                multResultado += vetNumX[i] * vetNumY[i];
            }

            Console.WriteLine($"\nO resultado da soma de todas as multiplicações é: {multResultado}");
        }
    }
}
