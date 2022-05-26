using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Retangulo : Forma
    {

        public double Altura { get; set; }
        public double Largura { get; set; }

        public override double Perimetro()
        {
            return Altura * 2 + Largura * 2;
        }
    }
}
