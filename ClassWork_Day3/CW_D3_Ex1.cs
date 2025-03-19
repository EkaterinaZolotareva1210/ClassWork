using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day3
{
    internal class CW_D3_Ex1
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int absoluteValue = number;
            if (number < 0)
            {
               absoluteValue = -number;
            }
         
            Console.WriteLine(absoluteValue);
            Console.ReadKey();
        }
    }
}
