using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio2
    {
        static void Main2(string[] args)
        {
            // COTAÇÃO DOLAR
            Console.WriteLine("Insira quanto está valendo o dolar em real: ");
            double cotDolar = double.Parse(Console.ReadLine());

            // QUANTIA EM DOLAR
            Console.WriteLine("Insira a quantia em dolar que deseja fazer a conversão: ");
            double valDolar = double.Parse(Console.ReadLine());

            // CONVERTER EM REAL
            double convReal = valDolar * cotDolar;
            Console.WriteLine($"A quantia em dolar convertida em real é: {convReal}");
        }
    }
}
