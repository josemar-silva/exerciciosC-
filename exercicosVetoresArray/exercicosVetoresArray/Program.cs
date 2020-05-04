using System;
using System.Globalization;
namespace exercicosVetoresArray {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            double[] array1 = new double[n];
            double s = 0;

            for (int i = 0; i < n; i++) {  // ler o vetor
                array1[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);              
            }

            for (int i = 0; i < n; i++) {
                s += array1[i];    // ler vetor e somar ao valor de 'i' a variavel 's' a cada loop do 'for'
            }

            double media = s / n;

            Console.WriteLine();
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine();
            Console.WriteLine(media);
          
        }
    }
}
