using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPA
{
    class Program
    {
        static void Main(string[] args)
        {
           // string nome;
           // int idade;

            //Console.WriteLine("Digite o seu nome");

            //ToUpper - converte tidos os caracteres p maiusculo
            //ToLower - converte tidos os caracteres p minusculo

            //nome = Console.ReadLine().ToUpper();
            //Console.WriteLine();

            //Console.WriteLine("Olá" + nome + "digite sua idade");
            //Console.WriteLine(String.Format("Olá {0} digite sua idade: ", nome));

            //Console.WriteLine($"Olá {nome} digite a sua idade: ");
            //idade = int.Parse(Console.ReadLine());

            //Console.WriteLine();
           // Console.WriteLine($"Seu nome é {nome} e voce tem {idade} anos.");

            //Estrutura de decisão SE | SENÃO
            //if (idade >= 18)
           // {
               // Console.WriteLine("Voce é maior de idade");
          //  }
            //else
          //  {
                //Console.WriteLine("Voce é menor de idade");
         //   }

            //Estrutura de repetição
            int valor = 0;

            while (valor <= 10)
            {
                Console.WriteLine(valor);
                valor++;
                //valor += 2;
            }

            int valor2 = 0;
            do
            {
                Console.WriteLine(valor2);
                valor2++;
            } while (valor2 <= 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
