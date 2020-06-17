using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5];

            alunos[0] = new Aluno("ana");
            alunos[1] = new Aluno("maria");
            alunos[2] = new Aluno("bia");
            alunos[3] = new Aluno("paulo");
            alunos[4] = new Aluno("joao");

            // ler o array[] com laço for
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine(alunos[i]);
            }

            Console.WriteLine();

            // ler array com laço forech
            foreach (var item in alunos)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }           


        private class Aluno
        {
            public string Nome{ get; set; }

            public Aluno(string nome)
            {
                Nome = nome;
            }

            public override string ToString()
            {
                return Nome;
            }
        }

    } 
}
