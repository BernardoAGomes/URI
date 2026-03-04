using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            double MEDIA;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double pesoA = 2;
            double pesoB = 3;
            double pesoC = 5;
            MEDIA = (a * pesoA + b * pesoB + c * pesoC) /(pesoA + pesoB + pesoC);



            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
            Console.ReadLine();

        }
    }
}