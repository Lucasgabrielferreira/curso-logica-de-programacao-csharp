using System;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            String[] valores = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            for(int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.WriteLine(vet[i] + " ");
                }
            }
            Console.WriteLine();

            int quantidadesDePares = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    quantidadesDePares++;
                }
            }
            Console.WriteLine(quantidadesDePares);
        }
    }
}
