namespace Distance_between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            var p1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point point1 = new Point() { X = p1[0], Y = p1[1] };
            Point point2 = new Point() { X = p2[0], Y = p2[1] };

            double distance = CalcDistance(point1, point2);

            Console.WriteLine("{0:F3}", distance);
        }

        public static double CalcDistance(Point point1, Point point2)
        {
            var a = Math.Abs(point1.X - point2.X);
            var b = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }
    }
}
