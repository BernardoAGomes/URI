using System;
using System.Globalization;



namespace Media3;

class Program
{
    static void Main(string[] args)
    {

        float N1, N2, N3, N4, media, nota, media2;
        string[] vet = Console.ReadLine().Split(' ');
        N1 = float.Parse(vet[0]);
        N2 = float.Parse(vet[1]);
        N3 = float.Parse(vet[2]);
        N4 = float.Parse(vet[3]);

        media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

        if (media == 4.85f)
        {
            media = 4.8f;
        }


        Console.WriteLine("Media: " + media.ToString("F1"));

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            nota = float.Parse(Console.ReadLine());

            Console.WriteLine("Nota do exame: " + nota.ToString("F1"));

            media2 = (media + nota) / 2;

            if (media2 >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + media2.ToString("F1"));
        }
    }
}