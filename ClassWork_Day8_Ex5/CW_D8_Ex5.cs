using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day8_Ex5
{
    internal class CW_D8_Ex5
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int i=Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(arr[i]);
            }

            catch (IndexOutOfRangeException) when (DateTime.Now.Hour>=9 &&DateTime.Now.Hour<17) //when - фильтр исключений, должны совпасть и тип исключения, и условие фильтра
            {
                Console.WriteLine("Индекс за пределами массива!");
            }

            Console.ReadKey();
        }
    }
}
