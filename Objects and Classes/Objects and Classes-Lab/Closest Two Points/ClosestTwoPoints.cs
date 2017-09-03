namespace Closest_Two_Points
{
    using Distance_between_Points;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ClosestTwoPoints
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listPoint = new List<Point>();
 
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var point = new Point();
                point.X = line[0];
                point.Y = line[1];
                listPoint.Add(point);
            }

            Point[] closestPoints = FindClosestPoints(listPoint);

            Console.WriteLine("{0:F3}", CalcDistance(closestPoints[0], closestPoints[1]));

            foreach (var point in closestPoints)
            {
                Console.WriteLine("{0} {1}", point.X, point.Y);
            }
        }

        public static double CalcDistance(Point point1, Point point2)
        {
            var a = Math.Abs(point1.X - point2.X);
            var b = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return distance;
        }

        public static Point[] FindClosestPoints(List<Point> points)
        {
            var closestPoints = new Point[2];
            var minDistance = double.MaxValue;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = CalcDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            return closestPoints;
        }
    }
}
