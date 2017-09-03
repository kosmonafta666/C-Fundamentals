namespace Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right 
        {
            get { return Top + Width; }
        }

        public int Bottom
        {
            get { return Left + Height; }
        }
    }
}
