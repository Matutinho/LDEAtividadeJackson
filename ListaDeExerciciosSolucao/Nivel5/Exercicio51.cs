using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio51
    {
        static void Main51(string[] args)
        {
            int qtdAlunos;
            double valAcima = 0;
            double valMedia = 0;

            Console.WriteLine("Insira quantos alunos deseja saber a média: ");
            qtdAlunos = int.Parse(Console.ReadLine());

            double[] vetNotas = new double[qtdAlunos];

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine("Insira a nota média de cada aluno: ");
                vetNotas[i] = double.Parse(Console.ReadLine());

                if (vetNotas[i] > 7)
                {
                    valAcima++;
                }
                else if (vetNotas[i] >= 5 && vetNotas[i] <= 7)
                {
                    valMedia++;
                }
            }

            if (valAcima > 0 || valMedia > 0 )
            {
                Console.WriteLine($"Alunos acima da média: {valAcima}.");
                Console.WriteLine($"Alunos na média: {valMedia}.");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
        }
    }
}
