﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 -  Criando variaveis");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);


            idade = (10 + 5) * 2;
            Console.WriteLine("Sua Idade é " + idade + "!");


            Console.WriteLine("Aperte Enter, Para Sair....!");
            Console.ReadLine();

        }
    }
}
