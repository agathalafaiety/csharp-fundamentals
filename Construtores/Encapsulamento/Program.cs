using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite o valor do depósito inicial: ");
            double deposito = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Conta c1 = new Conta();
            c1.SetTitular(titular);
            c1.Deposito(deposito);

            Console.WriteLine("Qual o valor do deposito? ");
            deposito = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(c1.Deposito(deposito));

            Console.WriteLine($"Seu novo saldo é: {c1.GetSaldo()}\n");


        }
    }
}
