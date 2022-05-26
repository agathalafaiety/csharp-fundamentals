using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloPrivado
{
    public class Pai
    {
        public string Nome { get; set; }
        protected string Segredo;

        public void DefineSegredo(String frase)
        {
            Segredo = frase;
        }

    }
}
