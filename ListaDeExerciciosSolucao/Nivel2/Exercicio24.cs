using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio24
    {
        static void Main24(string[] args)
        {

            int valNum1;
            int valNum2;
            int resultado1;
            int resultado2;
            int tipoCalculo;

            Console.WriteLine("Insira o primeiro valor: ");
            valNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            valNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("Multiplos   ( 1 )");
            Console.WriteLine("Pares       ( 2 )");
            Console.WriteLine("Média       ( 3 ) ");
            Console.WriteLine("Sair        ( 4 ) ");

            tipoCalculo = int.Parse(Console.ReadLine());

            switch (tipoCalculo)
            {
                case 1:
                    for (int i = 0; i <= valNum1 && i <= valNum2; i++)
                    {
                        resultado1 = valNum1 * i;
                        resultado2 = valNum2 * i;

                        if (resultado1 == valNum2 || resultado2 == valNum1)
                        {
                            Console.WriteLine("Números multiplos.");
                            break;
                        }
                        else if (i == valNum1)
                        {
                            Console.WriteLine("Não são multiplos.");
                            break;
                        }
                    }

                    break;

                case 2:
                    resultado1 = valNum1 % 2;
                    resultado2 = valNum2 % 2;

                    if (resultado1 == 0 && resultado2 == 0)
                    {
                        Console.WriteLine("Números são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Números não são pares.");
                    }

                    break;

                case 3:
                    resultado1 = (valNum1 + valNum2) / 2;

                    if (resultado1 >= 7)
                    {
                        Console.WriteLine("Acima da média.");
                    }
                    else
                    {
                        Console.WriteLine("Abaixo da média.");
                    }
                    break;

                default:
                    Console.WriteLine("Programa finalizado.");
                    break;
            }
        }
    }
}
