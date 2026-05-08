using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIA_FINAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" DIGITE A NOTA DA PROVA 1: ");
            Double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" DIGITE A NOTA DA PROVA 2: ");
            Double nota2 = Convert.ToDouble(Console.ReadLine());

            Double MEDIA = (nota1 + nota2) / 3;

            if ( MEDIA >= 5 )
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }






        }
    }
}
