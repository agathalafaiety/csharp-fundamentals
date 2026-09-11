using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Quadrado
    {

        public EnumCores Cor{ get; set; }

        public double Lado { get; set; }

        public Quadrado() { }

        public Quadrado(EnumCores cor, double lado)
        {
            Cor = cor;
            Lado = lado;
        }

        public double Area()
        {
            double area = Lado * Lado;
            return  area;
        } 

        public double Perimetro()
        {
            double perimetro = Lado * 4;
            return perimetro;
        }
    }
}
