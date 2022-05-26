using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad = new Quadrado();
            quad.Lado = 5;
            Console.WriteLine(quad.Area());

            Retangulo ret = new Retangulo();
            ret.Altura = 3;
            ret.Largura = 4;
            Console.WriteLine(ret.Area());

            // Forma forma = new Forma();

            List<Quadrado> meusQuadrados = new List<Quadrado>();
            meusQuadrados.Add(quad);
            //meusQuadrados.Add(ret);

            List<Forma> minhasFormas = new List<Forma>();
            minhasFormas.Add(quad);
            minhasFormas.Add(ret);

            foreach (Forma item in minhasFormas)
            {
                if (item is Quadrado)
                {
                    Quadrado teste = (Quadrado)item;
                    Console.WriteLine(teste.Lado);
                   
                }
            }

        }
    }
}
