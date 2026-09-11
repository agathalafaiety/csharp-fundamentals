using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad = new Quadrado(EnumCores.azul, 5);

            Console.WriteLine($"A area do Quadrado é {quad.Area()}");
            Console.WriteLine($"O perimetro é {quad.Perimetro()}");

        }
    }
}
