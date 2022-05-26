using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    public class Animal
    {
        public string QualAnimal { get; set; }
        public string Apelido { get; set; }
        public string Tipo { get; set; }

        public Animal()
        {
        }

        public Animal(string qualAnimal, string apelido, string tipo)
        {
            QualAnimal = qualAnimal;
            Apelido = apelido;
            Tipo = tipo;
        }
    }
}
