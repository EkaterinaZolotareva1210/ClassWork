using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day5
{
    internal class CW_D5_Ex1
    {
        static void Main(string[] args)
        {
            const int n = 4;
            int[] t = new int[n] { 1,2,3,4}; //в фигурных скобках перечислены элементы массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(t[i]);
            }
            foreach (int a in t) //используется только для чтения
            {
                Console.WriteLine(a);
            }
            const int m = 10;//заполнение массива 10 лучайными числами от 0 до 10 и подсчет итоговой суммы
            int s = 0;
            int[] t1 = new int[m];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                t1[i] = rnd.Next(0, 11);

                Console.Write("{0 }",t1[i]);
                s += t[i];
            }
            Console.WriteLine();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
