using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Poupanca : Conta
    {
        
        public Poupanca(int idConta) : base(idConta)
        {

        }

        public override double Deposito(double valor1)
        {

            if (_deposito <= 0)
            {
                Console.WriteLine("Não foi possivel efetuar o deposito");
            }
            else
            {
                Console.WriteLine("Deposito efetuado com sucesso!");
            }
            return valor1;
        }

        public override double Saque(double valor2)
        {
            if (_saldo <= 0 || _saque >= _saldo)
            {
                Console.WriteLine("Não foi possivel efetuar o saque");
            }
            else
            {
                Console.WriteLine("Saque efetuado com sucesso!");
            }
             return valor2;
        }
    }
}
