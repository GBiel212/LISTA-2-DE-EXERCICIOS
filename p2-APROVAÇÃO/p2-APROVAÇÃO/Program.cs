using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace p2_APROVAÇÃO
{
    internal class Program
    {
        static void Main(string[] args)

        {

            double p1, p2;

            Console.WriteLine("Digite a sua nota na p1: ");
             p1 = double.Parse(Console.ReadLine());
            
            p2 = (15 - p1 ) / 2;

            if (p2 <= 10)
            {
                Console.WriteLine("A sua nota na p2 deve ser no mínimo: " + p2) ;
            }
            else
            {
                Console.WriteLine("Infelizmente, não é possível alcançar a média necessária para aprovação.");  



            }

        }
    }    
}
