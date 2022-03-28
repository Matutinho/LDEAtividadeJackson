using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio22
    {
        static void Main22(string[] args)
        {
            int valNum;
            int valA;
            int valB;

            Console.WriteLine("Insira um valor: ");
            valNum = int.Parse(Console.ReadLine());

            if(valNum > 0)
            {
                valA = valNum;
                Console.WriteLine($"valA = {valA}");
                Console.WriteLine($"valB = Null");
            }
            else
            {
                valB = valNum;

                Console.WriteLine($"valB = Null");
                Console.WriteLine($"valB = {valB}");
            }
        }
    }
}
