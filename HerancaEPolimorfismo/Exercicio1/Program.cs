using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma forma = new Forma("");

            //Polimorfismo
            Quadrado quad = new Quadrado(3, "blue");

            Retangulo ret = new Retangulo(2, 4, "green");

            quad.Area();

            Console.WriteLine($"O perimetro do quadrado é {quad.Perimetro()} ");
            ret.Area();

            Console.WriteLine($"O perimetro do retangulo é {ret.Perimetro()}");
        }
    }
}
