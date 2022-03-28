using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio14
    {
        static void Main14(string[] args)
        {
            int valNum1;
            int valNum2;

            Console.WriteLine("Insira o primeiro valor: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            valNum2 = int.Parse(Console.ReadLine());

            if (valNum1 > valNum2)
            {
                Console.WriteLine($"A diferença é de {valNum1 - valNum2}.");
            }
            else
            {
                Console.WriteLine($"A diferença é de {valNum2 - valNum1}.");
            }
        }
    }
}
