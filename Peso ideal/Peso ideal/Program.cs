using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_ideal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double R = peso / (altura * altura);

            if (R < 19)
                Console.WriteLine("Abaixo do peso");
            else
                if ( 19 <= R && R < 24)

                {
                    Console.WriteLine("Peso ideal");
                }
                else
                { 
                 Console.WriteLine("Acima do peso");
                 }






        }
    }
}
