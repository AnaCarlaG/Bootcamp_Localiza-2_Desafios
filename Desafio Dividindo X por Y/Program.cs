using System;

class Desafio {
    static void Main() {
     int limit = Int32.Parse(Console.ReadLine());
     double X = 0.0;
     double Y = 0.0;
        for (int i = 0; i < limit; i++) 
        {
          string[] line = Console.ReadLine().Split(" ");
          if (line.Length > 1){
              X = double.Parse(line[0]);
              Y = double.Parse(line[1]);
          
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double divisao = X / Y; 
                Console.WriteLine("{0:0.0}",divisao);
            }
          }
        }
    }
}