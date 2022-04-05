using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio52
    {
        static void Main52(string[] args)
        {

            int valCont = 0;

            int[] vetNums = new int[100];

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\nInsira um valor: ");
                vetNums[i] = int.Parse(Console.ReadLine());

                if (vetNums[i] == 1)
                {
                    Console.WriteLine("\nInsira um valor: ");
                    vetNums[i] = int.Parse(Console.ReadLine());
                    
                    if (vetNums[i] == 3)
                    {
                        Console.WriteLine("\nInsira um valor: ");
                        vetNums[i] = int.Parse(Console.ReadLine());

                        if(vetNums[i] == 4)
                        {
                            valCont++;
                        }
                    }
                }
                else if (vetNums[i] < 0)
                {
                    Console.WriteLine($"\nVezes que a sequência 1,3 e 4 foi digitada: {valCont}");
                    break;
                }
            }
        }
    }
}
