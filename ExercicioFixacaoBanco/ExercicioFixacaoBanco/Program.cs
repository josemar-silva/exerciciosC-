using System;
using System.Net.NetworkInformation;
using System.Globalization;

namespace ExercicioFixacaoBanco {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Informe o nome do titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Conta c1;

            Console.WriteLine("Deseja inicar a conta com um deposito (S/N)?");
            char resposta = char.Parse(Console.ReadLine());
                if (resposta == 'S' || resposta == 's'){
                Console.WriteLine("Valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(nome, depositoInicial, numero);
            } else {
                c1 = new Conta(nome, numero);
                Console.WriteLine();
            }

            Console.WriteLine(c1);
            Console.WriteLine();

                Console.WriteLine("Informe o valor a ser depositado: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Depositar(deposito);
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.WriteLine("Informe o valor do saque a ser realizado: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Sacar(saque);
            Console.WriteLine(c1);



        }
    }
}
