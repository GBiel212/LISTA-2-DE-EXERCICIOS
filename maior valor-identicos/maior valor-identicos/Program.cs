using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_valor_identicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor 1: ");
            int a;

            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor 2: ");
            int b;
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Os valores são identicos");


            }
            else
            {




                if (a > b)
                {
                    Console.WriteLine("o valor 1 é maior");
                }
                else
                {
                    Console.WriteLine("o valor 2 é maior");
                }
            }

            Console.ReadKey();



        }
    }
}
