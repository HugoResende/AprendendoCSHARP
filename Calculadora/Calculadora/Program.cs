using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
           
        {
            int n1 = 0;
            int n2 = 0;
            int total = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            Console.WriteLine("Digite o primeiro valor");
           n1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Digite o segundo valor");
            n2 = Convert.ToInt32(Console.ReadLine());
            total = n1 + n2;
            total2 = n1 - n2;
            total3 = n1 * n2;
            total4 = n1 / n2;
            Console.WriteLine("O valor da soma é = " + total);
            Console.ReadLine();
            Console.WriteLine("O valor da Subtração é = "+ total2);
            Console.WriteLine("O valor da Multiplicação é = " + total3);
            Console.WriteLine("O valor da DivisãO = " + total4);
            Console.ReadLine();
        }
    }
}
