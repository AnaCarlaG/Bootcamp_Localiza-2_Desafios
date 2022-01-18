using System;
using System.Collections.Generic;

class Program {
  
  static void Main(string[] args) {
      var listaJoia = new HashSet<string>();

      for (int i = 0; i < 107; i++)
      {
          string joia = Console.ReadLine();
          if (String.IsNullOrWhiteSpace(joia))
          {
              break;
          }
          else
          {
              listaJoia.Add(joia);
          }
      }

      Console.WriteLine(listaJoia.Count);
  }

}