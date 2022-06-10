using System;
using System.Globalization;
namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z, maiorXY, maior;

            string[] valores = Console.ReadLine().Split(' ');
            X = int.Parse(valores[0], CultureInfo.InvariantCulture);
            Y = int.Parse(valores[1], CultureInfo.InvariantCulture);
            Z = int.Parse(valores[2], CultureInfo.InvariantCulture);

            maiorXY = (X + Y + Math.Abs(X - Y)) / 2;

            maior = (maiorXY + Z + Math.Abs(maiorXY - Z)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}

