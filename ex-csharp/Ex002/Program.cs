using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string nome;
            int nasc, idade;
            //Leitura das variáveis
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o ano em que nasceu:");
            nasc = int.Parse(Console.ReadLine());
            //Processamento e exibição 
            idade = System.DateTime.Now.Year - nasc;
            Console.WriteLine($"Olá {nome}, você tem {idade} anos.");

        }
    }
}
