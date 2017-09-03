using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)persons / capacity);

            /*if (persons % capacity != 0)
            {
                courses++;
            }
            */
            Console.WriteLine(courses);
        }
    }
}
