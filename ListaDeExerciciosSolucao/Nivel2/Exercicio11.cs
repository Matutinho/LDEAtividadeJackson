using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel2
{
    class Exercicio11
    {
        static void Main11(string[] args)
        {
            int valA;
            int valB;

            Console.WriteLine("Insira um valor para variavel A: ");
            valA = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira um valor para variavel B: ");
            valB = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n| A = {valA} | Valores Originais | B = {valB} |");
    
            Console.WriteLine($"\n| A = {(valA + valB) - valA} | Troca de Valores | B = {(valA + valB) - valB} |");
        }
    }
}
