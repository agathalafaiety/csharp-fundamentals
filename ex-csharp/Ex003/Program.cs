// 3. Crie um programa que leia 3 valores inteiros e exiba no final a média desses valores.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            double valor1, valor2, valor3, media;
            //leitura das variáveis
            Console.WriteLine("Digite o 1º valor: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º valor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º valor: ");
            valor3 = double.Parse(Console.ReadLine());
            //processamento e exibição
            media = (valor1 + valor2 + valor3) / 3;
            Console.WriteLine($"A média dos 3 números é {media:F2}.");
            //Formatação de valores com .ToString
            //https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings
        }
    }
}
