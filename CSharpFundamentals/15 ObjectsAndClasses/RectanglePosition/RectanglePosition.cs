using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public static Rectangle ReadRectangle()
        {
            var coords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p = new Rectangle()
            {
                Left = coords[0],
                Top = coords[1],
                Width = coords[2],
                Height = coords[3]
            };
            return p;
        }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }  
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }        

        public static bool IsFirstInsideSecond(Rectangle r1, Rectangle r2)
        {
            bool inside =
                r1.Left >= r2.Left &&
                r1.Top >= r2.Top &&
                r1.Right <= r2.Right &&
                r1.Bottom <= r2.Bottom;

            return inside;
        }
    }
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var r1 = Rectangle.ReadRectangle();
            var r2 = Rectangle.ReadRectangle();
            Console.WriteLine(Rectangle.IsFirstInsideSecond(r1, r2) ? "Inside" : "Not inside");
        }
    }
}
