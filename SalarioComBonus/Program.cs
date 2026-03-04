using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor = Console.ReadLine(); 
            double fixo = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
            double salario;
            salario = fixo + (vendas * 0.15);

           

           
            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2"));
            Console.ReadLine();

        }
    }
}