using System;
using System.Globalization;




namespace Experiencias;

class Program
{
    static void Main(string[] args)
    {
        int N, C, R, S;
        N = int.Parse(Console.ReadLine());
        C = 0;
        R = 0;
        S = 0;

        for (int i = 1; i <= N; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cobaias = int.Parse(vet[0]);
            char animal = char.Parse(vet[1]);
             if (animal == 'C')
            {
                C = cobaias + C;
            }else if (animal == 'R')
            {
                R = cobaias + R;
            }else if (animal == 'S')
            {
                S = cobaias + S;
            }
                       
        }
        int total = C + R + S;
        double percentualC = (double)C / total * 100;
        double percentualR = (double)R / total * 100 ;
        double percentualS = (double)S / total * 100 ;
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + C);
        Console.WriteLine("Total de ratos: " + R);
        Console.WriteLine("Total de sapos: " + S);
        Console.WriteLine("Percentual de coelhos: " + percentualC.ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + percentualR.ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + percentualS.ToString("F2") + " %");


        Console.ReadLine();

    }
}