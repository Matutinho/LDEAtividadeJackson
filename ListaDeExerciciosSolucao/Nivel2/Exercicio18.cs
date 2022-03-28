using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio18
    {
        static void Main18(string[] args)
        {
            int codigo;

            Console.WriteLine("Insira um valor ao código: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;

                case 2:
                    Console.WriteLine("Dois");
                    break;

                case3:
                    Console.WriteLine("Três");
                    break;

                default:
                    Console.WriteLine("Código invalido.");
                    break;
            }
        }
    }
}
