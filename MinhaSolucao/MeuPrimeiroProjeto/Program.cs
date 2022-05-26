using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variavel 

            //Caracter
            string nome = "mouse", sobrenome;

            nome = "Teclado";

            Console.WriteLine("Meu nome é " + nome);

            //Inteiro
            int idade;
            idade = 30;

            Console.WriteLine("Olá " + nome + " Voce tem " + idade + " anos ");

            //real
            double altura = 1.71;

            Console.WriteLine(altura);

            //logico
            bool res = true;

            // comentario em linha 

            /*
             * cometario de bloco
             * 
             */

            //Escrever itens na tela
            Console.WriteLine("Agatha");
            Console.WriteLine("ETEC");

            Console.WriteLine("Digite seu nome e sobrenome");
            nome = Console.ReadLine();
            sobrenome = Console.ReadLine();
            Console.WriteLine("seu nome completo é " + nome + " " + sobrenome);

        }
    }
}
