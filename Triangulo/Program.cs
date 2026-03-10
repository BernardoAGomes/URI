using System;
using System.Globalization;



namespace Triangulo;

class Program
{
    static void Main(string[] args)
    {
        double A, B, C, area, perimetro;
        string[] vet = Console.ReadLine().Split(' ');
        A = double.Parse(vet[0]);
        B = double.Parse(vet[1]);
        C = double.Parse(vet[2]);


        if (A < B + C && B < A + C && C < A + B)
        {
            perimetro = A + B + C;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
        } else
        {
            area = ((A + B) * C) / 2;
            Console.WriteLine("Area = " + area.ToString("F1"));
        }

        Console.ReadLine();

    }
}