using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio23
    {
        static void Main23(string[] args)
        {
            int valNum1;
            int valNum2;
            int calculo;

            Console.WriteLine("Insira o primeiro número: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            valNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o tipo de calculo: ");
            Console.WriteLine("Soma = 1");
            Console.WriteLine("Subtração = 2");
            Console.WriteLine("Multiplicação = 3");
            Console.WriteLine("Divisão = 4");
            calculo = int.Parse(Console.ReadLine());

            switch (calculo)
            {
                case 1:
                    Console.WriteLine($"{valNum1} + {valNum2} = {valNum1 + valNum2}");
                    break;
                case 2:
                    Console.WriteLine($"{valNum1} - {valNum2} = {valNum1 - valNum2}");
                    break;
                case 3:
                    Console.WriteLine($"{valNum1} * {valNum2} = {valNum1 * valNum2}");
                    break;
                case 4:
                    Console.WriteLine($"{valNum1} / {valNum2} = {valNum1 / valNum2}");
                    break;
                default:
                    break;
            }
        }
    }
}
