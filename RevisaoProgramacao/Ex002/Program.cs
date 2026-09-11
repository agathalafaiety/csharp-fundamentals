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

            int idade;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Voce não pode votar!");
            }
            else
            {
                if (idade >= 18 && idade <= 65)
                {
                    Console.WriteLine("Voce é obrigado a votar!");
                }
                else
                {
                    Console.WriteLine("Voto facultativo!");
                }
                // Alnhamento de codigo
                // Ctrl + K + D 
            }
        }
    }
}
