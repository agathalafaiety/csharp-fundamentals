using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEmClases
{
    public class Filho
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }

        public Filho()
        {

        }

        public Filho(string nome, int idade, string genero)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }



    }
}
