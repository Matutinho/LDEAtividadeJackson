using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio5
    {
        static void Main5(string[] args)
        {
            int valDistancia;
            int valTempo;
            int valVelocidade;
            int qtdCombustivel;

            Console.WriteLine("Quanto tempo de viagem (horas)? ");
            valTempo = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantos Km por hora? ");
            valVelocidade = int.Parse(Console.ReadLine());

            valDistancia = valTempo * valVelocidade;
            Console.WriteLine($"\nA distancia a ser percorrida é de: {valDistancia}");

            Console.WriteLine($"Velocidade: {valVelocidade}");
            Console.WriteLine($"Tempo: {valTempo}");
            Console.WriteLine($"Distancia: {valDistancia}");

            qtdCombustivel = valDistancia / 12;
            Console.WriteLine($"A quantidade de litros a ser utilizada é de : {qtdCombustivel}");


        }
    }
}
