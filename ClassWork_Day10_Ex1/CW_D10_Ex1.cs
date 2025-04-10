using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day10_Ex1
{
    internal class CW_D10_Ex1 //в лекции примерно в 01:10:00 Катя объясняет сложную информацию про вызов методов в переопределенных классах - посмотреть, зафиксировать идею
    {
        static void Main(string[] args)
        {
            //Triangle triangle = new Triangle(1,2,3);
            RectTriangle rectTriangle = new RectTriangle(3,4); //экземпляр классов RectTriangle и Triangle
            Triangle triangle = rectTriangle; //этой переменной доступно только то, что есть в классе RectTriangle 
            Object obj = rectTriangle;
            //апкастинг - когда переменную дочернего класса превращаем в переменную родительского класса; но при этом теряется часть свойств
            //апкастинг безопасен
            
            RectTriangle triangleRect2 = (RectTriangle)triangle;
            //даункастинг - обратная передача характеристик класса от родительского класса к наследному, произойдет ошибка при невозможности преобразования
            // as - оператор преобразования, при невозможности преобразования передается значение null
            // is - условие для if, проверка типа перед приведением
            Console.ReadKey();
        }

    }

    class Triangle
    {
        // public double A { get; set; } автосвойства, стороны треугольника
        // public double B { get; set; } //автосвойства, стороны треугольника
        // public double C { get; set; } //автосвойства, стороны треугольника
        protected double a, b, c;
        public Triangle(double a, double b, double c) //конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public virtual double GetArea() //virtual - значит что метод может быть преопределн в дочернем классе
        {
            double p = (a + b + b) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //формула Герона для вычисления площади треугольника
        }
    }
    //связываем класс с родительским Rectangle; наследуется все кроме конструкторов
    //множественное наследование не допускается - только один объект-родитель, но матрешку делать можно
    //sealed - запрещает наследовать от класса
    //нельзя наследовать от статического класса - т.е. класс содержит только статические элементы и поля, т.е. доступные всем
    //у классов по умолчание уровень доступа internal
    //модификаторы доступа - как у родительского или строже; последовательность: public, internal, private
    //private свойства доступны только в том классе, в котором они определены
    //protected - уровень доступа, при котором доступны данные из наследных классов, но закрыты для других
    class RectTriangle : Triangle
    {
        public RectTriangle(double a, double b)
            : base(a, b, Math.Sqrt(a * a + b * b)) //порядок аргументов важен, вызвать родтельский конструктор как при создании вручную
        { 
        }
        public override double GetArea() //перезапись метода
        {
            return a * b / 2;

        }
       //public new double GetArea() //техника сокрытия родительского метода, когда не можем прописать virtual
       // {
       //     return a * b / 2;

       // }


        public bool IsPythagorean
        {
            get 
            { 
            return a%1==0 && b%1==0 && c%1==0;
            }
        }

    }

    class RegularTriangle //делаем класс для равностороннего треугольника
    { 
    
    }


}
