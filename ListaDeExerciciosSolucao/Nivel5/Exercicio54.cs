using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio54
    {
        static void Main54(string[] args)
        {
            int[] vetElementoA = new int[5];
            int[] vetElementoB = new int[8];

            string[] vetEGG = new string[4];


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira um valor para o elemento A: ");
                vetElementoA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Insira um valor para o elemento B: ");
                vetElementoB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (vetElementoA[i] == vetElementoB[i])
                {
                    Console.WriteLine($"\nElemento A: {vetElementoA[i]} | Elemento B: {vetElementoB[i]}");
                }
            }

            Console.WriteLine("\nPressione [Enter] para continuar!");
            Console.ReadKey();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n| MISSÃO SECRETA |");

                Console.WriteLine("\n\nPessoa Estranha: Consegue inserir na ordem os elementos certos? ");
                vetEGG[i] = Console.ReadLine();

                if (vetEGG[i] == "Água")
                {
                    Console.WriteLine("\n\nPessoa Estranha: Certo, continue! Qual é o próximo elemento? ");
                    vetEGG[i] = Console.ReadLine();

                    if (vetEGG[i] == "Terra")
                    {
                        Console.WriteLine("\n\nPessoa Estranha: Falta pouco, vamos em frente! Qual é o próximo elemento? ");
                        vetEGG[i] = Console.ReadLine();

                        if (vetEGG[i] == "Fogo")
                        {
                            Console.WriteLine("\n\nPessoa Estranha: Perfeito, e o não menos importante, eh??? ");
                            vetEGG[i] = Console.ReadLine();

                            if (vetEGG[i] == "Ar")
                            {
                                Console.WriteLine("\n\nKatara: Você acertou os quatro elementos!");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: Vamos lá, você merece isso!");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: À muito tempo, as quatro nações viviam em paz e harmonia.");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: Mas, tudo isso mudou, quando a nação do fogo atacou.");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: Só o avatar domina os quatro elementos, mas quando o mundo mais precisa dele, ele desaparece.");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: Cem anos se passaram, eu e meu irmão encontramos um novo Avatar, um jovem dobrador de ar, embora a sua dobra de ar seja ótima, ele terá que aprender os outros três elementos antes de dizer: 'Eu sou Aang'.");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: Mas eu acredito...");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();

                                Console.WriteLine("\n\nKatara: Que o Aang possa salvar o mundo!");

                                Console.WriteLine("\nPressione [Enter] para continuar!");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
        }
    }
}
