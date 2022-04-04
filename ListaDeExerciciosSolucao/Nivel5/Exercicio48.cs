using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio48
    {
        static void Main48(string[] args)
        {
            int valAptas = 0;
            int valDesclas = 0;
            string[] vetNomes = new string[20];
            int[] vetIdades = new int[20];

            Console.WriteLine("\nInsira as informações das candidatas que estão concorrendo a vaga. ");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\nNome: ");
                vetNomes[i] = Console.ReadLine();

                Console.WriteLine("\nIdade: ");
                vetIdades[i] = int.Parse(Console.ReadLine());

                if(vetIdades[i] > 18 && vetIdades[i] < 20)
                {
                    valAptas++;
                }
                else
                {
                    valDesclas++;
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (vetIdades[i] >= 18 && vetIdades[i] <= 20)
                {
                    Console.WriteLine($"Classificada: {vetNomes[i]} tem {vetIdades[i]} anos.");
                }
                else
                {
                    Console.WriteLine($"Desclassificada: {vetNomes[i]} tem {vetIdades[i]} anos.");
                }
            }

        }
    }
}
