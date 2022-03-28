using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio8
    {
        static void Main8(string[] args)
        {
            double valVolume;
            double valRaio;
            double valAltura;

            Console.WriteLine("Informe o raio do recipiente: ");
            valRaio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do recipiente: ");
            valAltura = double.Parse(Console.ReadLine());

            //JAKSON PEIDÃO
            valVolume = 3.14159 * valRaio * valRaio * valAltura;
            Console.WriteLine($"O volume é: {valVolume}");
        }
    }
}
