using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio6
    {
        static void Main6(string[] args)
        {
            int tempC;
            int tempF;

            Console.WriteLine("Digite a temperatura em Celcius para converter para Fahrenheit: ");
            tempC = int.Parse(Console.ReadLine());

            tempF = (9 * tempC + 160) / 5;

            Console.WriteLine($"A temperatura em Fahrenheit é: {tempF}°");
        }
    }
}
