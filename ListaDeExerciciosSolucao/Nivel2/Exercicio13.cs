using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio13
    {
        static void Main13(string[] args)
        {
            int valNum1;
            int valNum2;
            int valNum3;

            Console.WriteLine("Insira o primeiro valor: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            valNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor: ");
            valNum3 = int.Parse(Console.ReadLine());
            // ORDEM 1
            if (valNum1 > valNum2 && valNum1 > valNum3 && valNum2 > valNum3)
            {
                Console.WriteLine($"Decrescente: {valNum1}, {valNum2}, {valNum3}");
            }
            else
            {
                // ORDEM 2
                if (valNum1 > valNum2 && valNum1 > valNum3 && valNum3 > valNum2)
                {
                    Console.WriteLine($"Decrescente: {valNum1}, {valNum3}, {valNum2}");
                }
                else
                {
                    // ORDEM 3
                    if (valNum2 > valNum1 && valNum2 > valNum3 && valNum1 > valNum3)
                    {
                        Console.WriteLine($"Decrescente: {valNum2}, {valNum1}, {valNum3}");
                    }
                    else
                    {
                        // ORDEM 4
                        if (valNum2 > valNum1 && valNum2 > valNum3 && valNum3 > valNum1)
                        {
                            Console.WriteLine($"Decrescente: {valNum2}, {valNum3}, {valNum1}");
                        }
                        else
                        {
                            // ORDEM 5
                            if (valNum3 > valNum1 && valNum3 > valNum2 && valNum1 > valNum2)
                            {
                                Console.WriteLine($"Decrescente: {valNum3}, {valNum1}, {valNum2}");
                            }
                            else
                            {
                                // ORDEM 6
                                if (valNum3 > valNum1 && valNum3 > valNum2 && valNum2 > valNum1)
                                {
                                    Console.WriteLine($"Decrescente: {valNum3}, {valNum2}, {valNum1}");
                                }
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
