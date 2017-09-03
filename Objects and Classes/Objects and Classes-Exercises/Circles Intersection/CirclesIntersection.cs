namespace Circles_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CirclesIntersection
    {
        public static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point firstCenter = new Point() {X = line1[0], Y = line1[1]};
            Circle c1 = new Circle() { Center = firstCenter, radius = line1[2] };
           
            var line2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point secondCenter = new Point() { X = line2[0], Y = line2[1] };
            Circle c2 = new Circle() { Center = firstCenter, radius = line2[2] };

            double distance = CalculateDistance(firstCenter, secondCenter);
            bool isIntersect = IsIntersect(c1, c2, distance);

            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }

        }

        public static bool IsIntersect(Circle c1, Circle c2, double distance)
        {
            bool flag = false;
           
            if (distance <= c1.radius + c2.radius)
            {
                flag = true;
            }
            else if (distance > c1.radius + c2.radius)
            {
                flag = false;
            }

            return flag;
        }

        public static double CalculateDistance(Point point1, Point point2)
        {
            var a = Math.Abs(point1.X - point2.X);
            var b = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            
            return distance;
        }
    }
}
