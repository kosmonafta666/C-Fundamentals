using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideCube = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();
            double result = 0.0;
            switch (parameter)
            {
                case "face":
                    result = CubeFace(sideCube);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "space":
                    result = CubeSpace(sideCube);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "volume":
                    result = CubeVolume(sideCube);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "area":
                    result = CubeArea(sideCube);
                    Console.WriteLine("{0:F2}", result);
                    break;
            }
        }

        public static double CubeFace(double sideCube)
        {
            double cubeFace = Math.Sqrt(2 * (sideCube * sideCube));
            return cubeFace;
        }

        public static double CubeSpace(double sideCube)
        {
            double cubeFace = Math.Sqrt(3 * (sideCube * sideCube));
            return cubeFace;
        }

        public static double CubeVolume(double sideCube) 
        {
            double cubeFace = Math.Pow(sideCube, 3);
            return cubeFace;
        }

        public static double CubeArea(double sideCube)
        {
            double cubeFace = 6 * (sideCube * sideCube);
            return cubeFace;
        }
    }
}
