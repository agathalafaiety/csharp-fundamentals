using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContClasses
{
    public class Pessoa
    {
        //Atributos
        private string _nome;
        private int _idade;
        private double _peso;
       
        // atalho -para propriedade - prop tab2

        public double Altura { get; private set; }


        //Construtores

        //Padrão
        public Pessoa()
        {

        }


        //Parametros
        public Pessoa(string nome, int idade, double peso)
        {
            _nome = nome;
            _idade = idade;
            _peso = peso;
        }

        //Encapsulamento Get(retorno)/Set(opcional)
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string valor)
        {
            _nome = valor;
        }

        //Propriedades (get/set)
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }

        }

        public double Peso
        {
            get { return _peso; }
            set {
                if (value > 0)
                {
                    _peso = value;
                }
             }
        }
    }
}
