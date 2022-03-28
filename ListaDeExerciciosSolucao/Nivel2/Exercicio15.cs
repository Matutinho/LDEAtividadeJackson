using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio15
    {
        static void Main15(string[] args)
        {
            int valNota1 = 0;
            int valNota2 = 0;
            int valNota3 = 0;
            int valNota4 = 0;
            int valMedia = 0;
            int valRecuperacao = 0;

            Console.WriteLine($"Insira a 1º nota: ");
            valNota1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira a 2º nota: ");
            valNota2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira a 3º nota: ");
            valNota3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira a 4º nota: ");
            valNota4 = int.Parse(Console.ReadLine());

            valMedia = (valNota1 + valNota2 + valNota3 + valNota4) / 4;
            
            if(valMedia >= 7)
            {
                Console.WriteLine($"Aluno aprovado! Média: {valMedia}");
            }
            else
            {
                Console.WriteLine($"Aluno em recuperação. Média: {valMedia}. Insira a nova nota para calcular a média: ");
                valRecuperacao = int.Parse(Console.ReadLine());
                valRecuperacao = (valMedia + valRecuperacao) / 2;

                if (valRecuperacao >= 7)
                {
                    Console.WriteLine($"Aluno aprovado por recuperação. Média: {valRecuperacao}");
                }
                else
                {
                    Console.WriteLine($"Aluno reprovado!!! Média: {valRecuperacao}.");
                }
            }
        }
    }
}
