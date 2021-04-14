// 5. Faça um programa que leia uma distância em Km. Sabe-se que o veículo faz 9 Km/l e que o combustível custa R$ 3,99 por litro. Informe no final o valor aproximado do custo da viagem.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            double dist, valor;
            //leitura das variáveis
            Console.WriteLine("Qual é a distância que será percorrida? (Km)");
            dist = double.Parse(Console.ReadLine());
            //processamento e exibição
            valor = (dist / 9) * 3.99;
            Console.WriteLine("O valor aproximado da viagem será de {0:C2}", valor);

        }
    }
}
