using System;
using System.Globalization;
using System.Linq;

namespace ExercicioConversaoDadosEntrada {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco do produto:");
            double produto= double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split(' ');
            
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
            
        }
    }
}
