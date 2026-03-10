using System;
using System.Globalization;




namespace SortSimples;

class Program
{
    static void Main(string[] args)
    {
        
        int A, B, C, N1, N2, N3;
        string[] vet = Console.ReadLine().Split(' ');
        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);
        C = int.Parse(vet[2]);

        if (A < B && A < C)
        {
            N1 = A;
            if (B < C)
            {
                N2 = B;
                N3 = C;
            }
            else
            {
                N2 = C;
                N3 = B;
            }
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        if (B < A && B < C) {
            N1 = B;
            if (A < C)
            {
                N2 = A;
                N3 = C;
            }
            else
            {
                N2 = C;
                N3 = A;
            }
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
        if (C < A && C < B)
        {
            N1 = C;
            if (A < B)
            {
                N2 = A;
                N3 = B;
            }
            else
            {
                N2 = B;
                N3 = A;
            }
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }







        Console.ReadLine();



    }
}