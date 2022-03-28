using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio21
    {
        static void Main21(string[] args)
        {
            bool continuar = true;
            int valNum1;

            while(continuar == true)
            {
                Console.WriteLine("Insira um número: ");
                valNum1 = int.Parse(Console.ReadLine());
                if(valNum1 > 0)
                {
                    Console.WriteLine("Número positivo.");
                }
                else
                {
                    Console.WriteLine("Número negativo.");
                }

                Console.WriteLine("Deseja continuar?");
                continuar = bool.Parse(Console.ReadLine());
            }
            
        }
    }
}
