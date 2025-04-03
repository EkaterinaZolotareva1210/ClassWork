using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day9_Ex1
{
    internal class CW_D9_Ex1
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Bonny", "grey", 5, false); //создание экземпляра класса
            //Cat cat1 = new Cat("Poppy");
            //Cat cat2 = new Cat();//конструктор по умолчани
            //Cat cat = new Cat();
            //cat.Age = 1;
            //cat.Name = "Fluffy";
            //cat.Colour = "white";
            //cat.Say();
            Cat.PrintCount();
            Console.WriteLine(cat);//метод writeline автоматически выводит метод tostring
            Console.WriteLine(Cat.count);
            Console.ReadKey();
        }
    }

    class Cat //класс - это описание, а не сущность; класс - это тип данных, как int или double
    {
        public static int count = 0;//поле static доступно независимо от экземпляра, к нему можно обратиться без экземпляра; характеристика класса целиком
        public const int countFeet = 4; //константа - характеристика, которая не меняется в течение жизни объекта; разу инициализируется и больше не меняется
        public readonly bool fur = true; // поле  readonly можно задавать при создании или в конструкторе
        public string Name { get; private set; }//автосвойство - компилятор автоматически создает закрытое приватное поле; private set - доступ на запись только внутри класса
        public string Colour { get; set; }//автосвойство легко превратить в свойство и добавить проверки
        int age;

        public int Age //свойство - что-то среднее между методом и публичым полем
        {
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else 
                {
                    age = 0;
                }
            }
            get 
            {
                return age;
            }
        }

       public Cat(string name, string colour = "черный", int age = 1, bool fur=true) //конструктор - это такой тип метода, имя которого совпадает с именем класса, инициалиируют поля с конкретными значениями
       {
            Name = name;
            Colour = colour;
            Age = age;
            this.fur = fur;
            count++;
       }

        public void Say() //private - методы, достпупные только в рамках класса, public - методы, доступные наружу
        {
            Console.WriteLine($"{Name}, {Colour},{Age}"); //обращение к возрасту через свойство - поэтому Age с прописной
        }

        public static void PrintCount()
        {
            Console.WriteLine(count);
        }

        public override string ToString()//переопределение родительского метода ToString класса Object
        {
            return $"{Name}, {Colour},{Age}";
        }
    }
}
