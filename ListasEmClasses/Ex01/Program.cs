using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Agatha";
            Console.WriteLine(pessoa.Nome);

            pessoa.meusAnimais.Add(new Animal("Cachorro", "tobby", "poodle"));
            pessoa.meusAnimais.Add(new Animal("Cachorro", "toy", "vira lata"));

            foreach (Animal item in pessoa.meusAnimais)
            {
                Console.WriteLine(item.QualAnimal);
                Console.WriteLine(item.Apelido);
                Console.WriteLine(item.Tipo);

                Console.WriteLine();
            }
        }
    }
}
