using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta conta = new Conta();

            PessoaTitular pessoaTitular = new PessoaTitular("Maria", 18, 10.000, 212);

            Corrente corrente = new Corrente(15.000, 211);

            Poupanca poupanca = new Poupanca(210);

            Console.WriteLine($"");
            
        }

    }
}
