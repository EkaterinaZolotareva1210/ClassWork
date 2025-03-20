using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day7_Example3
{
    internal class CW_D7_Ex3
    {
        static void Main(string[] args)
        {
            int a1 = 5;
            int b1 = 15;
            int result1 = Sum(a1, b1);
            Console.WriteLine(result1);

            double a2 = 2.5;
            double b2 = 1.5;
            double result2 = Sum(a2, b2);
            Console.WriteLine(result2);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b) //Sum - перегруженный метод, т.к. выполняет одинаковую операцию с данными разных типов
        {
            return a + b;
        }
    }
}
