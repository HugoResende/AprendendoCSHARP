using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CoversõesEOutrosTiposNuméricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;
            // int é uma variavel de 32 bit
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);
            //long é uma variavel de 64 bits
            long idade = 1600000000000;
            Console.WriteLine(idade);
            // short é uma variavel de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);
            //Float
            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();
        }
    }
}
