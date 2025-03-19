using System; //подключение класса System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day6
{
    internal class CW_D6_Ex1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            Console.Write("Что заменять? ");
            string find =Console.ReadLine();

            Console.Write("На что заменять? ");
            string replace = Console.ReadLine();

            string result = str.Replace(find, replace);

            Console.ReadKey();
        }
    }
}
