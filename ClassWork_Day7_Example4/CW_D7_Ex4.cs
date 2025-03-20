using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day7_Example4
{
    internal class CW_D7_Ex4
    {
        static void Main(string[] args)
        {
            Greet("Вася");
            Greet("Коля", "Привет");
            Console.ReadKey();
        }

        static void Greet(string name, string greeting = "Hello")
        {
            Console.WriteLine($"{greeting}, {name}");
        }
        
    }
}
