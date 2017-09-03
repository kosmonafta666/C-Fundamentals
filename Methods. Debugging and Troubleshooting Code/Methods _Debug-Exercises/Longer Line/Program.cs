using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x11 = double.Parse(Console.ReadLine());
            var y11 = double.Parse(Console.ReadLine());
            var x12 = double.Parse(Console.ReadLine());
            var y12 = double.Parse(Console.ReadLine());

            var x21 = double.Parse(Console.ReadLine());
            var y21 = double.Parse(Console.ReadLine());
            var x22 = double.Parse(Console.ReadLine());
            var y22 = double.Parse(Console.ReadLine());

            double firstLineLength = LineLength(x11, y11, x12, y12);
            double secondLineLength = LineLength(x21, y21, x22, y22);

            if (firstLineLength >= secondLineLength)
            {
                double distancePoint11 = Distance(x11, y11);
                double distancePoint12 = Distance(x12, y12);

                if (distancePoint11 <= distancePoint12)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x11, y11, x12, y12);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x12, y12, x11, y11);
                }

            }
            else
            {
                double distancePoint21 = Distance(x21, y21);
                double distancePoint22 = Distance(x22, y22);

                if (distancePoint21 <= distancePoint22)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x21, y21, x22, y22);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x22, y22, x21, y21);
                }
            }

        }

        public static double LineLength(double x1, double y1, double x2, double y2)
        {
            double lineLenght = Math.Sqrt((x2 - x1) + (y2 - y1));
            return lineLenght;
        }

        public static double Distance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return distance;
        }
    }
}
