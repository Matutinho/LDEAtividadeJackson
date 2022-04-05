using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio53
    {
        static void Main53(string[] args)
        {
            int qtdVoltas;
            double valTempo = 0;
            double valVolta = 0;
            double valMedia = 0;

            Console.WriteLine("Quantas voltas a corrida tem: ");
            qtdVoltas = int.Parse(Console.ReadLine());

            double[] vetVoltas = new double[qtdVoltas];

            for (int i = 0; i < qtdVoltas; i++)
            {
                Console.WriteLine("Insira o tempo de duração da volta. Exemplo: 1.10 (1 minuto e 10 segundos): ");
                vetVoltas[i] = double.Parse(Console.ReadLine());

                valMedia += vetVoltas[i];

                valTempo = vetVoltas[i];
            }

            for (int i = 0; i < qtdVoltas; i++)
            {
                if (vetVoltas[i] < valTempo)
                {
                    valTempo = vetVoltas[i];
                    valVolta++;
                }
            }

            Console.WriteLine($"O melhor tempo foi | {valTempo}min | da volta número | {valVolta} |. O tempo médio das volta é de | {valMedia/qtdVoltas:f2} |.");

        }
    }
}
