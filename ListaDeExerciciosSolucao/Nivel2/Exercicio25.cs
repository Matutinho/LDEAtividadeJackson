using System;

namespace Nivel3
{
    class Exercicio24
    {
        static void Main25(string[] args)
        {
            double alturaPessoa;
            double pesoIdeal;
            string sexoPessoa;

            Console.WriteLine("Insira a altura da pessoa: ");
            alturaPessoa = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o sexo da pessoa: ");
            sexoPessoa = Console.ReadLine();

            switch (sexoPessoa)
            {
                case "M":
                    pesoIdeal = (72.2 * alturaPessoa) - 58;
                    Console.WriteLine($"O peso ideal desse homem é {pesoIdeal:f1}.");
                    break;

                default:
                    pesoIdeal = (62.1 * alturaPessoa) - 44.7;
                    Console.WriteLine($"O peso ideal dessa mulher é {pesoIdeal}.");
                    break;
            }
            
        }
    }
}