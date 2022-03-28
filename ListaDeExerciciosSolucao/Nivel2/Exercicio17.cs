using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio17
    {
        static void Main17(string[] args)
        {
            int valNum1;

            Console.WriteLine("Insira um valor: ");
            valNum1 = int.Parse(Console.ReadLine());

            if(valNum1 >= 0 && valNum1 <= 9)
            {
                Console.WriteLine($"O valor inserido é valido.");
            }
            else
            {
                Console.WriteLine($"O valor inserido não é valido.");
            }
        }
    }
}
