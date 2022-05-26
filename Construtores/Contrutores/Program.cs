using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(Instanciando
            Pessoa p1 = new Pessoa("Agatha", 18);

            Console.WriteLine(p1._nome);
            Console.WriteLine(p1._idade);

            Pessoa p2 = new Pessoa();*/

            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < 3; i++)
            {
                //Pessoa pessoa = new Pessoa();

                Console.WriteLine($">>>>> Digite os dados da {i + 1} <<<<<");

                Console.WriteLine();

                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //pessoa._nome = nome;
                //pessoa._idade = idade;

                pessoas.Add(new Pessoa(nome, idade));


            }

            foreach (Pessoa item in pessoas)
            {
                //Console.WriteLine($"Meu nome é {item._nome}");

                //Console.WriteLine($"Minha idade é {item._idade}");

                Console.WriteLine(item.ToString());



            }

        }
    }
}
