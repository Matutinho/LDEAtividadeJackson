using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio7
    {
        static void Main7(string[] args)
        {
            int tempF;
            int tempC;

            Console.WriteLine("Digite a temperatura em Fahrenheit para converter para Celcius: ");
            tempF = int.Parse(Console.ReadLine());

            tempC = (tempF - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celcius é: {tempC}°");
        }
    }
}
