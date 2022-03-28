using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Exercicio9
    {
        static void Main9(string[] args)
        {
            int valAnos;
            int valMeses;
            int valDias;
            int mesVersario;
            int diaVersario;

            Console.WriteLine("Quantos anos você tem? ");
            valAnos = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quantos meses fazem desde que comepletou {valAnos} anos? ");
            mesVersario = int.Parse(Console.ReadLine());

            Console.WriteLine($"Quantos dias fazem desde que comepletou {valAnos} anos? ");
            diaVersario = int.Parse(Console.ReadLine());

            diaVersario += mesVersario * 30;

            valDias = valAnos * 365;
            Console.WriteLine($"Idade em dias: {valDias + diaVersario}");

            valMeses = valDias / 30;
            Console.WriteLine($"Idade em mês: {valMeses + mesVersario}");



        }
    }
}
