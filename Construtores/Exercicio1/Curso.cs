using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Curso
    {
        public string _titulo;
        public string _descricao;
        public string _periodo;

        public Curso() { }

        public Curso(string titulo, string descricao, string periodo)
        {
            _titulo = titulo;
            _descricao = descricao;
            _periodo = periodo;
        }

        public override string ToString()
        {
            return $">>>>> Cursos <<<<<\n" +
                $"\n" +
                $"C{_titulo} - {_periodo}\n" +
                $"{_descricao}. " +
                $"\n";
        }

    }
}
