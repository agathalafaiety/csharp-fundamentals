// 1. Crie um programa que leia o nome e a idade de uma pessoa. Exiba na tela a seguinte frase: “Olá {nome}, você provavelmente nasceu em ‘aaaa’.”
using System;
using System.Collections.Generic;
using System.Linq;                    //modulos
using System.Text;
using System.Threading.Tasks;

namespace Variaveis  //POO
{
    class Program //inicio do programa    
    {
        static void Main(string[] args) //função principal

        {      

           /* Variaveis
            Int - -156 ou 22  
            Float - -15.6 ou 22.12
            Bool - true our false
            String - "Agatha Lafaiety"
            Char - 'a' só pode usar um caractere
           */
            
            // = é atribuição de valores 
            string nome; // caracter
            int idade; // numero inteiro
            double altura; // numero real
            bool resposta = false;

            Console.WriteLine("Digite seu nome: "); // Escreve na tela 
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: "); 
            // converter o valor de string para int
            // Parse ==> TipoDoDado.Parse("frase")
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: (Ex.: 1,88)");
            altura = double.Parse(Console.ReadLine());
            // $"" concatenação
        
            Console.WriteLine($" {nome} voce tem {idade} anos e mede {altura}.");

            Console.ReadKey(); 

        }
    }
}
