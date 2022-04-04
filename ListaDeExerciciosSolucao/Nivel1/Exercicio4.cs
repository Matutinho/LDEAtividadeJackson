using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio4
    {
        static void Main4(string[] args)
        {
            int valA;
            int valB;
            int valC;
            int valD;
            int resultado;

            // A
            Console.WriteLine("Valor da variavel A? ");
            valA = int.Parse(Console.ReadLine());
            // B
            Console.WriteLine("\nValor da variavel B? ");
            valB = int.Parse(Console.ReadLine());
            // C
            Console.WriteLine("\nValor da variavel C? ");
            valC = int.Parse(Console.ReadLine());
            // D
            Console.WriteLine("\nValor da variavel D? ");
            valD = int.Parse(Console.ReadLine());

            // SOMA
            resultado = valA + valB;
            Console.WriteLine($"{valA} + {valB} = {resultado}");

            resultado = valA + valC;
            Console.WriteLine($"{valA} + {valC} = {resultado}");

            resultado = valA + valD;
            Console.WriteLine($"{valA} + {valD} = {resultado}");

            resultado = valB + valC;
            Console.WriteLine($"{valB} + {valC} = {resultado}");

            resultado = valB + valD;
            Console.WriteLine($"{valB} + {valD} = {resultado}");

            resultado = valC + valD;
            Console.WriteLine($"{valC} + {valD} = {resultado}");

            // MULTIPLICAÇÃO
            resultado = valA * valB;
            Console.WriteLine($"{valA} * {valB} = {resultado}");

            resultado = valA * valC;
            Console.WriteLine($"{valA} * {valC} = {resultado}");

            resultado = valA * valD;
            Console.WriteLine($"{valA} * {valD} = {resultado}");

            resultado = valB * valC;
            Console.WriteLine($"{valB} * {valC} = {resultado}");

            resultado = valB * valD;
            Console.WriteLine($"{valB} * {valD} = {resultado}");

            resultado = valC * valD;
            Console.WriteLine($"{valC} * {valD} = {resultado}");
        }
    }
}
