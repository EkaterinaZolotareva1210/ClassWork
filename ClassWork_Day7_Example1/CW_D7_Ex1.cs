using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day7_Example1
{
    internal class CW_D7_Ex1
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 10;
            int sum = CalcSum(a, b); //важны не имена перемеенных, а последовательность данных в скобках
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static int CalcSum(int number1, int number2) 
        {
            return number1 + number2;
        }
    }
}
