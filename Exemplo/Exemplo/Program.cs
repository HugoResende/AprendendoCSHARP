using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar Var
            String nome = "calculadora";
            int mes = 10;

            //Escreve Texto na tela
            Console.WriteLine(nome);
            Console.WriteLine(mes);
            Console.WriteLine("-----Calculadora-----");
            Console.WriteLine("Digite o primeiro Valor");
            Console.ReadLine();
            Console.WriteLine("Digite o segundo valor");
            Console.ReadLine();
            //Apenas para o console fechar
            Console.ReadLine();

        }
    }
}
