using System;
using System.Globalization;



namespace TempoDeJogo;

class Program
{
    static void Main(string[] args)
    {
        int Hi, Hf, jogo;
        string[] vet = Console.ReadLine().Split(' ');
        Hi = int.Parse(vet[0]); 
        Hf = int.Parse(vet[1]);

        if (Hi < Hf)
        {
            jogo = Hf - Hi;
        }
        else
        {
            jogo = 24 - Hi + Hf;
        }
        Console.WriteLine("O JOGO DUROU " + jogo + " HORA(S)");
        
        
            Console.ReadLine();



    }
}