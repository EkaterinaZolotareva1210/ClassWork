using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day8_Ex1
{
    internal class CW_D8_Ex1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine()); //деление на 0 вещественного числа double результат будет infinity, является исключением, деление 0 на 0 дает NaN
                int b = Convert.ToInt32(Console.ReadLine()); //в лекциях есть сслыка на статью по С++ где описаны исключения для разных операций

                Console.WriteLine("Начало операции...");
                Console.WriteLine(a / b);
            }
            //catch (Exception e) //базовый класс всех исключений; блоков может быть несколько = несколько типов исключений
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0!");
                //Console.WriteLine(e.Message);//свойства,тип исключение - что произошло
                //Console.WriteLine(e.Source);//в каком месте произошло исключение
                //Console.WriteLine(e.TargetSite);//указание метода, создавшего текущее исключение
                // Console.WriteLine(e.StackTrace);//тестовое представление стека вызова
                // Console.WriteLine(e.ToString()); //метод - текстовое представление объекта

            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод");
            }
           // finally
            {
               // Console.WriteLine("Операция завершилась");//обычно на этом этапе закрываются подключения к БД, освобождаются элементы, закрываются файлы и т.д.
            }
            Console.ReadKey();
        }
    }
}
