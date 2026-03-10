using System;
using System.Globalization;



namespace EstruturaCondicional;

class Program
{
    static void Main(string[] args)
    {
        double N1, N2, N3;
        string[] vet = Console.ReadLine().Split(' ');
        N1 = double.Parse(vet[0]);
        N2 = double.Parse(vet[1]);
        N3 = double.Parse(vet[2]);

        double A, B, C;

        if (N1 > N2 && N1 > N3)
        {
            A = N1;
            if (N2 > N3)
            {
                B = N2;
                C = N3;
            }
            else
            {
                B = N3;
                C = N2;
            }
        } else if (N2 > N3)
        {
            A = N2;
            if (N1 < N3)
            {
                B = N1;
                C = N3;
            } else
            {
                B = N3;
                C = N1;
            }
        }
        else
        {
            A = N3;
            if (N1 > N2)
            {
                B = N1;
                C = N2;
            } else
            {
                B = N2;
                C = N1;
            }
        }
        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (A * A == B * B + C * C)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (A * A > B * B + C * C)
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (A == B && A == C)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (A == B || A == C || B ==C)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }

            Console.ReadLine();



    }
}