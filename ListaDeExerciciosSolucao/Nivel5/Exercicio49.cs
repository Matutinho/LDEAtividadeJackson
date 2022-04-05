using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio49
    {
        static void Main49(string[] args)
        {
            int tamVets;
            int valIgual = 0;
            int valDiferente = 0;

            Console.WriteLine("Insira a quantidade de números que deseja comparar: ");
            tamVets = int.Parse(Console.ReadLine());

            int[] vetV1 = new int[tamVets];
            int[] vetV2 = new int[tamVets];

            for (int i = 0; i < tamVets; i++)
            {
                Console.WriteLine("\nInsira um valor para V1: ");
                vetV1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInsira um valor para V2: ");
                vetV2[i] = int.Parse(Console.ReadLine());

                if (vetV1[i] == vetV2[i])
                {
                    valIgual++;
                }
                else
                {
                    valDiferente++;
                }
            }

            Console.WriteLine($"\nExistem {valIgual} números iguais e {valDiferente} diferentes.");
        }
    }
}
