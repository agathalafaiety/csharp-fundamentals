using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    public class Filho : Pai
    {
     
        public int Idade { get; set; }

        public Filho(int idade, string nome) : base(nome) //base (classe Pai)
         {
            Idade = idade;


         }                       
    }
}
