using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Day8_Ex6
{
    internal class CW_D8_Ex6
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            try
            {
                ValidateCoordinates( x, y);
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void ValidateCoordinates(int x, int y)
        {
            if (x < 0 || x > 100)
                throw new ArgumentException($"x={x} не попадает в диапазон");
            if (y < 0 || y > 100)
                throw new ArgumentException($"y={y} не попадает в диапазон");
        }
    }
}
