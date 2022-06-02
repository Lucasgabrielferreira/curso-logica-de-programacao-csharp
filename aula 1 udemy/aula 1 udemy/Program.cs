using System;
using System.Globalization;
namespace aula_1_udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int Quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(Nome);
            Console.WriteLine(Quarto);
            Console.WriteLine(Preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
