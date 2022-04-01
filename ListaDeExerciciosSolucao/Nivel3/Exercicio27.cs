using System;


namespace Nivel3
{
    class Exercicio27
    {
        static void Main27(string[] args)
        {
            int qtdNumeros;
            int valNum1;
            int numFatorial = 1;
            string concResultado = "";

            Console.WriteLine("Insira a quantos números serão calculados: ");
            qtdNumeros = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdNumeros; i++)
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
                        Console.WriteLine($"\n{i}º número fatorial: {concResultado}\n");
                        concResultado = "";
                        numFatorial = 1;
                    }
                    
                }
            }


        }
    }
}
