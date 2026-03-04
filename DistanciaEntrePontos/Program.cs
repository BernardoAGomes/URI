using System;
using System.Globalization;


namespace DistanciaEntreDoisPontos;

class Program
{
    static void Main(string[] args)
    {
        double x1, y1, x2, y2, distancia;
        string[] vet = Console.ReadLine().Split(' ');
        x1 = double.Parse(vet[0]);
        y1 = double.Parse(vet[1]);
        string[] vet2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(vet2[0]);
        y2 = double.Parse(vet2[1]);

        distancia = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + (Math.Pow((y2 - y1), 2.0)));

        Console.WriteLine(distancia.ToString("F4"));


        Console.ReadLine();

    }
}
