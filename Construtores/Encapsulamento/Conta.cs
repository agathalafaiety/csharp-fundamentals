using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
     public class Conta
    {
        string _titular;
        double _saldo;

        //Metodo manipuladores GET | SET 
        //GET - pegar | SET - colocar
        //GET - retorno

        public string GetTitular()
        {
            return _titular;
        }

        public void SetTitular(string nome)
        {
            _titular = nome;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

         //SET
        public string Deposito(double valor)
        {
            _saldo += valor;
            return $"Depósito efetivado com sucesso!";
        }
    }
}
