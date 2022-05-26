using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }

        public override double Perimetro()
        {
            return Lado * 4;
        }

    }
}
