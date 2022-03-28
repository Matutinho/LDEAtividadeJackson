using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio10
    {
        static void Main10(string[] args)
        {
            int valNum1;
            int valNum2;

            Console.WriteLine("Insira o primeiro valor: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o primeiro valor: ");
            valNum2 = int.Parse(Console.ReadLine());

            // É IGUAL?
            if (valNum1 == valNum2)
            {
                Console.WriteLine("Números iguais.");
            }
            else
            {
                Console.WriteLine("Não são iguais.");

            }

            // É DIFERENTE?
            if (valNum1 != valNum2)
            {
                Console.WriteLine("Número 1 diferente que Número 2.");
            }
            else
            {
                Console.WriteLine("Número 1 não é diferente que Número 2.");

            }

            // É MAIOR?
            if (valNum1 > valNum2)
            {
                Console.WriteLine("Número 1 é maior que Número 2.");
            }
            else
            {
                Console.WriteLine("Número 1 não é maior que Número 2.");

            }

            // É MENOR?
            if (valNum1 < valNum2)
            {
                Console.WriteLine("Número 1 é menor que Número 2.");
            }
            else
            {
                Console.WriteLine("Número 1 não é menor que Número 2.");

            }

            // É MAIOR OU IGUAL?
            if (valNum1 >= valNum2)
            {
                Console.WriteLine("Número 1 é maior ou igual a Número 2.");
            }
            else
            {
                Console.WriteLine("Número 1 não é maior ou igual a Número 2.");

            }

            // É MENOR OU IGUAL?
            if (valNum1 <= valNum2)
            {
                Console.WriteLine("Número 1 é menor ou igual a Número 2.");
            }
            else
            {
                Console.WriteLine("Número 1 não é menor ou igual a Número 2.");

            }
        }
    }
}
