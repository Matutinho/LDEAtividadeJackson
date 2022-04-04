using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio30
    {
        static void Main30(string[] args)
        {
            int valNum1;
            int valTabuada;

            Console.WriteLine("Insira um número para calcular sua tabuada: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("A tabuada vai ser calculada até que número? ");
            valTabuada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valTabuada; i++)
            {
                Console.WriteLine($"{i} x {valNum1} = {valNum1*i}\n");
            }
        }
    }
}
