using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
           //  var names = new List<String> {"Shakib", "Shameem", "Shawan"};
           // names.Add("Hati");
           // names.Remove("Shameem");
           //
           //  foreach (var name in names)
           //  {
           //      Console.WriteLine($"{name.ToUpper()} ");
           //  }
           //  Console.WriteLine($"my name is {names[0]}");
           //  Console.WriteLine($"The list has {names.Count} values ");
           //  Console.WriteLine(names.IndexOf("Shawan"));
           //  

           var fibonacci = new List<int>{1,1};
           while (fibonacci.Count < 20)
           {
               var fibonacciNumber = fibonacci[fibonacci.Count - 1];
               var fibonacciNumber2 = fibonacci[fibonacci.Count - 2];
               fibonacci.Add(fibonacciNumber+fibonacciNumber2);
               
           }

           
           foreach (var fibo in fibonacci)
           {
              
               Console.WriteLine(fibo);
           }

        }
    }
}