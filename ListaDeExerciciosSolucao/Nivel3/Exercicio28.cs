using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio28
    {
        static void Main28(string[] args)
        {
            string concImpares = "";
            int valResultado;

            Console.WriteLine("Números impares de 100 até 200.");

            for (int i = 100; i <= 200; i++)
            {
                valResultado = i % 2;
                if (valResultado == 1)
                {
                    concImpares += "," + i.ToString();
                }
                else if (i == 200)
                {
                    Console.WriteLine($"{concImpares}");
                }
            }
        }
    }
}
