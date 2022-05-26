
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEmClases
{
    public class MinhaMae
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public List<Filho> meusFilhos = new List<Filho>();

        public MinhaMae() {    }

        public MinhaMae(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
