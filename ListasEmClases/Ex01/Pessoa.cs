using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Pessoa
    {
        public string Nome { get; set; }

        public List<Animal> meusAnimais = new List<Animal>();

        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}
