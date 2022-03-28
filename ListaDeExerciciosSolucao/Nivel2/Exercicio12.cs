using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio12
    {
        static void Main12(string[] args)
        {
            int valModulo;

            Console.WriteLine("Insira um valor para saber seu módulo: ");
            valModulo = int.Parse(Console.ReadLine());

            if (valModulo >= 0)
            {
                Console.WriteLine($"O módulo de {valModulo} é {valModulo *= -1}.");
            }
            else
            {
                Console.WriteLine($"O módulo de {valModulo} é {valModulo *= -1}.");
            }
        }
    }
}
