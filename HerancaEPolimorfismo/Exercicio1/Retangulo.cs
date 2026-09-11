using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Retangulo : Forma
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura, string cor) : base(cor)
        {
            Altura = altura;
            Largura = largura;
        }

        public override void Area()
        {
            Console.WriteLine($"Eu sou um retangulo e minha area é {Altura*Largura}");

        }

        public override double Perimetro()
        {
            return Altura * 2 + Largura * 2;
        }
    }
}
