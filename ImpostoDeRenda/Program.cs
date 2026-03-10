using System;
using System.Globalization;



namespace ImpostoDeRenda;

class Program
{
    static void Main(string[] args)
    {
        double salario, imposto;
        salario = Double.Parse(Console.ReadLine()); 

        if (salario >= 0 && salario <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else if (salario <= 3000.00)
        {
            imposto = (salario - 2000.00) * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
        else if (salario <= 4500.00)
        {
            imposto = (salario - 3000) * 0.18 + 1000.00 * 0.08;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }
        else if (salario > 4500.00)
        {
            imposto = (salario - 4500) * 0.28 + 1000.00 * 0.08 + 1500 * 0.18;
            Console.WriteLine("R$ " + imposto.ToString("F2"));
        }

        Console.ReadLine();



    }
}