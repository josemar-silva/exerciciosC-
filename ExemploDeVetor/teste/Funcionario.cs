using System;
using System.Collections.Generic;
using System.Text;

namespace teste
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }
     

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }
        public Funcionario()
        {
         
        }

        public override string ToString()
        {
            return Nome + ", " + Id + "," + Salario;
        }

    }
}
