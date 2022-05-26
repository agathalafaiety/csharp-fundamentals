using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Curso> cursos = new List<Curso>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($">>>>> Digite o {i + 1} curso <<<<< \n");

                Console.WriteLine("Digite o titulo do curso: \n");
                string titulo = Console.ReadLine();

                Console.WriteLine("Digite o periodo do curso: \n");
                string periodo = Console.ReadLine();

                Console.WriteLine("Digite a descrição do curso: \n");
                string descricao = Console.ReadLine();

                Console.WriteLine();

                cursos.Add(new Curso(titulo, descricao, periodo));
                
            }

            foreach (Curso item in cursos)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
