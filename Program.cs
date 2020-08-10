using System;
using System.Globalization;

namespace Exercicio14 {
    class Program { 
        static void Main(string[] args) {

            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < N; i++) { 
                vet[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++) {
                Console.WriteLine(vet[1].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
