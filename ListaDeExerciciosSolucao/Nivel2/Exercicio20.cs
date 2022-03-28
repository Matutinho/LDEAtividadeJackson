using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio20
    {
        static void Main20(string[] args)
        {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            bool repeticao = false;

            while(val1 == 0)
            {
                Console.WriteLine("Insira o primeiro valor: ");
                val1 = int.Parse(Console.ReadLine());
                if (val1 == 0)
                {
                    Console.WriteLine("Erro ao inserir o valor.");
                }
            }

            while (val2 == 0)
            {
                Console.WriteLine("Insira o segundo valor: ");
                val2 = int.Parse(Console.ReadLine());
                if (val2 == 0)
                {
                    Console.WriteLine("Erro ao inserir o valor.");
                }
            }

            while (val3 == 0)
            {
                Console.WriteLine("Insira o terceiro valor: ");
                val3 = int.Parse(Console.ReadLine());
                if (val3 == 0)
                {
                    Console.WriteLine("Erro ao inserir o valor.");
                }
            }

            if (val1 > val2 && val1 > val3 && val2 > val3)
            {
                Console.WriteLine($"{val1} x {val3} = {val1*val3} & {val1} / {val3} = {val1/val3} ");
            }

            else if (val2 > val1 && val2 > val3 && val1 > val3)
            {
                Console.WriteLine($"{val2} x {val3} = {val2 * val3} & {val2} / {val3} = {val2 / val3} ");
            }

            else if (val3 > val1 && val3 > val2 && val2 > val1)
            {
                Console.WriteLine($"{val3} x {val1} = {val3 * val1} & {val3} / {val1} = {val3 / val1} ");
            }

        }
    }
}
