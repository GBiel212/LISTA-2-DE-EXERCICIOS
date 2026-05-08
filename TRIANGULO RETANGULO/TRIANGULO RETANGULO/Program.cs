using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIANGULO_RETANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" DIGITE O VALOR DE A: ") ;
            int a = int.Parse(Console.ReadLine());  

            Console.WriteLine(" DIGITE O VALOR DE B: ") ;
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(" DIGITE O VALOR DE C: ") ;
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                int maior;
                int x;
                int y;

                if (a > b && a > c)
                {
                    maior = a;
                    x = b;
                    y = c;
                }
                else if (b > a && b > c)
                {
                    maior = b;
                    x = a;
                    y = c;
                }
                else
                {
                    maior = c;
                    x = a;
                    y = b;
                }

                if (maior * maior == x * x + y * y)
                {
                    Console.WriteLine(" É UM TRIÂNGULO RETÂNGULO");
                }
                else
                {
                    Console.WriteLine(" NÃO É UM TRIÂNGULO RETÂNGULO");
                }
            }
            else
            {
                Console.WriteLine(" NÃO FORMA UM TRIANGULO");
            }
            Console.ReadKey (); 










        }
    }
}
