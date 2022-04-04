using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio27
    {
        static void Main27(string[] args)
        {
            int qtdNumeros;
            int valNum;
            string valFatorial = "";
            

            Console.WriteLine("Quantos números vão ser calculados: ");
            qtdNumeros = int.Parse(Console.ReadLine());

            while (qtdNumeros > 0)
            {
                Console.WriteLine($"\nInsira o ({qtdNumeros}º) número a ser calculado seu fatorial: ");
                valNum = int.Parse(Console.ReadLine());

                for (int i = valNum; i > 0; i--)
                {
                    valNum *= i;
                    valFatorial += i.ToString() + ".";

                    if (i == 1)
                    {
                        valFatorial += " = " + valNum.ToString();
                        Console.WriteLine($"\n{valFatorial}");
                        i = 0;
                        valFatorial = "";
                        qtdNumeros--;
                    }
                }
            }
        }
    }
}
