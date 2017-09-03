using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            double result = 0.0;
            switch (shape)
            {
                case "triangle":
                    var sideT = double.Parse(Console.ReadLine());
                    var heightT = double.Parse(Console.ReadLine());
                    result = TriangleArea(sideT, heightT);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "square":
                    var sideS = double.Parse(Console.ReadLine());
                    result = SquareArea(sideS);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "rectangle":
                    var widthR = double.Parse(Console.ReadLine());
                    var heightR = double.Parse(Console.ReadLine());
                    result = RectangleArea(widthR, heightR);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "circle":
                    var radiusR = double.Parse(Console.ReadLine());
                    result = CircleArea(radiusR);
                    Console.WriteLine("{0:F2}", result);
                    break;
            } 

        }

        public static double TriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        public static double SquareArea(double side)
        {
            double area = side * side;
            return area;
        }

        public static double RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        public static double CircleArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }
    }
}
