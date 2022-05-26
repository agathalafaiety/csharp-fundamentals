// 4. Crie um programa que leia o nome de um produto, o seu valor unitário e a quantidade em estoque. Exiba no final a seguinte frase: “{Produto} – R$ {Valor Unitário} – Total: {Total}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            string produto;
            double valor;
            int estoque;

            //leitura das variáveis
            Console.WriteLine("Digite o nome do produto: ");
            produto = Console.ReadLine();
            Console.WriteLine("Qual é o valor do produto?");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos itens existem no estoque?");
            estoque = int.Parse(Console.ReadLine());

            //processamento e exibição
            //Exibição por posição de valores
            //cada valor entre {}, iniciado em 0 - zero, é alocado após a vírgula
            Console.WriteLine("Produto: {0}   Valor Unitário: {1:C2}   Valor em Estoque: {2:C2}", produto, valor, estoque * valor);
        }
    }
}
