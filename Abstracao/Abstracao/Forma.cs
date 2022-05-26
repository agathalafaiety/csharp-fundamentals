using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    //colocar a palavra reservada ABSTRACT antes de class 
    public abstract class Forma
    {

        //Abstração
        //Não permite que sejam instanciados objetos da classe abstrata
        public string Cor { get; set; }

        //Polimosfirmo
        //Virtual indica que o metodo podera ser sobescrito pelo herdeiro
        public virtual double Area()
        {
            return 0;
        }

        //Assinaturas de metodos 
        //Determina COMO deve ser o metodo 
        //OBRIGA a classe herdeira a implementar o metodo 

        public abstract double Perimetro();

    }
}
