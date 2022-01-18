using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
        int testCase = int.Parse(Console.ReadLine());
        int contadorEsfera = 0;
        for (int i = 0; i < testCase; i++)
         {
          int N = int.Parse(Console.ReadLine());
  				contadorEsfera = (int)Math.Pow(N,0.5);
			  	Console.WriteLine(N - contadorEsfera);
		 }
      }
    }
}