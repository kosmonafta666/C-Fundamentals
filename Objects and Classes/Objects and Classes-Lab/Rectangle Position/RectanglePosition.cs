namespace Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rectangle1 = new Rectangle()
            {
                Top = line1[0],
                Left = line1[1],
                Width = line1[2],
                Height = line1[3]
            };

            var rectangle2 = new Rectangle()
            {
                Top = line2[0],
                Left = line2[1],
                Width = line2[2],
                Height = line2[3]
            };

            bool isInside = Isinside(rectangle1, rectangle2);
            
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else 
            {
                Console.WriteLine("Not inside");
            }
        }

        public static bool Isinside(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool flag = true;

            if (rectangle1.Left >= rectangle2.Left && rectangle1.Right <= rectangle2.Right && rectangle1.Top >= rectangle2.Top && rectangle1.Bottom <= rectangle2.Bottom)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        
    }
}
