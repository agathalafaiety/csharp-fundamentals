using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrutores
{
    public class Pessoa
    {
        //Atributos
        public string _nome;
        public int _idade;

        //Metodos Construtores
        //Deve ter o MESMO NOME DA CLASSE
        //Deve ser PUBLICO

        //Método padão
        public Pessoa() { }

        //Metodo com atribuição de valores
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;

        }

        //Sobrescrevendo o metodo .ToString
        //digitar "override" dar espaço e selecionar To.String

        public override string ToString()
        {
            return $">>>>> Dados Pessoais <<<<<\n" +
                $"\n" +
                $"Meu nome é {_nome} e\n" +
                $"Eu tenho {_idade} anos. " +
                $"\n";
        }
    }
}
