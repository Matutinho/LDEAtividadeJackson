using System;


namespace Nivel3
{
    class Exercicio27
    {
        static void Main27(string[] args)
        {
            int qtdNumeros;
            int valNum;
            string valFatorial = "";

            int valNum1;
            int numFatorial = 1;
            string concResultado = "";

            Console.WriteLine("Insira a quantos números serão calculados: ");
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

                    for (int b = 1; b <= qtdNumeros; b++)
                    {
                        Console.WriteLine("\nInsira o valor para calcular o fatorial: ");
                        valNum1 = int.Parse(Console.ReadLine());


                        for (int c = valNum1; c > 0; c--)
                        {
                            numFatorial *= c;
                            concResultado += c.ToString() + " * ";
                            if (c == 1)
                            {
                                concResultado += " = " + numFatorial.ToString();
                                Console.WriteLine($"\n{b}º número fatorial: {concResultado}\n");
                                concResultado = "";
                                numFatorial = 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
