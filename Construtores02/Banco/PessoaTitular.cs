using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class PessoaTitular : Conta
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        private double _saldo;

        public PessoaTitular(string nome, int idade, double saldo, int idConta) : base(idConta)
        {
            Nome = nome;
            Idade = idade;
            _saldo = saldo;
        }
    }
}
