using System;
using System.Globalization;

namespace AreaDoCirculo;

class Program
{
    static void Main(string[] args)
    {

        double area, n, raio, y;

        
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
     
        n = 3.14159;
        

        area = n * raio * raio;

        Console.WriteLine("A = " + area.ToString("F4"), CultureInfo.InvariantCulture);
            

        Console.ReadLine();



    }
}

