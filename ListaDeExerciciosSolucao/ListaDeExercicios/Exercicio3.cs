using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio3
    {
        static void Main3(string[] args)
        {
            string idfVendedor;
            string codPeca;
            double uniPreco;
            int qtdPeca;
            double comVenda;

            Console.WriteLine("Qual o nome do vendedor? ");
            idfVendedor = Console.ReadLine();

            Console.WriteLine("Qual é o código da peça? ");
            codPeca = Console.ReadLine();

            Console.WriteLine("Insira o valor unitario da peça: ");
            uniPreco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas peças vão ser cobradas: ");
            qtdPeca = int.Parse(Console.ReadLine());

            comVenda = ((uniPreco * qtdPeca) * 5 ) / 100;
            Console.WriteLine($"A comissão que o vendedor terá pela venda é de : R${comVenda}");
        }
    }
}
