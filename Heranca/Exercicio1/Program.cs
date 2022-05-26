using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma classe chamada Forma
            //Atributos
            //EnumCor Cor {amarelo, azul, vermelho}
            //EnumTipo Tipo {quadrado, retangulo}
            //Crie uma classe chamada Quadrado herdando de Forma
            //Atributos
            //int Lado
            //Crie uma classe chamada Retangulo herdando de Forma
            //Atributos
            //int Base
            //int Altura

            Quadrado quadrado = new Quadrado();
            quadrado.Cor = EnumCor.amarelo;
            quadrado.Tipo = EnumTipo.quadrado;
            quadrado.Lado = 3;

            Retangulo ret = new Retangulo();
            ret.Cor = EnumCor.vermelho;
            ret.Tipo = EnumTipo.retangulo;
            ret.Base = 4;
            ret.Altura = 2;
        }
    }
}
