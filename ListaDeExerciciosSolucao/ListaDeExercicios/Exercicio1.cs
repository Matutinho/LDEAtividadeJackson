using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio1
    {
        static void Main1(string[] args)
        {
            // ESTOQUE MINIMO
            Console.WriteLine("Insira o valor minimo do estoque? ");
            int estMinimo = int.Parse(Console.ReadLine());

            // ESTOQUE MAXIMO
            Console.WriteLine("Insira o valor maximo do estoque? ");
            int estMaximo = int.Parse(Console.ReadLine());

            // ESTOQUE MÉDIO
            int estMedio = (estMinimo + estMaximo) / 2;
            Console.WriteLine($"O estoque médio é = {estMedio}");
        }
    }
}
