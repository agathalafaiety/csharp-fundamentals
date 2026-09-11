using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();

            p1.SetNome("Agatha");
            p1.Idade = 18;
            p1.Peso = 50.0;
          

            Console.WriteLine(p1.GetNome());
            Console.WriteLine(p1.Idade);
            Console.WriteLine(p1.Peso);

        }
    }
}
