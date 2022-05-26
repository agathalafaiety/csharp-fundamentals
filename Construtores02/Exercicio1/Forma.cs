using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Forma
    {
        public string Cor{ get; set; }

        public Forma(string cor)
        {
            Cor = cor;
        }

        public void MinhaCor()
        {
            Console.WriteLine($"Minha cor é {Cor}");
        }


        // Assinatura de metodo (virtual)
        public virtual void Area()
        {
            Console.WriteLine(0);
        }

        public virtual double Perimetro()
        {
            return (0);
        }
    }
}
