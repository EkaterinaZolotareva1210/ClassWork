using System;

namespace Example2
{
    class Program
    {
        static void Main()
        {
            // Массив фигур
            IShape[] shapes = new IShape[]
            {
                new Triangle(3,4,5),
                new Triangle(5,5,6),
                new Rectangle(4,6),
                new Rectangle(3,3)
            };

            // Демонстрация полиморфизма
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.Name);
            }
        }
    }
    //Интерфейс = контракт поведения, абстрактный класс = оболочка родителя, шаблон с пропусками, дочерние классы связаны родственно
    // Интерфейс для геометрических фигур
    public interface IShape
    {
        double CalculateArea();  // Метод для вычисления площади; сигнатура метода - без тела
        double CalculatePerimeter();  // Метод для вычисления периметра
        string Name { get; }  // Название фигуры
    }

    // Класс "Треугольник"
    public class Triangle : IShape
    {

        public string Name => "Треугольник";
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double CalculateArea()
        {
            // Формула Герона
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
        // Класс "Прямоугольник"
        public class Rectangle : IShape
        {
            public string Name => "Прямоугольник";
            public double Width { get; }
            public double Height { get; }
            

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public double GetArea()
            {
                return Width * Height;
            }

            public double GetPerimeter()
            {
                return 2 * (Width + Height);
            }
        }

    }   