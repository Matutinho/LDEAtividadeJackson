using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio50
    {
        static void Main50(string[] args)
        {
            int valTentar;
            Random valRandom = new Random();

            int[] vetSorte = new int[1];

            vetSorte[0] = valRandom.Next(1,101);

            Console.WriteLine($"Acerte o número: ");
            valTentar = int.Parse(Console.ReadLine());

            if (valTentar == vetSorte[0])
            {
                Console.WriteLine($"Você acertou, o número sorteado é {vetSorte[0]}");
            }
            else if (valTentar > vetSorte[0])
            {
                Console.WriteLine($"Você errou! Número superior ao número sorteado, a resposta certa era {vetSorte[0]}");
            }
            else if (valTentar < vetSorte[0])
            {
                Console.WriteLine($"Você errou! Número inferior ao número sorteado, a resposta certa era {vetSorte[0]}");
            }
        }
    }
}
