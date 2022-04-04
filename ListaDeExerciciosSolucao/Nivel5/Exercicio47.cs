using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio47
    {
        static void Main47(string[] args)
        {
            int valNum;
            int contMaior = 0;
            int contMenor = 0;
            int contIgual = 0;
            int[] vetNums = new int[10];

            Console.WriteLine("Insira um valor para comparar os números: ");
            valNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Insira um número: ");
                vetNums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (vetNums[i] > valNum)
                {
                    contMaior++;
                }
                else if (vetNums[i] < valNum)
                {
                    contMenor++;
                }
                else if (vetNums[i] == valNum)
                {
                    contIgual++;
                }
            }

            Console.WriteLine($"\nQuantos números maiores que {valNum}: {contMaior}");
            Console.WriteLine($"\nQuantos números menores que {valNum}: {contMenor}");
            Console.WriteLine($"\nQuantos números iguais a {valNum}: {contIgual}");
        }
    }
}
