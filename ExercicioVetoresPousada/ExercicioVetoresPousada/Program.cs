using Microsoft.VisualBasic;
using System;
using System.Net.Mail;

namespace ExercicioVetoresPousada {
    class Program {
        static void Main(string[] args) {

            Quarto[] q; // iniciando vetor com '0' posicoes

            Console.WriteLine("informe o numero de estudantes:");
            int e = int.Parse(Console.ReadLine());

            q = new Quarto[10];

           for (int i = 0; i < e; i++) {
               Console.WriteLine("Informe o nome do estudante:");
               string nome = Console.ReadLine();

               Console.WriteLine("Information o endereco de e-mail:");
               string mail = Console.ReadLine();

               Console.WriteLine("Qual numero do quarto escolhido?");
               int quarto = int.Parse(Console.ReadLine());

                q[quarto] = new Quarto { Nome = nome, Email = mail, QuartoEsc = quarto };
            }

            for (int i = 0; i < e; i++) {

                if (q[i] != null) {
                    Console.WriteLine(q[i]);
            }
            }
        }
            
    }
}


    
