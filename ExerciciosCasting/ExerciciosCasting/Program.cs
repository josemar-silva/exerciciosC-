using System;

namespace ExerciciosCasting {
    class Program {
        static void Main(string[] args) {
            int n1 = 10;
            int n2 = 7;
            double resultado = (double)(n1 + n2) / 2; // casting para double aceitar um int
            Console.WriteLine(resultado);

           
        }
    }
}
