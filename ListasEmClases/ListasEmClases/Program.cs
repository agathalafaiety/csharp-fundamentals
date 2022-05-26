using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEmClases
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaMae mae = new MinhaMae();

            mae.Nome = "Mãe do teclado";
            mae.Idade = 40;
            //mae.Filho.Nome = "Tecladinho";
            //mae.Filho.Idade = 10;
            // mae.Filho.Genero = "M";

            //mae.Filho = new Filho ("Teclado", 10, "M");
            //Console.WriteLine(mae.Filho.Nome);

            mae.meusFilhos.Add(new Filho("Tecladinho", 10, "m"));
            mae.meusFilhos.Add(new Filho("mouser", 1, "m"));

            Console.WriteLine(mae.Nome);
            Console.WriteLine(mae.Idade);


            foreach (Filho item in mae.meusFilhos)
            {
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Idade);
                Console.WriteLine(item.Genero);
                
                Console.WriteLine();



            }

        }
    }
}
