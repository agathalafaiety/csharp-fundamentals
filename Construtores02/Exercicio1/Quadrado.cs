using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public Quadrado(double lado, string cor) : base(cor)
        {
            Lado = lado;
        }

        public override void Area()
        {
            //base.Area(); //Area da classe principal
            Console.WriteLine($"Sou um quadrado e minha area é {Lado * Lado}");
        }

        public override double Perimetro()
        {
            return Lado * 4;
            
        }
    }
}
