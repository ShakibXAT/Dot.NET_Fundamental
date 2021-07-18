//using System;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

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

            // var fibonacci = new List<int>{1,1};
            // while (fibonacci.Count < 20)
            // {
            //     var fibonacciNumber = fibonacci[fibonacci.Count - 1];
            //     var fibonacciNumber2 = fibonacci[fibonacci.Count - 2];
            //     fibonacci.Add(fibonacciNumber+fibonacciNumber2);
            //     
            // }
            //
            //
            // foreach (var fibo in fibonacci)
            // {
            //    
            //     Console.WriteLine(fibo);
            //}
            // Console.Write("Hello world");

            Person person1 = new Person("Shakib", 18);
            Console.WriteLine($"The name of the person is{person1.Name} and his age is {person1.Age}");

            Person person2 = person1;
            person2.Name = "Samrat";
            person2.Age = 24;
            Console.WriteLine($"The Person2 name is {person2.Name} and age is {person2.Age}");
            Console.WriteLine($"The Person1 name is {person1.Name} and age is {person1.Age}");
        }

    
        
    }
}