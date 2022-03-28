using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio19
    {
        static void Main19(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;

            Console.WriteLine("Inserir valor do lado A: ");
            ladoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserir valor do lado B: ");
            ladoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserir valor do lado C: ");
            ladoC = int.Parse(Console.ReadLine());

            if(ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("Equilátero");
            }
            else if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Isósceles");
            }
            else if (ladoA != ladoB || ladoA != ladoC || ladoB != ladoC)
            {
                Console.WriteLine("Escaleno");
            }
            else if (ladoA != ladoB || ladoA != ladoC || ladoB != ladoC || ladoA != ladoB && ladoB != ladoC)
            {
                Console.WriteLine("Não é compativel com um triangulo.");
            }


        }
    }
}
