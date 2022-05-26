using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Corrente : Conta
    {
        public double Limite { get; set; }

        public Corrente(double limite, int idConta) : base(idConta)
        {
            Limite = limite;
        }

        public override void Deposito()
        {
            base.Deposito();
        }

        public override void Saque()
        {
            base.Saque();
        }

    }
}
