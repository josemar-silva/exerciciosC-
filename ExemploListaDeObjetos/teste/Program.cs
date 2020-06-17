using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qualtos funcionarios serao registrados?");
            var numeroFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios = new List<Funcionario>();


            for (int i = 0; i < numeroFuncionarios; i++)
            {
                Console.WriteLine("informe o Id do funcionario:");
                var idFuncionario = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o nome do funcionario:");
                var nome = Console.ReadLine();
                Console.WriteLine("informe o salario do funcionario:");
                var salario = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                listaFuncionarios.Add(new Funcionario(idFuncionario, nome, salario));
            }

            foreach (var obj in listaFuncionarios)
            {
                Console.WriteLine(obj.ToString());
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("informe o id do funcionario para aplicar o aumento salarial");
            var idFunc = int.Parse(Console.ReadLine());
        }

        private class Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public double Salario { get; set; }

            public Funcionario()
            {
            }

            public Funcionario(int id, string nome, double salario)
            {
                Id = id;
                Nome = nome;
                Salario = salario;
            }

            public double AumentarSalario()
            {

                return Salario;
            }

            public override string ToString()
            {
                return $@"ID do Funcionario: {Id}
Nome do Funcionario: {Nome} 
Salario do Funcionario: {Salario}";
            }
        }
    }

}

