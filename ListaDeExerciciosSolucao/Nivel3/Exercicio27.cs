using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exercicio27
    {
        static void Main(string[] args)
        {
            int qtdNumeros;
            int numFatorial;
            int contFatorial;
            int calcFatorial;
            string tabFatorial;

            Console.WriteLine("Quantos números vão ser calculados: ");
            qtdNumeros = int.Parse(Console.ReadLine());

            for (int i = qtdNumeros; i > 0; i--)
            {
                Console.WriteLine("Insira um valor para calcular o fatorial: ");
                numFatorial = int.Parse(Console.ReadLine());
                contFatorial = numFatorial;

                switch (numFatorial)
                {
                    case > 0:
                        for (int c = 0; c < contFatorial; c++)
                        {
                            numFatorial *= c;
                            Console.WriteLine($"{numFatorial}");
                        }
                        Console.WriteLine($"{numFatorial}");
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
