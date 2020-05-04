using System;

namespace ExemplosmModificadorParams {
    class Program {
        static void Main(string[] args) {

                             // Solução com vetor

            int result1 = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            Console.WriteLine(result1);

                             // Solução com modificador params:

            int result2 = Calculator.Soma(10, 20, 30, 40);

            Console.WriteLine(result2);


        }
    }
}
