using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_RETANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("CONSIDERE SEU TERRENO COMO UM RETANGULO PARA CALCULAR A ARÉA");


            Console.WriteLine("Digite a base do retangulo  :");
            Double BASE;
            BASE = Double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a altura do retangulo :");
            Double altura ;
            altura = Double.Parse(Console.ReadLine());

            double terreno = altura * BASE;

            if (terreno < 100)
            {
                Console.WriteLine(" A AREA DO SEU TERRENO É " + terreno + "---- TERRENO PEQUENO ");
            }
            else
            { Console.WriteLine(" A AREA DO SEU TERRENO É " + terreno + "----- TERRENO GRANDE "); }






        }
    }
}
