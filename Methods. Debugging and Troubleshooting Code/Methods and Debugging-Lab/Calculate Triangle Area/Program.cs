using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(width, height);

            Console.WriteLine(triangleArea);

        }

        public static double GetTriangleArea(double width, double height) 
        {
            return (width * height) / 2;
        }

    }
}
