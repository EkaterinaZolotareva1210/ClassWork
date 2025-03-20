using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day7_Example2
{
    internal class CW_D7_Ex2
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5};
            PrintArray(a);
            Console.ReadKey();
        }
        static void PrintArray(int[] array) //void - признак метода, не возвращающего значение
        {
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
        }
      
    }
}
