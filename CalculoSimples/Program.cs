using System;
using System.Globalization;

namespace CalculoSimples;

class Program
{
    static void Main(string[] args)
    {

        int codigo1, codigo2, numero1, numero2;
        double valor1, valor2,total;
        string[] vet;

        vet = Console.ReadLine().Split(' ');
        codigo1 = int.Parse(vet[0]);
        numero1 = int.Parse(vet[1]);
        valor1 = double.Parse(vet[2]);
        vet = Console.ReadLine().Split(' ');
        codigo2 = int.Parse(vet[0]);
        numero2 = int.Parse(vet[1]);
        valor2 = double.Parse(vet[2]);

        
        total = (numero1 * valor1) + (numero2 * valor2);


        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
        Console.ReadLine();

    }
}