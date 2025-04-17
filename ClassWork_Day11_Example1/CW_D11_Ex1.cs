using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day11_Example1
{
    internal class CW_D11_Ex1
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

        }
        public abstract class GeometryShape
        {
            public abstract string Name { get; }
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();
        }
        //Класс "Треугольник"
        public class Triangle : GeometryShape
        //{
        //    private string _name;
        //    public override string Name
        //    { 
        //        get { return _name; }  
        //        set { _name = value; }
        //    }
        //}
        public override string Name => "Треугольник";
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
            //формула Герона

        }

    }
}
