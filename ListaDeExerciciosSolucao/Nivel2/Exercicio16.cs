using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio16
    {
        static void Main16(string[] args)
        {
            int valNum1;
            int valNum2;

            Console.WriteLine("Insira o valor do primeiro número: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do segundo número: ");
            valNum2 = int.Parse(Console.ReadLine());

            if (valNum1 > valNum2)
            {
                Console.WriteLine($"O primeiro valor é maior: Primeiro {valNum1}");
            }
            else if (valNum2 > valNum1)
            {
                Console.WriteLine($"O primeiro valor é maior: Segundo {valNum2}");

            }
            else if (valNum1 == valNum2)
            {
                Console.WriteLine($"O primeiro e o segundo valor são iguais: Primeiro {valNum1} | Segundo {valNum2}");
            }
        }
    }
}
