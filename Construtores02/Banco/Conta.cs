using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Conta
    {
        private double _saldo;
        public double _saque;
        public double _deposito;

        public int IdConta { get; set; }

        protected Conta(int idConta)
        {
            IdConta = idConta;
        }

        public virtual void Deposito()
        {
            Console.WriteLine(0);
        }

        public virtual void Saque()
        {
            Console.WriteLine(0);
        }
    }
}
