using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pai pai = new Pai();
            pai.Nome = "Garrafa";
            pai.Altura = 1.86;            

            Filho filho = new Filho();
            filho.Nome = "Garrafinha";
            filho.Altura = 1.23;

            Neto neto = new Neto();
            neto.Nome = "Caçulinha";

            Console.WriteLine(pai.Nome);
            Console.WriteLine(filho.Nome);
            Console.WriteLine(neto.Nome);

            pai.QuemSou();
            filho.QuemSou();
            neto.QuemSou();
        }
    }
}
