using System;

namespace ExerciciosEntradaDeDados {
    class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine();

            string[] vetor = frase.Split(' ');
            string f1 = vetor[0];
            string f2 = vetor[1];

            Console.WriteLine($"{f1} {f2}");
        }
    }
}
