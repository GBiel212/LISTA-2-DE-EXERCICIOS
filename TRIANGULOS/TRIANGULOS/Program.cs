using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIANGULOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro Lado do triangulo: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo Lado do triangulo: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro Lado do triangulo: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A + B > C && A + C > B && B + C > A)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("   O triangulo é Equilátero");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("   O triangulo é Isósceles");
                }
                else
                {
                    Console.WriteLine("   O triangulo é Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores digitados não formam um triângulo.");
            }



        }
    }
}




