using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_VALORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O PRIMEIRO VALOR: ");
            double A;
            A = double.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE O SEGUNDO VALOR: ");
            double B;
            B = double.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE O TERCEIRO VALOR: ");
            double C;
            C = double.Parse(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine("MAIOR VALOR: " + A);
            }
            else if (B > A && B > C)
            {
                Console.WriteLine("MAIOR VALOR: " + B);
            }
            else if (C > A && C > B)
            {
                Console.WriteLine("MAIOR VALOR: " + C);
            }
           
          
            

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();









        }
    }
}
