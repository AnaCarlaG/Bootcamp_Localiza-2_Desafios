using System;

namespace DIO {
    class Program {
        static void Main(string[] args) {
           
            int N = int.Parse(Console.ReadLine());
            if (N > 0 && N <= 106) {
            //Exibir "Ho" do papai noel
            for (int i = 1; i < N; i++) {
              Console.Write("Ho ");                 
              }  
            }
            Console.WriteLine("Ho!");
        }
    }
}