using System;
using System.Globalization;
namespace ExercicioDeFixacaoCriacaoDeClasses02 {
    class Program {
        static void Main(string[] args) {
            // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            //médio dos funcionários.

          

            Console.WriteLine("Infome o nome do primeiro funcionario:");
            string nome = Console.ReadLine();
            Console.WriteLine("Infome o salario do primeiro funcionario:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Infome quantidade de dependentes do primeiro funcionario:");
            int membrosFamilia = int.Parse(Console.ReadLine());

            Funcionario f1 = new Funcionario(nome, salario, membrosFamilia);

            Console.WriteLine("Infome o nome do segundo funcionario:");
            nome = Console.ReadLine();
            Console.WriteLine("Infome o salario do segundo funcionario:");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Infome quantidade de dependentes do segundo funcionario:");
            membrosFamilia = int.Parse(Console.ReadLine());

            Funcionario f2 = new Funcionario(nome, salario, membrosFamilia);

            Console.WriteLine(f1);
            Console.WriteLine(f2);

            f2.Salario = 1000.00;
            
            Console.WriteLine();
            Console.WriteLine(f2.Nome +" recebeu aumento salarial de R$ 100.00");
            Console.WriteLine();
            Console.WriteLine("Dados atualizados funcionario " + f2.Nome);
            Console.WriteLine(f2);
            Console.WriteLine();
        }
    }
}
