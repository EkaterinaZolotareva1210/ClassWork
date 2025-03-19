using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class CW_D2_Ex1
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;
            int n2 = c * 100 + b * 10 + a;


            Console.WriteLine(n2);
            Console.ReadKey();

        }
    }
}
